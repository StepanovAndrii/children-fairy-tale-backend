using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class StoryConfig : IEntityTypeConfiguration<Story>
    {
        public void Configure(EntityTypeBuilder<Story> builder)
        {
            builder
                .ToTable("books");
            builder
                .Property(book => book.Title)
                .HasMaxLength(256);
            builder
                .Property(book => book.Description)
                .HasMaxLength(1000);
            builder
                .HasMany(story => story.StoryCategories)
                .WithOne(storyCategories => storyCategories.Story)
                .HasForeignKey(story => story.StoryId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .Property(book => book.CoverPath)
                .HasMaxLength(2083);
            builder
                .HasOne(book => book.Language)
                .WithMany(language => language.Stories)
                .HasForeignKey(book => book.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .Property<DateTime>("СreatedAt")
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd();
            builder
                .HasMany(book => book.Likes)
                .WithOne(like => like.Story)
                .HasForeignKey(like => like.StoryId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(book => book.Chapters)
                .WithOne(chapter => chapter.Story)
                .HasForeignKey(chapter => chapter.StoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
