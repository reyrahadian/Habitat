namespace Sitecore.Feature.Demo.Interfaces.Repositories
{
  using System.Collections.Generic;
  using Sitecore.Feature.Demo.Models;

  public interface ICampaignRepository
  {
    Campaign GetCurrent();
    IEnumerable<Campaign> GetHistoric();
  }
}