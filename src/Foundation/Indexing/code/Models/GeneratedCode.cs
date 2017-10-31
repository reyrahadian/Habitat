
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Foundation.Indexing.Poco
{
    public interface IIndexedItem 
    {
   
         bool IncludeInSearchResults { get; set; }
    }
}
