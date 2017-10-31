
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Habitat.Website.Poco.Content_Types
{
    public class Site_Root : Sitecore.Feature.Identity.Poco.IIdentity, Sitecore.Feature.Metadata.Poco.ISiteMetadata, Sitecore.Feature.Accounts.Poco.IAccountsSettings, Sitecore.Feature.Demo.Poco.IProfilingSettings, Sitecore.Feature.Accounts.Poco.IProfileSettings, Sitecore.Feature.Multisite.Poco.ISiteConfiguration, Sitecore.Feature.Language.Poco.ILanguageSettings, Sitecore.Foundation.Assets.Poco.IHasTheme, Sitecore.Feature.Search.Poco.ISearchContext
    {
#region Interface IIdentity
  
        public string Copyright { get; set; }
  
        public string Logo_Tagline { get; set; }
  
        public ImageField Logo { get; set; }
  
        public string OrganisationAddress { get; set; }
  
        public LinkField OrganisationEmail { get; set; }
  
        public string OrganisationName { get; set; }
  
        public string OrganisationPhone { get; set; }
#endregion
#region Interface ISiteMetadata
  
        public string SiteBrowserTitle { get; set; }
#endregion
#region Interface IAccountsSettings
  
        public LinkField Accounts_Details_Page { get; set; }
  
        public LinkField After_Login_Page { get; set; }
  
        public LinkField Forgot_Password_Mail_Template { get; set; }
  
        public LinkField Forgot_Password_Page { get; set; }
  
        public LinkField Login_Page { get; set; }
  
        public Guid Register_Outcome { get; set; }
  
        public LinkField Register_Page { get; set; }
#endregion
#region Interface IProfilingSettings
  
        public IEnumerable<Guid> SiteProfiles { get; set; }
#endregion
#region Interface IProfileSettings
  
        public Guid Interests_Folder { get; set; }
  
        public Guid User_Profile { get; set; }
#endregion
#region Interface ISiteConfiguration
  
        public bool ShowInMenu { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface ILanguageSettings
  
        public IEnumerable<Guid> SupportedLanguages { get; set; }
#endregion
#region Interface IHasTheme
  
        public Guid Theme { get; set; }
#endregion
#region Interface ISearchContext
  
        public LinkField Search_Results_Page { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class Employee : Sitecore.Feature.Person.Poco.IEmployee, Sitecore.Foundation.Assets.Poco.IPageAssets, Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Feature.Navigation.Poco.INavigable, Sitecore.Foundation.Indexing.Poco.IIndexedItem
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
#region Interface IPageAssets
  
        public string CssCode { get; set; }
  
        public bool InheritAssets { get; set; }
  
        public string JavascriptCodeBottom { get; set; }
  
        public string JavascriptCodeTop { get; set; }
#endregion
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion
#region Interface IIndexedItem
  
        public bool IncludeInSearchResults { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class Home : Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Feature.Navigation.Poco.INavigationRoot, Sitecore.Feature.Navigation.Poco.INavigable, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Foundation.Indexing.Poco.IIndexedItem
    {
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion
#region Interface IIndexedItem
  
        public bool IncludeInSearchResults { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class Employees_folder : Sitecore.Habitat.Website.Poco.Page_Types.Article
    {

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class Register_Page : Sitecore.Feature.PageContent.Poco.IHasPageContent, Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Feature.Navigation.Poco.INavigable, Sitecore.Foundation.Indexing.Poco.IIndexedItem
    {
#region Interface IHasPageContent
  
        public string Body { get; set; }
  
        public ImageField Image { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion
#region Interface IIndexedItem
  
        public bool IncludeInSearchResults { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class Edit_Profile_Page : Sitecore.Feature.PageContent.Poco.IHasPageContent, Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Feature.Navigation.Poco.INavigable, Sitecore.Foundation.Indexing.Poco.IIndexedItem
    {
#region Interface IHasPageContent
  
        public string Body { get; set; }
  
        public ImageField Image { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion
#region Interface IIndexedItem
  
        public bool IncludeInSearchResults { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class Forgot_Password_Page : Sitecore.Feature.PageContent.Poco.IHasPageContent, Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Feature.Navigation.Poco.INavigable, Sitecore.Foundation.Indexing.Poco.IIndexedItem
    {
#region Interface IHasPageContent
  
        public string Body { get; set; }
  
        public ImageField Image { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion
#region Interface IIndexedItem
  
        public bool IncludeInSearchResults { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class Section : Sitecore.Feature.PageContent.Poco.IHasPageContent, Sitecore.Foundation.Assets.Poco.IPageAssets, Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Feature.Navigation.Poco.INavigable, Sitecore.Foundation.Indexing.Poco.IIndexedItem
    {
#region Interface IHasPageContent
  
        public string Body { get; set; }
  
        public ImageField Image { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface IPageAssets
  
        public string CssCode { get; set; }
  
        public bool InheritAssets { get; set; }
  
        public string JavascriptCodeBottom { get; set; }
  
        public string JavascriptCodeTop { get; set; }
#endregion
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion
#region Interface IIndexedItem
  
        public bool IncludeInSearchResults { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class Search_Results : Sitecore.Feature.PageContent.Poco.IHasPageContent, Sitecore.Feature.Search.Poco.ISearchResults, Sitecore.Foundation.Assets.Poco.IPageAssets, Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Feature.Navigation.Poco.INavigable
    {
#region Interface IHasPageContent
  
        public string Body { get; set; }
  
        public ImageField Image { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface ISearchResults
  
        public IEnumerable<Guid> Facets { get; set; }
  
        public Guid Root { get; set; }
  
        public string SearchBoxTitle { get; set; }
#endregion
#region Interface IPageAssets
  
        public string CssCode { get; set; }
  
        public bool InheritAssets { get; set; }
  
        public string JavascriptCodeBottom { get; set; }
  
        public string JavascriptCodeTop { get; set; }
#endregion
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class Article : Sitecore.Feature.PageContent.Poco.IHasPageContent, Sitecore.Foundation.Assets.Poco.IPageAssets, Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Feature.Navigation.Poco.INavigable, Sitecore.Foundation.Indexing.Poco.IIndexedItem
    {
#region Interface IHasPageContent
  
        public string Body { get; set; }
  
        public ImageField Image { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface IPageAssets
  
        public string CssCode { get; set; }
  
        public bool InheritAssets { get; set; }
  
        public string JavascriptCodeBottom { get; set; }
  
        public string JavascriptCodeTop { get; set; }
#endregion
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion
#region Interface IIndexedItem
  
        public bool IncludeInSearchResults { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class News_List : Sitecore.Feature.PageContent.Poco.IHasPageContent, Sitecore.Feature.Navigation.Poco.INavigable, Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Foundation.Assets.Poco.IPageAssets, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Feature.News.Poco.INewsFolder
    {
#region Interface IHasPageContent
  
        public string Body { get; set; }
  
        public ImageField Image { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface IPageAssets
  
        public string CssCode { get; set; }
  
        public bool InheritAssets { get; set; }
  
        public string JavascriptCodeBottom { get; set; }
  
        public string JavascriptCodeTop { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class News_Article : Sitecore.Feature.News.Poco.INewsArticle, Sitecore.Foundation.Assets.Poco.IPageAssets, Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Foundation.Indexing.Poco.IIndexedItem
    {
#region Interface INewsArticle
  
        public string NewsBody { get; set; }
  
        public DateTime NewsDate { get; set; }
  
        public ImageField NewsImage { get; set; }
  
        public string NewsSummary { get; set; }
  
        public string NewsTitle { get; set; }
#endregion
#region Interface IPageAssets
  
        public string CssCode { get; set; }
  
        public bool InheritAssets { get; set; }
  
        public string JavascriptCodeBottom { get; set; }
  
        public string JavascriptCodeTop { get; set; }
#endregion
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion
#region Interface IIndexedItem
  
        public bool IncludeInSearchResults { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class Login_Page : Sitecore.Feature.PageContent.Poco.IHasPageContent, Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Feature.Navigation.Poco.INavigable, Sitecore.Foundation.Indexing.Poco.IIndexedItem
    {
#region Interface IHasPageContent
  
        public string Body { get; set; }
  
        public ImageField Image { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion
#region Interface IIndexedItem
  
        public bool IncludeInSearchResults { get; set; }
#endregion

    }
}
namespace Sitecore.Habitat.Website.Poco.Page_Types
{
    public class Map_Page : Sitecore.Feature.Maps.Poco.IMapPoint, Sitecore.Feature.PageContent.Poco.IHasPageContent, Sitecore.Foundation.Assets.Poco.IPageAssets, Sitecore.Feature.Metadata.Poco.IPageMetadata, Sitecore.Feature.Social.Poco.IOpenGraph, Sitecore.Feature.Navigation.Poco.INavigable, Sitecore.Foundation.Indexing.Poco.IIndexedItem
    {
#region Interface IMapPoint
  
        public string MapPointAddress { get; set; }
  
        public object /* UNKNOWN (Map Field) */ MapPointLocation { get; set; }
  
        public string MapPointName { get; set; }
#endregion
#region Interface IHasPageContent
  
        public string Body { get; set; }
  
        public ImageField Image { get; set; }
  
        public string Summary { get; set; }
  
        public string Title { get; set; }
#endregion
#region Interface IPageAssets
  
        public string CssCode { get; set; }
  
        public bool InheritAssets { get; set; }
  
        public string JavascriptCodeBottom { get; set; }
  
        public string JavascriptCodeTop { get; set; }
#endregion
#region Interface IPageMetadata
  
        public string BrowserTitle { get; set; }
  
        public bool CanIndex { get; set; }
  
        public System.Collections.Specialized.NameValueCollection CustomMetaData { get; set; }
  
        public string MetaDescription { get; set; }
  
        public IEnumerable<Guid> MetaKeywords { get; set; }
  
        public bool SeoFollowLinks { get; set; }
#endregion
#region Interface IOpenGraph
  
        public string OpenGraphDescription { get; set; }
  
        public ImageField OpenGraphImage { get; set; }
  
        public string OpenGraphTitle { get; set; }
#endregion
#region Interface INavigable
  
        public string NavigationTitle { get; set; }
  
        public bool ShowChildren { get; set; }
  
        public bool ShowInNavigation { get; set; }
#endregion
#region Interface IIndexedItem
  
        public bool IncludeInSearchResults { get; set; }
#endregion

    }
}
