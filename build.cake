//////////////////////////////////////////////////////////////////////
// COMMAND EXAMPLES
//////////////////////////////////////////////////////////////////////

// Generate full TDS packages 
// .\build.ps1 -target Create-TDS-Packages

// Generate TDS delta package by date after
// .\build.ps1 -target Create-TDS-Delta-Packages-DateAfter -ScriptArgs:'--includeItemsChangedAfter="2016-12-30"'

//////////////////////////////////////////////////////////////////////
// TOOLS / ADDINS
//////////////////////////////////////////////////////////////////////

#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var tdsIncludeItemsChangedAfter = Argument("includeItemsChangedAfter", "");

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
    .Does(()=>
    {
        configuration = "TdsPackage";    
        RunTarget("Clean-TDS-Projects-Package-Folder");        
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
        configuration = "TdsPackage";
        var tdsProjectSuffixes = new string[]{".core",".master",".content",".media"};    
        var solution = ParseSolution(solutionFilePath);    
        var tdsProjects = solution.Projects.Where(p=> tdsProjectSuffixes.Any(x=> p.Name.ToLower().EndsWith(x)));
        foreach(var project in tdsProjects)
        {        
            var path = project.Path + "/../bin/Package_"+configuration;            
            if(DirectoryExists(path))
            {
                Information(path);
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
    .IsDependentOn("Clean-Deployment-Folder")
    .IsDependentOn("Restore-NuGet-Packages")    
    .Does(()=>
    {
        if(string.IsNullOrWhiteSpace(tdsIncludeItemsChangedAfter))
        {
            throw new ArgumentException("tdsIncludeItemsChangedAfter cannot be empty");
        }

        configuration = "TdsPackage";    
        RunTarget("Clean-TDS-Projects-Package-Folder");        
        MSBuild(solutionFilePath, settings =>
            {
                settings.SetConfiguration(configuration);
                settings.SetMaxCpuCount(0);                                
                settings.WithProperty("IncludeItemsChangedAfter",tdsIncludeItemsChangedAfter);
            });    
        
        RunTarget("Copy-TDS-Packages-To-Output-Folder");
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