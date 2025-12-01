namespace Application.Features.Commands
{
    public record CreateStoryCommand
    (
        string Title,
        string? Description,
        string? CoverImageUrl,
        string LanguageCode,
        List<CreateChapterCommand> Chapters
    );
}
