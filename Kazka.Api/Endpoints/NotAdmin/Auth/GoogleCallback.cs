
using Domain.Interfaces.Repositories;
using Kazka.Api.Attributes;
using Kazka.Api.Extensions;
using Kazka.Application.Interfaces.Services;
using Kazka.Core.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;

namespace Kazka.Api.Endpoints.NotAdmin.Auth
{
    [EndpointVersion(1)]
    public class GoogleCallback : IEndpoint
    {
        public void Map(IEndpointRouteBuilder app)
        {
            app.MapGet("auth/google/callback", async
                (
                    HttpContext httpContext,
                    IUserBusinessLogic userBusinessLogic
                ) =>
            {
                var contextResult = await httpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);

                if (!contextResult.Succeeded)
                    return Results.Unauthorized();

                // TODO: think, maybe it's better to send back refresh token too
                try
                {
                    var result = await userBusinessLogic.AuthenticateUserWithGoogleAsync(contextResult.Principal);
                    
                    if (result.IsSuccess
                        && result.SuccessResult!.Value.AccessToken is not null)
                        httpContext.Response.Cookies.Append
                            (
                                "RefreshToken",
                                result.SuccessResult.Value.RefreshToken,
                                new CookieOptions
                                {
                                    // TODO: remake it in appsettings
                                    HttpOnly = true,
                                    Secure = true,
                                    SameSite = SameSiteMode.Lax,
                                    Expires = DateTime.UtcNow.AddDays(30)
                                }
                            );

                    return result.ToActionResult(tokens =>
                        tokens.AccessToken);
                }
                catch
                {
                    return Results.Unauthorized();
                }
            });
        }
    }
}
