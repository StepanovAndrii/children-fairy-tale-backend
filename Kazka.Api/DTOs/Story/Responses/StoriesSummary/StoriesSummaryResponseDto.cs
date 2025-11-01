namespace Api.DTOs.Story.Responses.StoriesSummary
{
    public record StoriesSummaryResponseDto 
        (
           List<StorySummaryResponseDto> Stories,
           uint TotalCount
        );
}
