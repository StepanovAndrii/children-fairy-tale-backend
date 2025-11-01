using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;

namespace Persistence.Extensions
{
    public static class DbContextExtensions
    {
        public static IServiceCollection AddDbContexts
            (
                this IServiceCollection services,
                IConfiguration config
            )
        {
            services.AddDbContext<KazkaContext>(
                options => options.UseNpgsql(
                    config.GetConnectionString("PostgreSQL")
                )
            );

            return services;
        }
    }
}
