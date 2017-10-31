
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Demo.Poco
{
    public interface ICampaignToken : Sitecore.Feature.Demo.Poco.IToken
    {
   
         Guid Token_Value { get; set; }
    }
}
namespace Sitecore.Feature.Demo.Poco
{
    public interface IDemoContent 
    {
   
         string HTML_Content { get; set; }   
         string Area_Code { get; set; }   
         string Business_Name { get; set; }   
         string City { get; set; }   
         string Country { get; set; }   
         string DNS { get; set; }   
         string ISP { get; set; }   
         string Latitude { get; set; }   
         string Longitude { get; set; }   
         string Metro_Code { get; set; }   
         string Postal_Code { get; set; }   
         string Region { get; set; }   
         string Url { get; set; }   
         string IP_Address { get; set; }   
         string Referrer { get; set; }
    }
}
namespace Sitecore.Feature.Demo.Poco
{
    public interface ITextToken : Sitecore.Feature.Demo.Poco.IToken
    {
   
         string Token_Value { get; set; }
    }
}
namespace Sitecore.Feature.Demo.Poco
{
    public interface ILinkToken : Sitecore.Feature.Demo.Poco.IToken
    {
   
         LinkField Token_Value { get; set; }
    }
}
namespace Sitecore.Feature.Demo.Poco
{
    public interface IToken 
    {

    }
}
namespace Sitecore.Feature.Demo.Poco
{
    public interface IProfilingSettings 
    {
   
         IEnumerable<Guid> SiteProfiles { get; set; }
    }
}
