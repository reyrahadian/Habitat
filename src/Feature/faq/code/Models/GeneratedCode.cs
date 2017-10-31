
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.FAQ.Poco
{
    public interface IFAQ_Group 
    {
   
         IEnumerable<Guid> Group_Member { get; set; }
    }
}
namespace Sitecore.Feature.FAQ.Poco
{
    public interface IFAQ 
    {
   
         string Answer { get; set; }   
         string Question { get; set; }
    }
}
