namespace Sitecore.Feature.Accounts.Contracts.Services
{
  public interface IAccountTrackerService
  {
    void TrackRegistration();
    void TrackRegistrationOutcome();
    void TrackLogin(string identifier);
  }
}