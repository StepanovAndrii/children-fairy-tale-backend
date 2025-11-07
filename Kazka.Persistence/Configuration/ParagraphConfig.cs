using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ParagraphConfig : IEntityTypeConfiguration<Paragraph>
    {
        public void Configure(EntityTypeBuilder<Paragraph> builder)
        {
            builder
                .ToTable("paragraphs");
            builder
                .Property(paragraph => paragraph.Text)
                .HasMaxLength(5000);
            builder
                .Property(paragraph => paragraph.ImageUrl)
                .HasMaxLength(2083);
            builder
                .HasOne(paragraph => paragraph.Chapter)
                .WithMany(chapter => chapter.Paragraphs)
                .HasForeignKey(paragraph => paragraph.ChapterId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasAlternateKey(paragraph => new { paragraph.ChapterId, paragraph.ParagraphOrder });
        }
    }
}
