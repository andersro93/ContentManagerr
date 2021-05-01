using ContentManagerr.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContentManagerr.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddContentManagerrInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            // Add Infrastructure components
            serviceCollection.AddPersistence(configuration);

            return serviceCollection;
        }

        public static IHealthChecksBuilder AddContentManagerrHealthChecks(this IHealthChecksBuilder healthChecksBuilder, IConfiguration configuration)
        {
            healthChecksBuilder.AddPersistenceHealthChecks(configuration);
            
            return healthChecksBuilder;
        }
    }
}