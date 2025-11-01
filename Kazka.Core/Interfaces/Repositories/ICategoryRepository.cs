using Domain.Entities;
using Kazka.Core.Interfaces.Repositories.Base;

namespace Domain.Interfaces.Repositories
{
    public interface ICategoryRepository: IRepository<Category>
    {
        Task<Category?> GetCategoryByNameAsync(
                string name
            );
    }
}
