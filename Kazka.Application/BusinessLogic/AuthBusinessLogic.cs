using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Kazka.Application.BusinessLogic
{
    public class AuthBusinessLogic: IAuthBusinessLogic
    {
        public readonly IUserRepository _userRepository;
        public AuthBusinessLogic
            (
                IUserRepository userRepository
            )
        {
            _userRepository = userRepository;
        }

        public async Task<bool> UserExistsAsync
            (
                string googleId
            )
        {
            var val = await _userRepository.ExistsByGoogleIdAsync(googleId);

            return val;
        }

        public async Task<User?> RegisterWithGoogleUserAsync
            (
                string googleId,
                string email,
                string? profilePictureUrl = null
            )
        {
            var emailObject = new Email(email);
            var pictureUrl = profilePictureUrl == null
                ? null
                : new Url(profilePictureUrl);

            var newUser = User.Create
                (
                    googleId,
                    emailObject,
                    pictureUrl
                );

            return await _userRepository.AddAsync(newUser);
        }
    }
}
