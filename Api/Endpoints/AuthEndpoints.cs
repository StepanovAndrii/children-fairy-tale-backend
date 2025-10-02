using Microsoft.AspNetCore.Authentication;

namespace Api.Endpoints
{
    public static class AuthEndpoints
    {
        public static void MapAuthEndpoints(this RouteGroupBuilder group)
        {
            var googleGroup = group.MapGroup("/auth/google");

            googleGroup.MapGet("", ChallengeGoogle);
        }

        private static IResult ChallengeGoogle()
        {
            var props = new AuthenticationProperties
            {
                RedirectUri = "http://localhost:4200"
            };

            return Results.Challenge(props, ["Google"]);
        }
    }
}