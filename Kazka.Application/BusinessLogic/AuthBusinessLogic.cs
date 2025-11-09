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

        //public async Task<User?> RegisterWithGoogleUserAsync
        //    (
        //        string googleId,
        //        string email,
        //        string? profilePictureUrl = null
        //    )
        //{
            
        //}
    }
}
