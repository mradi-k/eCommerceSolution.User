using eCommerce.Core.ServiceContracts;
using eCommerce.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.InfraStructure
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Extension Method to Add core servivces to the dependency injection Container 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCore(this IServiceCollection services) 
        {
           // To Do : Add Service to the Ioc Container 
           //Core service often include data access, caching and low-level components.
           services.AddTransient<IUsersService, UsersService>();
            return services;
        }
    }
}
