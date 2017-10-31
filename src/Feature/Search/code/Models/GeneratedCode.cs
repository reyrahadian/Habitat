
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Search.Poco
{
    public interface ISearchResults 
    {
   
         IEnumerable<Guid> Facets { get; set; }   
         Guid Root { get; set; }   
         string SearchBoxTitle { get; set; }
    }
}
namespace Sitecore.Feature.Search.Poco
{
    public interface ISearchContext 
    {
   
         LinkField Search_Results_Page { get; set; }
    }
}
namespace Sitecore.Feature.Search.Poco
{
    public interface IPagedSearchResultsParameters 
    {
   
         string PagesToShow { get; set; }   
         string ResultsOnPage { get; set; }
    }
}
