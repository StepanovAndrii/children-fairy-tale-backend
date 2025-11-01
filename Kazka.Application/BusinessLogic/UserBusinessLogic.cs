using Domain.Entities;
using Domain.Interfaces.Repositories;
using Kazka.Application.Features.User.Command.Update;
using Kazka.Application.Features.User.Queries.GetAll;
using Kazka.Application.Interfaces.External;
using Kazka.Application.Interfaces.Services;

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

        public async Task<List<User>> GetUsersAsync(GetUsersQuery _)
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User?> UpdateUserAsync(UpdateUserCommand request)
        {
            var userGoogleId = _currentUserService.GoogleId;

            // TODO: take out check into other method? + Result obj
            if (userGoogleId is null)
                return null;

            var user = await _userRepository.GetByGoogleIdAsync(userGoogleId);

            // TODO: take out check into other method? + Result obj
            if (user is null)
                return null;

            if (request.Age is uint age)
                user.UpdateAge(age);

            if (request.Name is string name)
                user.UpdateName(name);

            if (request.ProfilePictureUrl is string profileUrl)
                user.UpdateProfilePictureUrl(profileUrl);

            await _userRepository.UpdateAsync(
                user
            );

            return user;
        }
    }
}
