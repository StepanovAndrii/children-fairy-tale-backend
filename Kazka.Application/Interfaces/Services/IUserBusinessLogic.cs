using Domain.Entities;
using Kazka.Application.Requests.Commands;
using Kazka.Application.Results;
using System.Security.Claims;

namespace Kazka.Application.Interfaces.Services
{
    public interface IUserBusinessLogic
    {
        Task<Result<List<User>>> GetUsersAsync();
        Task<Result<User>> UpdateUserRoleAsync(UpdateUserRoleCommand command);
    }
}
