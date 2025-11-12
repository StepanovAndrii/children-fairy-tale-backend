using Kazka.Api.Attributes;
using Kazka.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.NotAdmin.Auth
{
    [EndpointVersion(1)]
    public class GoogleCallback : IEndpoint
    {
        public void Map(IEndpointRouteBuilder app)
        {
            app.MapGet("auth/google/callback", async
                (
                    HttpContext context,
                    IAccountBusinessLogic accountBusinessLogic
                ) =>
            {
                var result = await context.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);

                if (!result.Succeeded)
                    return Results.Unauthorized();

                var accessToken = await accountBusinessLogic.LoginWithGoogleAsync(result.Principal);

                return Results.Json
                (
                    new
                    {
                        accessToken
                    }
                );
            }).WithName("GoogleCallback");
        }
    }
}
