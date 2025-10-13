using Microsoft.AspNetCore.Authentication;

namespace Api.Endpoints
{
    public static class OAuthEndpoints
    {
        public static void MapAuthEndpoints(this RouteGroupBuilder group)
        {
            var googleGroup = group.MapGroup("/oauth/google");

            googleGroup.MapGet("", ChallengeGoogle);
        }

        private static IResult ChallengeGoogle(HttpContext context)
        {
            var configuration = context.RequestServices.GetRequiredService<IConfiguration>();

            var redirectUri = configuration["Authentication:RedirectUrl"];

            var props = new AuthenticationProperties
            {
                RedirectUri = redirectUri
            };

            return Results.Challenge(props, ["Google"]);
        }
    }
}