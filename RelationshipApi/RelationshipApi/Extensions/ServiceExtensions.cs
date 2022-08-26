using Microsoft.EntityFrameworkCore;
using RelationshipApi.Database;

namespace RelationshipApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) => 
            services.AddDbContext<AppDbContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
    }
}
