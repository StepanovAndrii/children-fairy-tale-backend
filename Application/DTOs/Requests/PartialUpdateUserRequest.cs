namespace Application.DTOs.Requests
{
    public record PartialUpdateUserRequest (
        int? Age = null,
        string? Name = null,
        string? ProfilePictureUrl = null
    );
}
