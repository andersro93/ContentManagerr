using ContentManagerr.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContentManagerr.Infrastructure.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(AppDbContext.ConnectionStringKey));
            });
            serviceCollection.AddScoped<IAppDbContext, AppDbContext>();

            return serviceCollection;
        }

        public static IHealthChecksBuilder AddPersistenceHealthChecks(this IHealthChecksBuilder healthChecksBuilder, IConfiguration configuration)
        {
            healthChecksBuilder
                .AddSqlServer(configuration.GetConnectionString(AppDbContext.ConnectionStringKey));

            return healthChecksBuilder;
        }
    }
}