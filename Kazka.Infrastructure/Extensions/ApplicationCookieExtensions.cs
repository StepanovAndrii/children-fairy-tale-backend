using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Kazka.Infrastructure.Extensions
{
    public static class ApplicationCookieExtensions
    {
        public static AuthenticationBuilder AddKazkaCookie
            (
                this AuthenticationBuilder builder,
                IWebHostEnvironment env
            )
        {
            

            return builder;
        }
    }
}
