using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int id);
        Task<User?> GetByGoogleIdAsync(string googleId);

        Task<bool> ExistsByIdAsync(int id);
        Task<bool> ExistsByGoogleIdAsync(string googleId);

        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task HardDeleteAsync(User user);
    }
}
