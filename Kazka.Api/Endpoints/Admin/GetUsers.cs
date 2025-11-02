using Kazka.Api.Attributes;
using Kazka.Api.DTOs.User.Responses;
using Kazka.Application.Features.User.Queries.GetAll;
using MapsterMapper;
using MediatR;
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
                    ISender mediator,
                    IMapper mapper
                ) =>
            {
                var query = new GetUsersQuery();
                var result = await mediator.Send(query);

                if (result is null)
                    return Results.NoContent();

                var response = mapper.Map<UsersResponseDto>(result);

                return Results.Ok
                    (response);
            });
        }
    }
}
