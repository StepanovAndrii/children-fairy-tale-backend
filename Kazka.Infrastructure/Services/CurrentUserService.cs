using Kazka.Application.Interfaces.External;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Kazka.Infrastructure.Services
{
    public class CurrentUserService: ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService
            (
                IHttpContextAccessor httpContextAccessor
            )
        {
            _httpContextAccessor = httpContextAccessor;
        }
        
        public string? GoogleId =>
            _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    }
}
