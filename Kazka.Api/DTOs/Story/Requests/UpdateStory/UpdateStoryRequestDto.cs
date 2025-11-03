namespace Kazka.Api.DTOs.Story.Requests.UpdateStory
{
    public record UpdateStoryRequestDto
    (
        string? Title,
        string? Description,
        uint? CategoryId,
        string? CoverPath,
        uint? LanguageId
    );
}
