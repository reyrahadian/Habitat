namespace Sitecore.Feature.Accounts.Interfaces.Services
{
  public interface IAccountTrackerService
  {
    void TrackRegistration();
    void TrackRegistrationOutcome();
    void TrackLogin(string identifier);
  }
}