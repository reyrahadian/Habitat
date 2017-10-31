
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Person.Poco
{
    public interface IEmployee : Sitecore.Feature.Person.Poco.IPerson
    {
   
         string Email { get; set; }   
         string Mobile { get; set; }   
         string Telephone { get; set; }   
         string Biography { get; set; }   
         LinkField BlogLink { get; set; }   
         LinkField FacebookLink { get; set; }   
         LinkField LinkedInLink { get; set; }   
         LinkField TwitterLink { get; set; }
    }
}
namespace Sitecore.Feature.Person.Poco
{
    public interface IQuote : Sitecore.Feature.Person.Poco.IPerson
    {
   
         string Cite_Origin { get; set; }   
         string Quote { get; set; }
    }
}
namespace Sitecore.Feature.Person.Poco
{
    public interface IPerson 
    {
   
         string Name { get; set; }   
         ImageField Picture { get; set; }   
         string Summary { get; set; }   
         string Title { get; set; }
    }
}
