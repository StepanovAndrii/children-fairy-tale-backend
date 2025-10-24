namespace Api.DTOs.Story.Responses.ChaptersSummary
{
    public record ChapterSummaryResponseDto 
        (
            uint Id,
            ushort Number,
            string? AudioPath
        );
}
