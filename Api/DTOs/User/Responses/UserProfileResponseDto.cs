namespace Api.DTOs.User.Responses
{
    public record UserProfileResponseDto
        (
            uint Id,
            string Name,
            byte? Age,
            string Role,
            string? ProfilePictureUrl
        );
}
