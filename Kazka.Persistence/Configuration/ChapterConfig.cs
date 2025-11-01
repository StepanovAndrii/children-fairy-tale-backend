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
                .HasKey(chapter => chapter.Id);
            builder
                .Property(chapter => chapter.Order)
                .IsRequired();
            builder
                .Property(chapter => chapter.Title)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .HasOne(chapter => chapter.Book)
                .WithMany(book => book.Chapters)
                .HasForeignKey(chapter => chapter.BookId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(chapter => chapter.Paragraphs)
                .WithOne(paragraph => paragraph.Chapter)
                .HasForeignKey(paragraph => paragraph.ChapterId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
