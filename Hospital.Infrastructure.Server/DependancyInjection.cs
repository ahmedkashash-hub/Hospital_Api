using Hospital.Contract;
using Hospital.Shared.Constants;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace Hospital.Infrastructure.Server
{

    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(resourcesManager =>
                new ResourceManager("Phnx.Shared.Resources.Language", typeof(AppConstants).Assembly));

            services.AddSingleton<LanguageManager>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IFileService, FileService>();
            //services.Configure<FlightApisConfiguration>(configuration.GetSection("FlightApis"));
            //services.AddScoped<IFlightApiClientFactory, FlightApiClientFactory>();
            //services.AddScoped<IFlightApiServiceFactory, FlightApiServiceFactory>();
            //services.RegisterFidsService(configuration);
            return services;
        }
    }
}
