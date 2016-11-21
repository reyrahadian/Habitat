var gulp = require("gulp");
var del = require("del");
var msbuild = require("gulp-msbuild");
var debug = require("gulp-debug");
var foreach = require("gulp-foreach");
var rename = require("gulp-rename");
var watch = require("gulp-watch");
var merge = require("merge-stream");
var newer = require("gulp-newer");
var util = require("gulp-util");
var runSequence = require("run-sequence");
var path = require("path");
var config = require("./gulp-config.js")();
var nugetRestore = require('gulp-nuget-restore');
var fs = require('fs');
var unicorn = require("./scripts/unicorn.js");
var habitat = require("./scripts/habitat.js");

module.exports.config = config;

gulp.task("default", function (callback) {
  config.runCleanBuilds = true;
  return runSequence(
    "01-Copy-Sitecore-License",
    "02-Nuget-Restore",
    "03-Publish-All-Projects",
    "04-Apply-Xml-Transform",
    "05-Sync-Unicorn",
    "06-Deploy-Transforms",
    callback);
});

/*****************************
  Initial setup
*****************************/
gulp.task("01-Copy-Sitecore-License", function () {
  console.log("Copying Sitecore License file");

  return gulp.src(config.licensePath).pipe(gulp.dest("./lib"));
});

gulp.task("02-Nuget-Restore", function (callback) {
  var solution = "./" + config.solutionName + ".sln";
  return gulp.src(solution).pipe(nugetRestore());
});


gulp.task("03-Publish-All-Projects", function (callback) {
  return runSequence(
    "Build-Solution",
    "Publish-Foundation-Projects",
    "Publish-Feature-Projects",
    "Publish-Project-Projects", callback);
});

gulp.task("04-Apply-Xml-Transform", function () {
  var layerPathFilters = ["./src/Foundation/**/*.transform", "./src/Feature/**/*.transform", "./src/Project/**/*.transform", "!./src/**/obj/**/*.transform", "!./src/**/bin/**/*.transform"];
  return gulp.src(layerPathFilters)
    .pipe(foreach(function (stream, file) {
      var fileToTransform = file.path.replace(/.+code\\(.+)\.transform/, "$1");
      util.log("Applying configuration transform: " + file.path);
      return gulp.src("./applytransform.targets")
        .pipe(msbuild({
          targets: ["ApplyTransform"],
          configuration: config.buildConfiguration,
          logCommand: false,
          verbosity: "minimal",
          stdout: true,
          errorOnFail: true,
          maxcpucount: 0,
          toolsVersion: 14.0,
          properties: {
            WebConfigToTransform: config.websiteRoot,
            TransformFile: file.path,
            FileToTransform: fileToTransform
          }
        }));
    }));
});

gulp.task("05-Sync-Unicorn", function (callback) {
  var options = {};
  options.siteHostName = habitat.getSiteUrl();
  options.authenticationConfigFile = config.websiteRoot + "/App_config/Include/Unicorn/Unicorn.UI.config";

  unicorn(function() { return callback() }, options);
});


gulp.task("06-Deploy-Transforms", function () {
  return gulp.src("./src/**/code/**/*.transform")
      .pipe(gulp.dest(config.websiteRoot + "/temp/transforms"));
});

gulp.task("07-SwitchToZeroDeploy", function (callback) {
    return runSequence(
        "Publish-All-ZeroDeployConfigs",
        "Remove-All-ZeroDeployDLLs",
        "Turn-On-Base-Zero-Deploy-Config", callback);
});

gulp.task("08-SwitchOffZeroDeploy", function (callback) {
    return runSequence(
        "Delete-All-Zero-Deploy-Configs",
        "Turn-Off-Base-Zero-Deploy-Config",
        "Publish-Assemblies", callback);
});

/*****************************
  Copy assemblies to all local projects
*****************************/
gulp.task("Copy-Local-Assemblies", function () {
  console.log("Copying site assemblies to all local projects");
  var files = config.sitecoreLibraries + "/**/*";

  var root = "./src";
  var projects = root + "/**/code/bin";
  return gulp.src(projects, { base: root })
    .pipe(foreach(function (stream, file) {
      console.log("copying to " + file.path);
      gulp.src(files)
        .pipe(gulp.dest(file.path));
      return stream;
    }));
});

/*****************************
  Publish
  @param {string} location
  @param {string} dest
  @returns async
*****************************/
var publishProjects = function (location, dest) {
  dest = dest || config.websiteRoot;
  var targets = ["Build"];

  console.log("publish to " + dest + " folder");
  return gulp.src([location + "/**/code/*.csproj"])
    .pipe(foreach(function (stream, file) {
      return stream
        .pipe(debug({ title: "Building project:" }))
        .pipe(msbuild({
          targets: targets,
          configuration: config.buildConfiguration,
          logCommand: false,
          verbosity: "minimal",
          stdout: true,
          errorOnFail: true,
          maxcpucount: 0,
          toolsVersion: 14.0,
          properties: {
            DeployOnBuild: "true",
            DeployDefaultTarget: "WebPublish",
            WebPublishMethod: "FileSystem",
            DeleteExistingFiles: "false",
            publishUrl: dest,
            _FindDependencies: "false"
          }
        }));
    }));
};

gulp.task("Build-Solution", function () {
  var targets = ["Build"];
  if (config.runCleanBuilds) {
    targets = ["Clean", "Build"];
  }
  var solution = "./" + config.solutionName + ".sln";
  return gulp.src(solution)
      .pipe(msbuild({
          targets: targets,
          configuration: config.buildConfiguration,
          logCommand: false,
          verbosity: "minimal",
          stdout: true,
          errorOnFail: true,
          maxcpucount: 0,
          toolsVersion: 14.0
        }));
});

gulp.task("Publish-Foundation-Projects", function () {
  return publishProjects("./src/Foundation");
});

gulp.task("Publish-Feature-Projects", function () {
  return publishProjects("./src/Feature");
});

gulp.task("Publish-Project-Projects", function () {
  return publishProjects("./src/Project");
});

gulp.task("Publish-Assemblies", function () {
  var root = "./src";
  var binFiles = root + "/**/code/**/bin/Sitecore.{Feature,Foundation,Habitat}.*.{dll,pdb}";
  var destination = config.websiteRoot + "/bin/";
  return gulp.src(binFiles, { base: root })
    .pipe(rename({ dirname: "" }))
    .pipe(newer(destination))
    .pipe(debug({ title: "Copying " }))
    .pipe(gulp.dest(destination));
});

gulp.task("Publish-All-Views", function () {
  var root = "./src";
  var roots = [root + "/**/Views", "!" + root + "/**/obj/**/Views"];
  var files = "/**/*.cshtml";
  var destination = config.websiteRoot + "\\Views";
  return gulp.src(roots, { base: root }).pipe(
    foreach(function (stream, file) {
      console.log("Publishing from " + file.path);
      gulp.src(file.path + files, { base: file.path })
        .pipe(newer(destination))
        .pipe(debug({ title: "Copying " }))
        .pipe(gulp.dest(destination));
      return stream;
    })
  );
});

gulp.task("Publish-All-Configs", function () {
  var root = "./src";
  var roots = [root + "/**/App_Config", "!" + root + "/**/obj/**/App_Config"];
  var files = "/**/*.config";
  var destination = config.websiteRoot + "\\App_Config";
  return gulp.src(roots, { base: root }).pipe(
    foreach(function (stream, file) {
      console.log("Publishing from " + file.path);
      gulp.src(file.path + files, { base: file.path })
        .pipe(newer(destination))
        .pipe(debug({ title: "Copying " }))
        .pipe(gulp.dest(destination));
      return stream;
    })
  );
});

gulp.task("Publish-All-Zero-Deploy-Configs", function () {
    var root = "./src";
    var relativeDir = "/**/**/code/App_Config/Include/zzz";

    var files = [root + relativeDir + "/ZeroDeploy.*.config",
                 "!" + root + relativeDir + "/ZeroDeploy.*.Debug.config",
                 "!" + root + relativeDir + "/ZeroDeploy.*.Release.config",
                 "!" + root + relativeDir + "/ZeroDeploy.*.ZeroDeploy.config",
                 "!" + root + relativeDir + "/**/obj/**/App_Config"];
    var destination = config.websiteRoot + "\\App_Config\\Include\\zzz";

    return gulp.src(files, { base: relativeDir })
            .pipe(debug({ title: "Copying " }))
            .pipe(gulp.dest(destination));
});

gulp.task("Delete-All-Zero-Deploy-Configs", function () {

    var zeroDeployFiles = [config.websiteRoot + "/App_Config/Include/zzz/ZeroDeploy.*.config"];

    return del(zeroDeployFiles, { force: true });
});

gulp.task("Remove-All-Zero-Deploy-DLLs", function () {
    var zeroDeployDlls = [config.websiteRoot + "/bin/Sitecore.Feature.*",
                          config.websiteRoot + "/bin/Sitecore.Foundation.*",
                          config.websiteRoot + "/bin/Sitecore.Common.Website.*",
                          config.websiteRoot + "/bin/Sitecore.Habitat.Website.*",
                          "!" + config.websiteRoot + "/bin/Sitecore.Foundation.SitecoreExtensions.*"]
    return del(zeroDeployDlls, { force: true });
});

gulp.task("Turn-On-Base-Zero-Deploy-Config", function () {
    var includeFolder = config.websiteRoot + "/App_Config/Include";
    var zeroDeployConfigName = includeFolder + "/ZeroDeploy.config"
    var disabledFilename = zeroDeployConfigName + ".disabled"

    gulp.src(disabledFilename)
        .pipe(rename(zeroDeployConfigName))
        .pipe(gulp.dest("."));

    del(disabledFilename, { force: true });

});

gulp.task("Turn-Off-Base-Zero-Deploy-Config", function () {
    var includeFolder = config.websiteRoot + "/App_Config/Include";
    var zeroDeployConfigName = includeFolder + "/ZeroDeploy.config"
    var disabledFilename = zeroDeployConfigName + ".disabled"

    gulp.src(zeroDeployConfigName)
        .pipe(rename(disabledFilename))
        .pipe(gulp.dest("."));

    del(zeroDeployConfigName, { force: true });

});

/*****************************
 Watchers
*****************************/
gulp.task("Auto-Publish-Css", function () {
  var root = "./src";
  var roots = [root + "/**/styles", "!" + root + "/**/obj/**/styles"];
  var files = "/**/*.css";
  var destination = config.websiteRoot + "\\styles";
  gulp.src(roots, { base: root }).pipe(
    foreach(function (stream, rootFolder) {
      gulp.watch(rootFolder.path + files, function (event) {
        if (event.type === "changed") {
          console.log("publish this file " + event.path);
          gulp.src(event.path, { base: rootFolder.path }).pipe(gulp.dest(destination));
        }
        console.log("published " + event.path);
      });
      return stream;
    })
  );
});

gulp.task("Auto-Publish-Views", function () {
  var root = "./src";
  var roots = [root + "/**/Views", "!" + root + "/**/obj/**/Views"];
  var files = "/**/*.cshtml";
  var destination = config.websiteRoot + "\\Views";
  gulp.src(roots, { base: root }).pipe(
    foreach(function (stream, rootFolder) {
      gulp.watch(rootFolder.path + files, function (event) {
        if (event.type === "changed") {
          console.log("publish this file " + event.path);
          gulp.src(event.path, { base: rootFolder.path }).pipe(gulp.dest(destination));
        }
        console.log("published " + event.path);
      });
      return stream;
    })
  );
});

gulp.task("Auto-Publish-Assemblies", function () {
  var root = "./src";
  var roots = [root + "/**/code/**/bin"];
  var files = "/**/Sitecore.{Feature,Foundation,Habitat}.*.{dll,pdb}";;
  var destination = config.websiteRoot + "/bin/";
  gulp.src(roots, { base: root }).pipe(
    foreach(function (stream, rootFolder) {
      gulp.watch(rootFolder.path + files, function (event) {
        if (event.type === "changed") {
          console.log("publish this file " + event.path);
          gulp.src(event.path, { base: rootFolder.path }).pipe(gulp.dest(destination));
        }
        console.log("published " + event.path);
      });
      return stream;
    })
  );
});