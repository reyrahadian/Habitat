namespace Sitecore.Feature.Accounts.Interfaces.Services
{
  public interface INotificationService
  {
    void SendPassword(string email, string newPassword);
  }
}