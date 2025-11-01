using Api.DTOs.User.Requests;
using Api.DTOs.User.Responses;
using Kazka.Application.Features.User.Command.Update;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Endpoints.Users
{
    public class UpdateUserInfo : IEndpoint
    {
        public void Map
            (
                IEndpointRouteBuilder app
            )
        {

            app.MapPatch("users/me",
                async (
                    [FromBody] UpdateUserRequestDto request,
                    ISender mediator,
                    IMapper mapper
                ) =>
            {
                var command = mapper.Map<UpdateUserCommand>(request);

                var result = await mediator.Send(command);

                if (result is null)
                    // TODO: check if NoContent is the best fit
                    return Results.NoContent();

                var response = mapper.Map<UserProfileResponseDto>(result);

                // TODO: add Result.NoContent
                return Results.Ok
                    (response);
            });
        }
    }
}
