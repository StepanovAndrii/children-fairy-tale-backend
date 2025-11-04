using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ChapterConfig : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder
                .ToTable("chapters");
            builder
                .Property(chapter => chapter.ChapterOrder);
            builder
                .Property(chapter => chapter.Title)
                .HasMaxLength(100);
            builder
                .HasOne(chapter => chapter.Story)
                .WithMany(book => book.Chapters)
                .HasForeignKey(chapter => chapter.StoryId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(chapter => chapter.Paragraphs)
                .WithOne(paragraph => paragraph.Chapter)
                .HasForeignKey(paragraph => paragraph.ChapterId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
