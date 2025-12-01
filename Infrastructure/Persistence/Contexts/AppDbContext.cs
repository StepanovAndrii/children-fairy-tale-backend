using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Contexts
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Paragraph> Paragraphs { get; set; }
    }
}
