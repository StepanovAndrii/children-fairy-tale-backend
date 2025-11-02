using Kazka.Application.Features.Users.Queries.Get;
using Kazka.Application.Features.Users.Responses;
using Kazka.Application.Interfaces.Services;
using MapsterMapper;
using MediatR;

namespace Kazka.Application.Features.Users.Handlers.Get
{
    public class GetUserHandler : IRequestHandler<GetUserQuery, UserResponse>
    {
        private readonly IUserBusinessLogic _userBusinessLogic;
        private readonly IMapper _mapper;
        public GetUserHandler
            (
                IUserBusinessLogic userBusinessLogic,
                IMapper mapper
            )
        {
            _userBusinessLogic = userBusinessLogic;
            _mapper = mapper;
        }
        public async Task<UserResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userBusinessLogic.GetUserAsync(request);
            //if (user is null)
            // TODO: Result object

            var userResponse = _mapper.Map<UserResponse>(user);
            Console.WriteLine(userResponse is null);
            return userResponse;
        }
    }
}
