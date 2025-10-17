namespace Application.DTOs.Requests.CreateStoryRequestsDtos
{
    public record StoryCreateDto(
        string Title,
        string? Description,
        string Category,
        string LanguageCode,
        string? CoverPath,
        List<ChapterDto> Chapters
    );
}
