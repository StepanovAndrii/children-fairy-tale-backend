using Kazka.Application.Features.User.Queries.GetAll;
using Kazka.Application.Features.Users.Responses;
using Kazka.Application.Features.Users.Responses.Get;
using Kazka.Application.Interfaces.Services;
using MapsterMapper;
using MediatR;

namespace Kazka.Application.Features.Users.Handlers.Get
{
    public class GetUsersHandler : IRequestHandler<GetUsersQuery, GetUsersResponse>
    {
        private readonly IUserBusinessLogic _userBusinessLogic;
        private readonly IMapper _mapper;
        public GetUsersHandler
            (
                IUserBusinessLogic userBusinessLogic,
                IMapper mapper
            )
        {
            _userBusinessLogic = userBusinessLogic;
            _mapper = mapper;
        }
        public async Task<GetUsersResponse> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userBusinessLogic.GetUsersAsync(request);
            var userResponces = users
                .Select(user => 
                    _mapper.Map<UserResponse>(user)
                );

            return new GetUsersResponse(userResponces);
        }
    }
}
