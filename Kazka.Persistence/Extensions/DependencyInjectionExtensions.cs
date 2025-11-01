using Domain.Interfaces.Repositories;
using Kazka.Core.Interfaces.Repositories.Base;
using Kazka.Persistence.Repositories.Base;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Kazka.Persistence.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddPersistenceDI(this IServiceCollection services) 
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<IStoryRepository, StoryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
