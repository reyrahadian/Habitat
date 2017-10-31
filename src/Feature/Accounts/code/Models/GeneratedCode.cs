
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Accounts.Poco
{
    public interface IMailTemplate 
    {
   
         string Body { get; set; }   
         string From { get; set; }   
         string Subject { get; set; }
    }
}
namespace Sitecore.Feature.Accounts.Poco
{
    public interface IProfileSettings 
    {
   
         Guid Interests_Folder { get; set; }   
         Guid User_Profile { get; set; }
    }
}
namespace Sitecore.Feature.Accounts.Poco
{
    public interface IAccountsSettings 
    {
   
         LinkField Accounts_Details_Page { get; set; }   
         LinkField After_Login_Page { get; set; }   
         LinkField Forgot_Password_Mail_Template { get; set; }   
         LinkField Forgot_Password_Page { get; set; }   
         LinkField Login_Page { get; set; }   
         Guid Register_Outcome { get; set; }   
         LinkField Register_Page { get; set; }
    }
}
namespace Sitecore.Feature.Accounts.Poco
{
    public interface IInterest 
    {
   
         string Title { get; set; }
    }
}
namespace Sitecore.Feature.Accounts.Poco
{
    public interface ILoginTeaser 
    {
   
         string Logged_In_Summary { get; set; }   
         string Logged_In_Title { get; set; }   
         string Summary { get; set; }   
         string Title { get; set; }
    }
}
