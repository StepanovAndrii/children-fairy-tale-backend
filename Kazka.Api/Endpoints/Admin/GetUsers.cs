using Kazka.Api.Attributes;
using Kazka.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.Admin
{
    [AdminEndpoint]
    public class GetUsers : IEndpoint
    {
        public void Map
            (
                IEndpointRouteBuilder app
            )
        {
            app.MapGet("users",
                async (
                    IUserBusinessLogic userBusinessLogic
                ) =>
            {
                userBusinessLogic.Get

                if (result is null)
                    return Results.NoContent();

                var response = mapper.Map<UsersResponseDto>(result);

                return Results.Ok
                    (response);
            });
        }
    }
}
