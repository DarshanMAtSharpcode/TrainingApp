
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TrainingApp.EF
{
    public static class TrainingAppEFModule
    {
        public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbContext:ConnectionString"];
            services.AddDbContext<TrainingAppEFContext>(options =>
            {
                options.UseMySql(connectionString, MySqlServerVersion.LatestSupportedServerVersion);
            });
        }
    }
}