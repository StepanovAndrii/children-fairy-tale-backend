namespace Api.DTOs.User.Requests
{
    public record UpdateUserRequestDto
        (
            string? Name,
            int? Age,
            string? ProfilePictureUrl
        );
}
