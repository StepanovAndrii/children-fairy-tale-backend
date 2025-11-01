using Domain.Entities;
using Kazka.Core.Interfaces.Repositories.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IUserRepository: IRepository<User>
    {
        Task<bool> ExistsByGoogleIdAsync(
                string googleId
            );
        Task<User?> GetByGoogleIdAsync(
                string googleId
            );
    }
}
