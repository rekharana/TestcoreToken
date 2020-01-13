using DemoApp.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DemoApp.Mappings
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddCloudscribeCore(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddTransient<IUserMasterService, UserMasterService>();
            return services;
        }
    }
}
