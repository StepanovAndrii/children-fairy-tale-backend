namespace Api.DTOs.Story.Requests.CreateStory
{
    public record CreateStoryRequestDto
        (
            string Title,
            string? Description,
            string coverPath,
            uint CategoryId,
            uint LanguageId,
            List<CreateChapterRequestDto> Chapters
        );
}
