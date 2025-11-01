namespace Domain.Entities
{
    public class Like
    {
        public uint UserId { get; set; }
        public uint BookId { get; set; }
        public required User User { get; set; }
        public required Story Book { get; set; }
    }
}
