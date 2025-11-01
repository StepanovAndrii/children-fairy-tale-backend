using Application.Interfaces.Services;
using Application.Services;
using Kazka.Application.BusinessLogic;
using Microsoft.Extensions.DependencyInjection;

namespace Kazka.Application.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddScoped<IAuthBusinessLogic, AuthBusinessLogic>();
            services.AddScoped<IStoryBusinessLogic, StoryBusinessLogic>();

            return services;
        }
    }
}
