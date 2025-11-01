namespace Api.Endpoints.Users
{
    public class GetUserInfo : IEndpoint
    {
        public void Map(
                IEndpointRouteBuilder app
            )
        {
            app.MapGet("users/me",
                async (
                    
                ) =>
            {
                
            });
        }
    }
}
