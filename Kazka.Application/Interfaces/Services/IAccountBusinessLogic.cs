using Kazka.Application.Requests.Commands;
using System.Security.Claims;

namespace Kazka.Application.Interfaces.Services
{
    public interface IAccountBusinessLogic
    {
        Task<string> RefreshTokenAsync(string? refreshToken);
        Task<string> LoginWithGoogleAsync(ClaimsPrincipal? claimsPrincipal);
    }
}
