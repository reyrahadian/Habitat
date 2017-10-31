
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Maps.Poco
{
    public class Map_Type 
    {
   
        public string Name { get; set; }
    }
}
namespace Sitecore.Feature.Maps.Poco
{
    public interface IMapPoint 
    {
   
         string MapPointAddress { get; set; }   
         object /* UNKNOWN (Map Field) */ MapPointLocation { get; set; }   
         string MapPointName { get; set; }
    }
}
namespace Sitecore.Feature.Maps.Poco
{
    public interface IMapPoints_Folder 
    {

    }
}
namespace Sitecore.Feature.Maps.Poco
{
    public interface IMapRenderingParameters 
    {
   
         string CenterLocation { get; set; }   
         bool EnableCenterMapControl { get; set; }   
         bool EnableMapTypeControl { get; set; }   
         bool EnableRotateControl { get; set; }   
         bool EnableScaleControl { get; set; }   
         bool EnableStreetViewControl { get; set; }   
         bool EnableZoomControl { get; set; }   
         string MapType { get; set; }   
         string ZoomLevel { get; set; }
    }
}
