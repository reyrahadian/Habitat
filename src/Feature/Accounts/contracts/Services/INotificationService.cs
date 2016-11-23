namespace Sitecore.Feature.Accounts.Contracts.Services
{
  public interface INotificationService
  {
    void SendPassword(string email, string newPassword);
  }
}