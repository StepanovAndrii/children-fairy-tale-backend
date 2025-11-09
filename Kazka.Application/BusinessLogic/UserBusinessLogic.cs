using Domain.Entities;
using Domain.Interfaces.Repositories;
using Kazka.Application.Interfaces.External;
using Kazka.Application.Interfaces.Services;
using Kazka.Application.Requests.Commands;
using Kazka.Application.Results;

namespace Kazka.Application.BusinessLogic
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IUserRepository _userRepository;
        public UserBusinessLogic
            (
                ICurrentUserService currentUserService,
                IUserRepository userRepository
            )
        {
            _currentUserService = currentUserService;
            _userRepository = userRepository;
        }

        public async Task<Result<List<User>>> GetUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            if (users.Any())
                return Result<List<User>>
                    .Failure("No users found", ErrorType.NotFound);

            return Result<List<User>>.Success(users, SuccessType.Ok);
        }

        public async Task<Result<User>> UpdateUserRoleAsync(UpdateUserRoleCommand command)
        {
            var user = await _userRepository.GetByIdAsync(command.Id);
            if (user is null)
                return Result<User>
                    .Failure($"User with ID {command.Id} was not found", ErrorType.NotFound);

            user.Role = command.Role;

            await _userRepository.UpdateAsync(user);
            return Result<User>.Success(user, SuccessType.Ok);
        }
    }
}
