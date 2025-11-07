using Domain.Entities;
using Kazka.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public class KazkaContext: DbContext
    {
        public KazkaContext(
            DbContextOptions<KazkaContext> options
        ) : base(options) { }

        public DbSet<Audio> Audios => Set<Audio>();
        public DbSet<Story> Stories => Set<Story>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Chapter> Chapters => Set<Chapter>();
        public DbSet<Like> Likes => Set<Like>();
        public DbSet<Paragraph> Paragraphs => Set<Paragraph>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Language> Languages => Set<Language>();
        public DbSet<StoryCategory> StoryCategories => Set<StoryCategory>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
