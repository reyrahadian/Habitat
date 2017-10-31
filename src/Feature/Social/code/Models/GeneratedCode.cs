
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Social.Poco
{
    public interface ITwitterFeed 
    {
   
         LinkField TwitterUrl { get; set; }   
         string WidgetId { get; set; }   
         string FeedTitle { get; set; }
    }
}
namespace Sitecore.Feature.Social.Poco
{
    public interface ITwitterFeedRenderingProperties : Sitecore.Foundation.Theming.Poco.IParametersTemplate_HasBackground
    {
   
         string TweetsToShow { get; set; }
    }
}
namespace Sitecore.Feature.Social.Poco
{
    public interface IOpenGraph 
    {
   
         string OpenGraphDescription { get; set; }   
         ImageField OpenGraphImage { get; set; }   
         string OpenGraphTitle { get; set; }
    }
}
