
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Common.Website.Poco.Content_Types.Teasers
{
    public class Headline : Sitecore.Feature.Teasers.Poco.IHeadline
    {
#region Interface IHeadline
  
        public Guid Teaser_Icon { get; set; }
  
        public string TeaserTitle { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Map_Points_Folder : Sitecore.Feature.Maps.Poco.IMapPoints_Folder
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Interests_Folder 
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Map_Point : Sitecore.Feature.Maps.Poco.IMapPoint
    {
#region Interface IMapPoint
  
        public string MapPointAddress { get; set; }
  
        public object /* UNKNOWN (Map Field) */ MapPointLocation { get; set; }
  
        public string MapPointName { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class MetaKeyword : Sitecore.Feature.Metadata.Poco.IKeyword
    {
#region Interface IKeyword
  
        public string Keyword { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Teasers
{
    public class Teaser_Folder 
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Link_Menu_Item : Sitecore.Feature.Navigation.Poco.INavigable, Sitecore.Feature.Navigation.Poco.ILinkMenuItem
    {
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion
#region Interface ILink
  
        public LinkField Link { get; set; }
#endregion
#region Interface ILinkMenuItem
  
        public bool DividerBefore { get; set; }
  
        public string Icon { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Demo_Tokens
{
    public class Text_Token : Sitecore.Feature.Demo.Poco.ITextToken
    {
#region Interface ITextToken
  
        public string Token_Value { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Teasers
{
    public class Quote : Sitecore.Feature.Person.Poco.IPerson, Sitecore.Feature.Person.Poco.IQuote
    {
#region Interface IPerson
  
        public string Name { get; set; }
  
        public ImageField Picture { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface IQuote
  
        public string Cite_Origin { get; set; }
  
        string Sitecore.Feature.Person.Poco.IQuote.Quote { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Interest : Sitecore.Feature.Accounts.Poco.IInterest
    {
#region Interface IInterest
  
        public string Title { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class FAQ_Folder 
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Media
{
    public class Media_Background 
    {

    }
}
namespace Sitecore.Common.Website.Poco.Parameters
{
    public class ParametersTemplate_HasContainerWithDynamicPlaceholder : Sitecore.Foundation.Theming.Poco.IParametersTemplate_HasContainerWithBackground
    {
#region Interface IParametersTemplate_HasBackground
  
        public Guid Background { get; set; }
#endregion
#region Interface IParametersTemplate_HasContainer
  
        public bool ContainerIsFluid { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Page_Types
{
    public class Demo_Page : Sitecore.Feature.Demo.Poco.IDemoContent, Sitecore.Feature.Multisite.Poco.ISiteConfiguration
    {
#region Interface IDemoContent
  
        public string HTML_Content { get; set; }
  
        public string Area_Code { get; set; }
  
        public string Business_Name { get; set; }
  
        public string City { get; set; }
  
        public string Country { get; set; }
  
        public string DNS { get; set; }
  
        public string ISP { get; set; }
  
        public string Latitude { get; set; }
  
        public string Longitude { get; set; }
  
        public string Metro_Code { get; set; }
  
        public string Postal_Code { get; set; }
  
        public string Region { get; set; }
  
        public string Url { get; set; }
  
        public string IP_Address { get; set; }
  
        public string Referrer { get; set; }
#endregion
#region Interface ISiteConfiguration
  
        public bool ShowInMenu { get; set; }
  
        public string Title { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Social
{
    public class Social_Feeds_Folder 
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Demo_Tokens
{
    public class Campaign_Token : Sitecore.Feature.Demo.Poco.ICampaignToken
    {
#region Interface ICampaignToken
  
        public Guid Token_Value { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Registration_Folder 
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Service_Email : Sitecore.Feature.Accounts.Poco.IMailTemplate
    {
#region Interface IMailTemplate
  
        public string Body { get; set; }
  
        public string From { get; set; }
  
        public string Subject { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Login_Teaser : Sitecore.Feature.Accounts.Poco.ILoginTeaser
    {
#region Interface ILoginTeaser
  
        public string Logged_In_Summary { get; set; }
  
        public string Logged_In_Title { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Social
{
    public class Twitter_Feed : Sitecore.Feature.Social.Poco.ITwitterFeed
    {
#region Interface ITwitterFeed
  
        public LinkField TwitterUrl { get; set; }
  
        public string WidgetId { get; set; }
  
        public string FeedTitle { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Demo_Tokens
{
    public class Link_Token : Sitecore.Feature.Demo.Poco.ILinkToken
    {
#region Interface ILinkToken
  
        public LinkField Token_Value { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Media
{
    public class Media_Background_Folder 
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Navigation
{
    public class Navigation_Link : Sitecore.Feature.Navigation.Poco.ILink, Sitecore.Feature.Navigation.Poco.INavigable
    {
#region Interface ILink
  
        public LinkField Link { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Media
{
    public class Media_Folder 
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Employee : Sitecore.Feature.Person.Poco.IEmployee
    {
#region Interface IPerson
  
        public string Name { get; set; }
  
        public ImageField Picture { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface IEmployee
  
        public string Email { get; set; }
  
        public string Mobile { get; set; }
  
        public string Telephone { get; set; }
  
        public string Biography { get; set; }
  
        public LinkField BlogLink { get; set; }
  
        public LinkField FacebookLink { get; set; }
  
        public LinkField LinkedInLink { get; set; }
  
        public LinkField TwitterLink { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Teasers
{
    public class Quote_Folder 
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Link_Menu : Sitecore.Feature.Navigation.Poco.INavigationRoot
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Demo_Teaser : Sitecore.Feature.Demo.Poco.IDemoContent
    {
#region Interface IDemoContent
  
        public string HTML_Content { get; set; }
  
        public string Area_Code { get; set; }
  
        public string Business_Name { get; set; }
  
        public string City { get; set; }
  
        public string Country { get; set; }
  
        public string DNS { get; set; }
  
        public string ISP { get; set; }
  
        public string Latitude { get; set; }
  
        public string Longitude { get; set; }
  
        public string Metro_Code { get; set; }
  
        public string Postal_Code { get; set; }
  
        public string Region { get; set; }
  
        public string Url { get; set; }
  
        public string IP_Address { get; set; }
  
        public string Referrer { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class FAQ_Group : Sitecore.Feature.FAQ.Poco.IFAQ_Group
    {
#region Interface IFAQ_Group
  
        public IEnumerable<Guid> Group_Member { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class FAQ : Sitecore.Feature.FAQ.Poco.IFAQ
    {
#region Interface IFAQ
  
        public string Answer { get; set; }
  
        public string Question { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Media
{
    public class Carousel : Sitecore.Feature.Media.Poco.IHasMediaSelector
    {
#region Interface IHasMediaSelector
  
        public IEnumerable<Guid> MediaSelector { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Teasers
{
    public class Teaser : Sitecore.Feature.Teasers.Poco.ITeaserContent
    {
#region Interface IHeadline
  
        public Guid Teaser_Icon { get; set; }
  
        public string TeaserTitle { get; set; }
#endregion
#region Interface ITeaserContent
  
        public string Teaser_Label { get; set; }
  
        public ImageField TeaserImage { get; set; }
  
        public LinkField TeaserLink { get; set; }
  
        public string TeaserSummary { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class MetaKeyword_Folder 
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Teasers
{
    public class Video_Teaser : Sitecore.Feature.Teasers.Poco.ITeaserVideoContent
    {
#region Interface IHeadline
  
        public Guid Teaser_Icon { get; set; }
  
        public string TeaserTitle { get; set; }
#endregion
#region Interface ITeaserContent
  
        public string Teaser_Label { get; set; }
  
        public ImageField TeaserImage { get; set; }
  
        public LinkField TeaserLink { get; set; }
  
        public string TeaserSummary { get; set; }
#endregion
#region Interface ITeaserVideoContent
  
        public LinkField VideoLink { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Media
{
    public class Image : Sitecore.Feature.Media.Poco.IHasMediaImage
    {
#region Interface IHasMedia
  
        public string MediaDescription { get; set; }
  
        public ImageField MediaThumbnail { get; set; }
  
        public string MediaTitle { get; set; }
#endregion
#region Interface IHasMediaImage
  
        public ImageField MediaImage { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Media
{
    public class Video : Sitecore.Feature.Media.Poco.IHasMediaVideo
    {
#region Interface IHasMedia
  
        public string MediaDescription { get; set; }
  
        public ImageField MediaThumbnail { get; set; }
  
        public string MediaTitle { get; set; }
#endregion
#region Interface IHasMediaVideo
  
        public LinkField MediaVideoLink { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types.Teasers
{
    public class Dynamic_Teaser : Sitecore.Feature.Teasers.Poco.IDynamicTeaser
    {
#region Interface IDynamicTeaser
  
        public int Active { get; set; }
  
        public int Count { get; set; }
#endregion

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Employee_Folder 
    {

    }
}
namespace Sitecore.Common.Website.Poco.Content_Types
{
    public class Global_Folder 
    {

    }
}
