using Api.DTOs.User.Requests;
using Kazka.Api.Attributes;

namespace Api.Endpoints.Users.Admin
{
    [AdminEndpoint]
    public class UpdateUserRole : IEndpoint
    {
        public void Map
            (
                IEndpointRouteBuilder app
            )
        {
            app.MapPatch("users/{id}/role",
                async (
                    UpdateUserRoleRequestDto request
                ) =>
            {
                
            });
        }
    }
}
