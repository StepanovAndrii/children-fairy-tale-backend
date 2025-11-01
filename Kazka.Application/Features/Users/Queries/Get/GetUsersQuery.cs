using Kazka.Application.Features.Users.Responses;
using Kazka.Application.Features.Users.Responses.Get;
using MediatR;

namespace Kazka.Application.Features.User.Queries.GetAll
{
    public record GetUsersQuery: IRequest<GetUsersResponse>;
}
