using Api.DTOs.Story.Responses.StoriesSummary;

namespace Api.DTOs.Story.Responses.ChaptersSummary
{
    public record ChaptersSummaryResponseDto
        (
            List<ChapterSummaryResponseDto> Stories,
            uint TotalCount
        );
}
