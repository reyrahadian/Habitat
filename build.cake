
//////////////////////////////////////////////////////////////////////
// TOOLS / ADDINS
//////////////////////////////////////////////////////////////////////

#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var solutionFilePath = "./Habitat.sln";
// Define directories.
var buildDir = Directory("./src/Example/bin") + Directory(configuration);
// Define artefact directories.
var deploymentDir = MakeAbsolute(File("./_Deployment")).FullPath;
var outputDir = deploymentDir + "/Output";

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean-Deployment-Folder")
    .Does(()=>
{
    EnsureDirectoryExists(deploymentDir);
    CleanDirectory(deploymentDir);
    EnsureDirectoryExists(outputDir);
});

Task("Create-TDS-Packages")
    .Does(()=>
{
    //TODO
});

Task("Create-TDS-Delta-Packages-DateAfter")
    .Does(()=>
{
    //TODO
});

Task("Create-TDS-Delta-Packages-DateSince")
    .Does(()=>
{
    //TODO
});

Task("Create-TDS-Delta-Packages-GitDelta")
    .Does(()=>
{
    //TODO
});

Task("Restore-NuGet-Packages")    
    .Does(() =>
{
    NuGetRestore(solutionFilePath);
});

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
{  
      // Use MSBuild
      MSBuild(solutionFilePath, settings =>
        settings.SetConfiguration(configuration)); 
});


//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Build");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);