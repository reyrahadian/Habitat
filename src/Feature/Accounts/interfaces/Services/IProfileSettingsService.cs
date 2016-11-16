namespace Sitecore.Feature.Accounts.Interfaces.Services
{
  using System.Collections.Generic;
  using Sitecore.Data.Items;

  public interface IProfileSettingsService
  {
    IEnumerable<string> GetInterests();
    Item GetUserDefaultProfile();
  }
}