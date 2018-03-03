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
    .IsDependentOn("Clean-Deployment-Folder")
    .IsDependentOn("Restore-NuGet-Packages")
    .IsDependentOn("Clean-TDS-Projects-Package-Folder")
    .Does(()=>
{
    configuration = "TdsPackage";    
    MSBuild(solutionFilePath, settings =>
        {
            settings.SetConfiguration(configuration);
            settings.SetMaxCpuCount(0);
        });    
    
    RunTarget("Copy-TDS-Packages-To-Output-Folder");
});
Task("Clean-Build-Directories")
    .Does(()=>
{
    MSBuild(solutionFilePath, settings =>
        {
            settings.SetConfiguration(configuration);
            settings.SetMaxCpuCount(0);
            settings.WithTarget("Clean");
        });   
});
Task("Clean-TDS-Projects-Package-Folder")
    .Does(()=>
{
    var tdsProjectSuffixes = new string[]{".core",".master",".content"};    
    var solution = ParseSolution(solutionFilePath);    
    var tdsProjects = solution.Projects.Where(p=> tdsProjectSuffixes.Any(x=> p.Name.ToLower().EndsWith(x)));
    foreach(var project in tdsProjects)
    {        
        var path = project.Path + "/bin/Package_"+configuration;
        Information(path);
        if(DirectoryExists(path))
        {
            CleanDirectory(path);
        }           
    }
});
Task("Copy-TDS-Packages-To-Output-Folder")
    .Does(()=>
{    
    CopyFiles(GetFiles("./src/**/*.update"), outputDir);   
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