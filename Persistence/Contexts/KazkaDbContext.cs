using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public class KazkaDbContext: DbContext
    {
        public KazkaDbContext(
            DbContextOptions<KazkaDbContext> options
        ) : base(options) { }

        public DbSet<Audio> Audios => Set<Audio>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Chapter> Chapters => Set<Chapter>();
        public DbSet<Like> Likes => Set<Like>();
        public DbSet<Paragraph> Paragraphs => Set<Paragraph>();
        public DbSet<User> Users => Set<User>();
    }
}
