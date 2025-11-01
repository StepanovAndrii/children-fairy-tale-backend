
namespace Kazka.Core.Interfaces.Repositories.Base
{
    public interface IRepository<T> where T: class
    {
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T?> GetByIdAsync(uint id);
        Task UpdateAsync(T entity);
    }
}
