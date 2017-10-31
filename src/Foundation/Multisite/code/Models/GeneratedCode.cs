
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Foundation.Multisite.Poco
{
    public class Site_Settings_Root 
    {

    }
}
namespace Sitecore.Foundation.Multisite.Poco
{
    public class Datasource_Settings_Folder : Sitecore.Foundation.Multisite.Poco.ISiteSettings
    {

    }
}
namespace Sitecore.Foundation.Multisite.Poco
{
    public interface ISite 
    {

    }
}
namespace Sitecore.Foundation.Multisite.Poco
{
    public interface ISiteSettings 
    {

    }
}
namespace Sitecore.Foundation.Multisite.Poco
{
    public class Datasource_Configuration : Sitecore.Foundation.Multisite.Poco.ISiteSettings
    {
   
        public object /* UNKNOWN (Datasource) */ DatasourceLocation { get; set; }   
        public LinkField DatasourceTemplate { get; set; }
    }
}
