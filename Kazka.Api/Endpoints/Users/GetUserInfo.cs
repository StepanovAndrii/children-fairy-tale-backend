using Api.DTOs.User.Responses;
using Kazka.Application.Features.Users.Queries.Get;
using Kazka.Application.Interfaces.External;
using MapsterMapper;
using MediatR;

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
                    ICurrentUserService currentUserService,
                    ISender mediator,
                    IMapper mapper
                ) =>
            {
                var googleId = currentUserService.GoogleId;
                if (googleId == null) return Results.Unauthorized();

                var query = new GetUserQuery
                    (
                        googleId
                    );
                var user = await mediator.Send(query);
                var userDto = mapper.Map<UserProfileResponseDto>(user);

                return Results.Ok(userDto);
            });
        }
    }
}
