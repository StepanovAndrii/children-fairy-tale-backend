using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int id);
        Task<User?> GetByGoogleIdAsync(string googleId);
        Task AddAsync(User user);
        Task DeleteAsync(User user);
        Task<bool> ExistsByIdAsync(int id);
        Task<bool> ExistsByGoogleIdAsync(string googleId);
    }
}
