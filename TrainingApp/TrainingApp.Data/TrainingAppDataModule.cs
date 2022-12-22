using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrainingApp.Data.Contracts;
using TrainingApp.Data.Repositories;
using TrainingApp.EF;

namespace TrainingApp.Data
{
    public static class TrainingAppDataModule
    {
        public static void ConfigureDataModule(this IServiceCollection service, IConfiguration configuration)
        {
            service.ConfigureDatabase(configuration);
            service
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IActivityRepository, ActivityRepository>();
        }
    }
}