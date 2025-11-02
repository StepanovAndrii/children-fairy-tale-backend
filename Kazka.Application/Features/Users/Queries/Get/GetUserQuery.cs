using Kazka.Application.Features.Users.Responses;
using MediatR;

namespace Kazka.Application.Features.Users.Queries.Get
{
    public record GetUserQuery
        (
            string GoogleId
        ): IRequest<UserResponse>;
}
