using Api.DTOs.User.Responses;

namespace Kazka.Api.DTOs.User.Responses
{
    public record UsersResponseDto
        (
            List<UserProfileResponseDto> Users
        );
}
