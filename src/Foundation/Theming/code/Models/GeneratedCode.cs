
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Foundation.Theming.Poco
{
    public interface IParametersTemplate_HasContainer 
    {
   
         bool ContainerIsFluid { get; set; }
    }
}
namespace Sitecore.Foundation.Theming.Poco
{
    public interface IParametersTemplate_FixedHeight 
    {
   
         bool Fixed_height { get; set; }
    }
}
namespace Sitecore.Foundation.Theming.Poco
{
    public interface IParametersTemplate_HasContainerWithBackground : Sitecore.Foundation.Theming.Poco.IParametersTemplate_HasBackground, Sitecore.Foundation.Theming.Poco.IParametersTemplate_HasContainer
    {

    }
}
namespace Sitecore.Foundation.Theming.Poco
{
    public interface IParametersTemplate_HasBackground 
    {
   
         Guid Background { get; set; }
    }
}
namespace Sitecore.Foundation.Theming.Poco
{
    public class Style 
    {
   
        public string Class { get; set; }
    }
}
