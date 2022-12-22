using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrainingApp.Business.Contracts;
using TrainingApp.Business.Services;
using TrainingApp.Data;

namespace TrainingApp.Business
{
    public static class TrainingAppBusinessModule
    {
        public static void ConfigureBusinessModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureDataModule(configuration);
            services
                .AddScoped<IUserService, UserService>()
                .AddScoped<IActivityService, ActivityService>()
                ;
        }
    }
}