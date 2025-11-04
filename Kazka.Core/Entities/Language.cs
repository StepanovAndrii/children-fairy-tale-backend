namespace Domain.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public required string Code { get; set; }
        public ICollection<Story> Stories { get; set; } = new HashSet<Story>();
    }
}
