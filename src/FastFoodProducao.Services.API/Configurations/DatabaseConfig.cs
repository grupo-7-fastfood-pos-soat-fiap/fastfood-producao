using FastFoodProducao.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FastFoodProducao.Services.Api.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            // services.AddDbContext<AppDbContext>(options =>
            //     options.UseMongoDB(database.Client, database.DatabaseNamespace.DatabaseName));           
        }
    }
}

