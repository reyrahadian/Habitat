using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.Feature.Demo.Contracts.Services;
using Sitecore.Feature.Demo.Services;
using Sitecore.Foundation.Accounts.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.Demo.IoC
{
    public class Configurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IProfileProvider, ProfileProvider>()
                .AddTransient<IContactProfileProvider, ContactProfileProvider>();

#if ZERODEPLOY == false
            serviceCollection
                .AddTransient<Controllers.DemoController>();
#endif
        }
    }
}