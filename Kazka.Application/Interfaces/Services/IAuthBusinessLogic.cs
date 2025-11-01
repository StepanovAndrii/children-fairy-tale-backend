using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IAuthBusinessLogic
    {
        Task<bool> UserExistsAsync
            (
                string googleId
            );
        Task<User?> RegisterWithGoogleUserAsync
            (
                string googleId,
                string email,
                string? profilePictureUrl = null
            );
    }
}
