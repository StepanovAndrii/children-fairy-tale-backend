using Infrastructure.Configuration.Cors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions.Security
{
    public static class CorsExtensions
    {
        public static IServiceCollection AddCustomCors
            (
                this IServiceCollection services,
                IConfiguration configuration
            )
        {
            var cors = configuration
                .GetSection("Cors")
                .Get<CorsSettings>();

            if (cors is null 
                || cors.Policies.Count == 0)
                return services;

            foreach (var policy in cors.Policies)
            {
                services.AddCors(
                    options =>
                    {
                        options.AddPolicy(policy.Name, builder =>
                        {
                            if (policy.Origins.Contains("*"))
                            {
                                if (policy.AllowCredentials)
                                    throw new InvalidOperationException("Cannot use '*' when AllowCredentials is true.");

                                builder.AllowAnyOrigin();
                            }
                            else
                                builder.WithOrigins(policy.Origins);

                            if (policy.Headers.Contains("*"))
                                builder.AllowAnyHeader();
                            else
                                builder.WithHeaders(policy.Headers);

                            if (policy.Methods.Contains("*"))
                                builder.AllowAnyMethod();
                            else
                                builder.WithMethods(policy.Methods);

                            if (policy.AllowCredentials)
                                builder.AllowCredentials();
                        });
                    }
                );
            }

            return services;
        }
    }
}
