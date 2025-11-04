namespace Domain.Entities
{
    public class Like
    {
        public int UserId { get; set; }
        public int StoryId { get; set; }
        public required User User { get; set; }
        public required Story Story { get; set; }
    }
}
