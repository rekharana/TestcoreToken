
//using DemoApp.DataAccess.Models;
using DemoApp.Service;
using DemoApp.Service.IService;
using DemoApp.Service.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DemoWebApi.Mappings
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddCloudscribeCore(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddTransient<IUserMasterService, UserMasterService>();
            services.AddTransient<IPhotoService, PhotoService>();            
            return services;
        }
    }
}
