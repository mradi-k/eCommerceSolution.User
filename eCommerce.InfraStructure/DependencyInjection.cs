using eCommerce.Core.RepositryContracts;
using eCommerce.InfraStructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Core
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Extension Method to Add Infrastructure servivces to the dependency injection Container 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfraStructure(this IServiceCollection services)
        {
            // To Do : Add Service to the Ioc Container 
            //InfraStructure service often include data access, caching and low-level components.
            services.AddSingleton<IUsersRepositry, UserRepository>();
            return services;
        }
    }
}
