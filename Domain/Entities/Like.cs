namespace Domain.Entities
{
    public class Like
    {
        public required User User { get; set; }
        public required Book Book { get; set; }
    }
}
