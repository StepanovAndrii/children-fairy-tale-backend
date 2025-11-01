using Kazka.Application.Features.Book.Command.Add;
using Kazka.Application.Features.User.Command.Update;
using Kazka.Application.Features.Users.Responses;
using Kazka.Application.Interfaces.Services;
using MapsterMapper;
using MediatR;

namespace Kazka.Application.Features.Users.Handlers.Update
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, UserResponse>
    {
        private readonly IUserBusinessLogic _userBusinessLogic;
        private readonly IMapper _mapper;
        public UpdateUserHandler
            (
                IUserBusinessLogic userBusinessLogic,
                IMapper mapper
            )
        {
            _userBusinessLogic = userBusinessLogic;
            _mapper = mapper;
        }

        public async Task<UserResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            await _userBusinessLogic.UpdateUserAsync
                (
                    request
                );

            return _mapper.Map<UserResponse>(request);
        }
    }
}
