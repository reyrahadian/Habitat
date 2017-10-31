
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Navigation.Poco
{
    public interface ILinkMenuItem : Sitecore.Feature.Navigation.Poco.ILink
    {
   
         bool DividerBefore { get; set; }   
         string Icon { get; set; }
    }
}
namespace Sitecore.Feature.Navigation.Poco
{
    public interface ILink 
    {
   
         LinkField Link { get; set; }
    }
}
namespace Sitecore.Feature.Navigation.Poco
{
    public interface INavigable 
    {
   
         string NavigationTitle { get; set; }   
         bool ShowChildren { get; set; }   
         bool ShowInNavigation { get; set; }
    }
}
namespace Sitecore.Feature.Navigation.Poco
{
    public interface INavigationRoot 
    {

    }
}
