namespace Kazka.Api.Dtos.Responces
{
    public class StoryResponce
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required string? CoverUrl { get; set; }
        public required int LikesCount { get; set; }
        public required bool IsLikedByCurrentUser { get; set; }
    }
}
