using Hospital.Contract;
using Hospital.Infrastructure.Persistence.Database;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace Hospital.Infrastructure.Persistence.Extensions
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, string connectionString, bool enableSensitiveLogging, bool ignoreModelWarnings)
        {
            services.AddScoped<AuditInterceptor>();
            if (ignoreModelWarnings)
            {
                services.AddDbContext<HospitalDbContex>((sp, options) =>
                {
                    var interceptor = sp.GetRequiredService<AuditInterceptor>();
                    options
                        .UseNpgsql(connectionString)
                        .EnableSensitiveDataLogging(enableSensitiveLogging)
                        .AddInterceptors(interceptor)
                        .ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
                });
            }
            else
            {
                services.AddDbContext<HospitalDbContex>((sp, options) =>
                {
                    var interceptor = sp.GetRequiredService<AuditInterceptor>();
                    options.UseNpgsql(connectionString)
                        .EnableSensitiveDataLogging(enableSensitiveLogging)
                        .AddInterceptors(interceptor);
                });
            }

            services.AddScoped<UnitOfWork>();
            services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<UnitOfWork>());
            return services;
        }
    }
}


