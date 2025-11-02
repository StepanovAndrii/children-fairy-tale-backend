using Kazka.Application.Features.Users.Responses;
using MediatR;

namespace Kazka.Application.Features.User.Command.Update
{
    public record UpdateUserCommand
    (
        string? Name,
        byte? Age,
        string? ProfilePictureUrl
    ): IRequest<UserResponse>;
}
