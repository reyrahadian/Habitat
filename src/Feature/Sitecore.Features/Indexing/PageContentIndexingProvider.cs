namespace Sitecore.Feature.PageContent.Indexing
{
  using System;
  using System.Collections.Generic;
  using System.Configuration.Provider;
  using System.Linq.Expressions;
  using Sitecore.ContentSearch.SearchTypes;
  using Sitecore.Data;
  using Sitecore.Foundation.Dictionary.Repositories;
  using Sitecore.Foundation.Indexing.Infrastructure;
  using Sitecore.Foundation.Indexing.Models;
  using Sitecore.Web.UI.WebControls;
    using Sitecore.Feature.FAQ;

  public class PageContentIndexingProvider : ProviderBase, ISearchResultFormatter, IQueryPredicateProvider
  {
    public  string ContentType => DictionaryPhraseRepository.Current.Get("/Page Content/Search/Content Type", "Page");

    public IEnumerable<ID> SupportedTemplates => new[]
    {
      Sitecore.Feature.PageContent.Templates.HasPageContent.ID
    };

    public Expression<Func<SearchResultItem, bool>> GetQueryPredicate(IQuery query)
    {
      var fieldNames = new[] { PageContent.Templates.HasPageContent.Fields.Title_FieldName, PageContent.Templates.HasPageContent.Fields.Summary_FieldName, PageContent.Templates.HasPageContent.Fields.Body_FieldName };

            //var unknown = Sitecore.Feature.FAQ.Repositories.FaqRepository.Get(null);
      return GetFreeTextPredicateService.GetFreeTextPredicate(fieldNames, query);
    }

    public void FormatResult(SearchResultItem item, ISearchResult formattedResult)
    {
      var contentItem = item.GetItem();
      formattedResult.Title = FieldRenderer.Render(contentItem, PageContent.Templates.HasPageContent.Fields.Title.ToString());
      formattedResult.Description = FieldRenderer.Render(contentItem, PageContent.Templates.HasPageContent.Fields.Summary.ToString());
    }
  }
}