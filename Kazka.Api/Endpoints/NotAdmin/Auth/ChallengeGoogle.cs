using Domain.Entities;
using Kazka.Api.Attributes;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.NotAdmin.Auth
{
    [EndpointVersion(1)]
    public class ChallengeGoogle : IEndpoint
    {
        public void Map(
                IEndpointRouteBuilder app
            )
        {
            app.MapGet("auth/google",
                (
                    LinkGenerator linkGenerator,
                    SignInManager<User> signManager,
                    HttpContext context
                ) =>
            {
                var callbackUrl = $"{context.Request.Scheme}://{context.Request.Host}{linkGenerator.GetPathByName("GoogleCallback")}";

                var properies = signManager.ConfigureExternalAuthenticationProperties(
                    GoogleDefaults.AuthenticationScheme,
                    callbackUrl
                );

                return Results.Challenge(properies, ["Google"]);
            })
            .AllowAnonymous();
        }
    }
}
