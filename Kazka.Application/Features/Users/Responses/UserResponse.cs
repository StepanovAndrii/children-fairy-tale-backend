namespace Kazka.Application.Features.Users.Responses
{
    public record UserResponse
        (
            uint Id,
            string Name,
            byte? Age,
            string Role,
            string? ProfilePictureUrl
        );
}
