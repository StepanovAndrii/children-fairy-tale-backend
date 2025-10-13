namespace Domain.Entities
{
    public class Like
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public required User User { get; set; }
        public required Book Book { get; set; }
    }
}
