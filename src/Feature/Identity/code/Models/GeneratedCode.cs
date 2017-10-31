
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Identity.Poco
{
    public interface IIdentity 
    {
   
         string Copyright { get; set; }   
         string Logo_Tagline { get; set; }   
         ImageField Logo { get; set; }   
         string OrganisationAddress { get; set; }   
         LinkField OrganisationEmail { get; set; }   
         string OrganisationName { get; set; }   
         string OrganisationPhone { get; set; }
    }
}
