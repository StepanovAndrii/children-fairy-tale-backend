using Domain.Entities;
using Kazka.Core.Interfaces.Repositories.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IUserRepository: IRepository<User>
    {
        Task<User?> GetByGoogleIdAsync(
                string googleId
            );
    }
}
