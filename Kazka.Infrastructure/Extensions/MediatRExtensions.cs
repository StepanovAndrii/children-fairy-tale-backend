using Kazka.Application.Features.Users.Handlers.Get;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infrastructure.Extensions
{
    public static class MediatRExtensions
    {
        public static IServiceCollection AddApplicationMediator(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
                configuration.RegisterServicesFromAssembly(typeof(GetUserHandler).Assembly));

            return services;
        }
    }
}
