namespace Sitecore.Feature.Demo.Contracts.Repositories
{
  using System.Collections.Generic;
  using Sitecore.Feature.Demo.Models;

  public interface ICampaignRepository
  {
    Campaign GetCurrent();
    IEnumerable<Campaign> GetHistoric();
  }
}