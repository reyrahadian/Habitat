
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Foundation.Assets.Poco
{
    public class Theme_Folder 
    {

    }
}
namespace Sitecore.Foundation.Assets.Poco
{
    public class Theme : Sitecore.Foundation.Assets.Poco.IRenderingAssets
    {
#region Interface IRenderingAssets
  
        public string Css_assets { get; set; }
  
        public string Css_inline { get; set; }
  
        public string JavaScript_assets { get; set; }
  
        public string JavaScript_inline { get; set; }
#endregion

    }
}
namespace Sitecore.Foundation.Assets.Poco.System.Layout.Renderings
{
    public class Controller_rendering : Sitecore.Foundation.Assets.Poco.IRenderingAssets
    {
#region Interface IRenderingAssets
  
        public string Css_assets { get; set; }
  
        public string Css_inline { get; set; }
  
        public string JavaScript_assets { get; set; }
  
        public string JavaScript_inline { get; set; }
#endregion

    }
}
namespace Sitecore.Foundation.Assets.Poco
{
    public interface IHasTheme 
    {
   
         Guid Theme { get; set; }
    }
}
namespace Sitecore.Foundation.Assets.Poco
{
    public interface IRenderingAssets 
    {
   
         string Css_assets { get; set; }   
         string Css_inline { get; set; }   
         string JavaScript_assets { get; set; }   
         string JavaScript_inline { get; set; }
    }
}
namespace Sitecore.Foundation.Assets.Poco
{
    public interface IPageAssets 
    {
   
         string CssCode { get; set; }   
         bool InheritAssets { get; set; }   
         string JavascriptCodeBottom { get; set; }   
         string JavascriptCodeTop { get; set; }
    }
}
namespace Sitecore.Foundation.Assets.Poco.System.Layout.Renderings
{
    public class View_rendering : Sitecore.Foundation.Assets.Poco.IRenderingAssets
    {
#region Interface IRenderingAssets
  
        public string Css_assets { get; set; }
  
        public string Css_inline { get; set; }
  
        public string JavaScript_assets { get; set; }
  
        public string JavaScript_inline { get; set; }
#endregion

    }
}
