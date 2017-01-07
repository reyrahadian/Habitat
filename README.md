#Sitecore Habitat

Habitat is a Sitecore solution example built on a modular architecture.
The architecture and methodology focuses on:

* Simplicity - *A consistent and discoverable architecture*
* Flexibility - *Change and add quickly and without worry*
* Extensibility - *Simply add new features without steep learning curve*

For more information, please check out the [Habitat Wiki](https://github.com/Sitecore/Habitat/wiki)

## Differences from the original repo

This version of Habitat is using Team Development For Sitecore for Item Serialization and Deployments.

Team Development for Sitecore is a Visual Studio plug-in managed by Hedgehog Development. At its core, it provides companies with the ability to automate their Sitecore builds or set up a continuous deployment scenarios. TDS provides several additional features its users find valuable, for more information visit: www.teamdevelopmentforsitecore.com.

Config transforms are implemented through XDT transforms using Visual Studio builds and TDS's in-build transforming capabilities. Therefore:-
App_Config/Security/Domains.config is patched, and directly has the transforms from the Foundation.Accounts and Project.Habitat modules in it. (Deployed from the Project.Habitat module)
Web.config is patched, and directly has the transforms from the Foundation.Forms, Foundation.Installer and Project.Common modules in it. (Deployed from the Project.Habitat module)




## Differences in Installation:

1. Clone this repository to your local file system.
2. Set up a clean Sitecore 8.2 website (We recommend using Sitecore Instance Manager). The configs have these default settings (Change them as needed, but understand where they need to be changed in the appropriate configs as well):-
 - URL: http://habitat.dev.local/ 
 - Location: C:\Websites\Habitat.local\
3. Install the Webforms for Marketers module.
4. Open the solution in Visual Studio.
5. (optional) Configure your settings if you are using other settings than default:
To change the standard location of source, website files and website URL modify the following files:
  - /Configuration/z.Habitat.DevSettings.config
  - /Configuration/TdsGlobal.config 
6. Deploy the Solution (Right click on the solution file -> Deploy Solution) in Visual Studio 2015. This will restore all NuGet packages, build the code, and deploy all Sitecore Items and Project Items to your local website.
7. Be productive!
