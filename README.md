#Sitecore Habitat

Habitat is a Sitecore solution example built on a modular architecture.
The architecture and methodology focuses on:

* Simplicity - *A consistent and discoverable architecture*
* Flexibility - *Change and add quickly and without worry*
* Extensibility - *Simply add new features without steep learning curve*

For more information, please check out the [Habitat Wiki](https://github.com/Sitecore/Habitat/wiki)

## Differences than the original

This version of Habitat is using Team Development For Sitecore for Item Serialization and Deployments.

Team Development for Sitecore is a Visual Studio plug-in managed by Hedgehog Development. At its core, it provides companies with the ability to automate their Sitecore builds or set up a continuous deployment scenarios. TDS provides several additional features its users find valuable, for more information visit: www.teamdevelopmentforsitecore.com.

There was a duplicate named item at `/sitecore/content/Habitat/Global/Media/Dependencies`. In the TDS version we've renamed one of these items to `DependenciesFolder` instead.

## Differences in Installation:

1. Clone this repository to your local file system.
2. Set up a clean Sitecore 8.2 website in the URL http://habitat.dev.local/ and the location C:\Websites\Habitat.local\ (We recommend using Sitecore Instance Manager).
3. Install the Webforms for Marketers module
4. Open the solution in Visual Studio.
5. Ensure you have setup a NuGet Source to the Sitecore NuGet Public Feed. (use the NuGet v3 feed) [https://doc.sitecore.net/sitecore_experience_platform/82/developing/developing_with_sitecore/sitecore_public_nuget_packages_faq](https://doc.sitecore.net/sitecore_experience_platform/82/developing/developing_with_sitecore/sitecore_public_nuget_packages_faq)
6. (optional) Configuring your settings if you are using other settings than default:
To change the standard location of source, website files and website URL modify the following files:
  - /Configuration/z.Habitat.DevSettings.config
  - /Configuration/TdsGlobal.config
7. Deploy the Solution (Right click on the solution file -> Deploy Solution)
   (This will restore the packages, build and deploy the code and items to your local site).
8. Be productive!
