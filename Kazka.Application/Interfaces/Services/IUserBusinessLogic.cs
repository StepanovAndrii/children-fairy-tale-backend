using Domain.Entities;
using Kazka.Application.Features.User.Command.Update;
using Kazka.Application.Features.User.Queries.GetAll;
using Kazka.Application.Features.Users.Queries.Get;

namespace Kazka.Application.Interfaces.Services
{
    public interface IUserBusinessLogic
    {
        Task<User?> GetUserAsync(GetUserQuery query);
        Task<List<User>> GetUsersAsync();
        Task<User?> UpdateUserAsync(UpdateUserCommand request);
    }
}
