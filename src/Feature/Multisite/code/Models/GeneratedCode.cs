
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Multisite.Poco
{
    public interface ISiteConfiguration : Sitecore.Foundation.Multisite.Poco.ISite
    {
   
         bool ShowInMenu { get; set; }   
         string Title { get; set; }
    }
}
