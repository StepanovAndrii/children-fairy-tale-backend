using Infrastructure.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Kazka.Infrastructure.Extensions;

namespace Infrastructure.Extensions.Security.Authentication
{
    public static class AuthenticationExtensions
    {
        public static IServiceCollection AddCustomAuthentication
            (
                this IServiceCollection services,
                IConfiguration config,
                IWebHostEnvironment env
            )
        {
            var enviroment = services.BuildServiceProvider().GetRequiredService<IWebHostEnvironment>();

            services.AddAuthentication
                (
                    options =>
                    {
                        options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                        options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
                    }
                )
                .AddKazkaCookie(env)
                .AddGoogle(GoogleDefaults.AuthenticationScheme,
                    options =>
                    {
                        config.Bind("Authentication:Google", options);

                        options.Scope.Add("email");
                        options.Scope.Add("profile");
                        options.ClaimActions.MapJsonKey("pictureUrl", "picture");

                        options.EventsType = typeof(GoogleOAuthEventsHandler);
                    });

            return services;
        }
    }
}
