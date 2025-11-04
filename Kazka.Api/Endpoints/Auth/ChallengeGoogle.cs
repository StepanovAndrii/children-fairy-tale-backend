
using Microsoft.AspNetCore.Authentication;

namespace Api.Endpoints.Auth
{
    public class ChallengeGoogle : IEndpoint
    {
        public void Map(
                IEndpointRouteBuilder app
            )
        {
            app.MapGet("auth/google",
                ( 
                    IConfiguration configuration
                ) =>
            {
                var redirectUri = configuration["Authentication:RedirectUrl"];

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
