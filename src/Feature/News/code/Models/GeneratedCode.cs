
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.News.Poco
{
    public interface INewsArticle 
    {
   
         string NewsBody { get; set; }   
         DateTime NewsDate { get; set; }   
         ImageField NewsImage { get; set; }   
         string NewsSummary { get; set; }   
         string NewsTitle { get; set; }
    }
}
namespace Sitecore.Feature.News.Poco
{
    public interface INewsFolder 
    {

    }
}
