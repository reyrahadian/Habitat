
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Teasers.Poco
{
    public interface ITeaserVideoContent : Sitecore.Feature.Teasers.Poco.ITeaserContent
    {
   
         LinkField VideoLink { get; set; }
    }
}
namespace Sitecore.Feature.Teasers.Poco
{
    public interface ITeasersParameters : Sitecore.Foundation.Theming.Poco.IParametersTemplate_HasBackground, Sitecore.Foundation.Theming.Poco.IParametersTemplate_FixedHeight
    {

    }
}
namespace Sitecore.Feature.Teasers.Poco
{
    public interface IDynamicTeaser 
    {
   
         int Active { get; set; }   
         int Count { get; set; }
    }
}
namespace Sitecore.Feature.Teasers.Poco
{
    public interface IHeadline 
    {
   
         Guid Teaser_Icon { get; set; }   
         string TeaserTitle { get; set; }
    }
}
namespace Sitecore.Feature.Teasers.Poco
{
    public class Icon 
    {
   
        public string CssClass { get; set; }
    }
}
namespace Sitecore.Feature.Teasers.Poco
{
    public interface ITeaserContent : Sitecore.Feature.Teasers.Poco.IHeadline
    {
   
         string Teaser_Label { get; set; }   
         ImageField TeaserImage { get; set; }   
         LinkField TeaserLink { get; set; }   
         string TeaserSummary { get; set; }
    }
}
