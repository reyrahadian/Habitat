
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Media.Poco
{
    public class Background_Type_Folder 
    {

    }
}
namespace Sitecore.Feature.Media.Poco
{
    public class Background_Type 
    {
   
        public string Class { get; set; }
    }
}
namespace Sitecore.Feature.Media.Poco
{
    public interface IHasMediaVideo : Sitecore.Feature.Media.Poco.IHasMedia
    {
   
         LinkField MediaVideoLink { get; set; }
    }
}
namespace Sitecore.Feature.Media.Poco.ParametersTemplates
{
    public interface IMediaParameters 
    {

    }
}
namespace Sitecore.Feature.Media.Poco
{
    public interface IHasMedia 
    {
   
         string MediaDescription { get; set; }   
         ImageField MediaThumbnail { get; set; }   
         string MediaTitle { get; set; }
    }
}
namespace Sitecore.Feature.Media.Poco
{
    public interface IHasMediaSelector 
    {
   
         IEnumerable<Guid> MediaSelector { get; set; }
    }
}
namespace Sitecore.Feature.Media.Poco.ParametersTemplates
{
    public class ParametersTemplate_SectionBackground 
    {
   
        public Guid Media { get; set; }   
        public bool Parallax { get; set; }   
        public string Type { get; set; }
    }
}
namespace Sitecore.Feature.Media.Poco
{
    public interface IMediaSiteExtension 
    {
   
         Guid Mediafolder { get; set; }
    }
}
namespace Sitecore.Feature.Media.Poco
{
    public interface IHasMediaImage : Sitecore.Feature.Media.Poco.IHasMedia
    {
   
         ImageField MediaImage { get; set; }
    }
}
