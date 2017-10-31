
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.PageContent.Poco
{
    public interface IHasPageContent 
    {
   
         string Body { get; set; }   
         ImageField Image { get; set; }   
         string Summary { get; set; }   
         string Title { get; set; }
    }
}
