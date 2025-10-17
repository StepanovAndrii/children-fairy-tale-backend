namespace Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<Story> Stories { get; set; } = new HashSet<Story>();
    }
}
