using Domain.Entities;
using Kazka.Application.Features.User.Command.Update;
using Kazka.Application.Features.User.Queries.GetAll;

namespace Kazka.Application.Interfaces.Services
{
    public interface IUserBusinessLogic
    {
        Task<List<User>> GetUsersAsync(GetUsersQuery query);
        Task<User?> UpdateUserAsync(UpdateUserCommand request);
    }
}
