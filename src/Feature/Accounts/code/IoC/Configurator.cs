using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.Feature.Accounts.Contracts.Repositories;
using Sitecore.Feature.Accounts.Contracts.Services;
using Sitecore.Feature.Accounts.Repositories;
using Sitecore.Feature.Accounts.Services;
using Sitecore.Foundation.Accounts.Providers;
using Sitecore.Foundation.SitecoreExtensions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.Accounts.IoC
{
    public class Configurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<ITrackerService, TrackerService>()
                .AddTransient<IAccountsSettingsService, AccountsSettingsService>()
                .AddTransient<IAccountTrackerService, AccountTrackerService>()
                .AddTransient<IAccountRepository, AccountRepository>()
                .AddTransient<INotificationService, NotificationService>()
                .AddTransient<IUserProfileProvider, UserProfileProvider>()
                .AddTransient<IProfileSettingsService, ProfileSettingsService>()
                .AddTransient<IUserProfileService, UserProfileService>()
                .AddTransient<IContactProfileProvider, ContactProfileProvider>()
                .AddTransient<IContactProfileService, ContactProfileService>();

#if ZERODEPLOY == false
            serviceCollection
                .AddTransient<Controllers.AccountsController>();
#endif


        }
    }
}