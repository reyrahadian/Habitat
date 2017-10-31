
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Metadata.Poco
{
    public interface IKeyword 
    {
   
         string Keyword { get; set; }
    }
}
namespace Sitecore.Feature.Metadata.Poco
{
    public interface ISiteMetadata 
    {
   
         string SiteBrowserTitle { get; set; }
    }
}
namespace Sitecore.Feature.Metadata.Poco
{
    public interface IPageMetadata 
    {
   
         string BrowserTitle { get; set; }   
         bool CanIndex { get; set; }   
         System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }   
         string MetaDescription { get; set; }   
         IEnumerable<Guid> MetaKeywords { get; set; }   
         bool SeoFollowLinks { get; set; }
    }
}
