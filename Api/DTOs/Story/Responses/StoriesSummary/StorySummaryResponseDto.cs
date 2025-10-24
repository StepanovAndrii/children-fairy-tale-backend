namespace Api.DTOs.Story.Responses.StoriesSummary
{
    public record StorySummaryResponseDto
        (
            uint Id,
            string Title,
            string? CoverPath
        );
}
