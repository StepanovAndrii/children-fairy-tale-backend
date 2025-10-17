namespace Application.DTOs.Requests
{
    public record StoryQueryParameters(
        int? Limit = null,
        int? Offset = null,
        int? CategoryId = null);
}
