using Kazka.Api.Attributes;
using Microsoft.AspNetCore.Authentication;

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
                ( IConfiguration configuration ) =>
            {
                var redirectUri = configuration.GetSection("Authentication").GetValue<string>("RedirectUrl");

                var props = new AuthenticationProperties
                {
                    RedirectUri = redirectUri
                };

                return Results.Challenge(props, ["Google"]);
            })
            .AllowAnonymous();
        }
    }
}
