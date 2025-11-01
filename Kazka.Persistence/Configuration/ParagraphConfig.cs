using Domain.Entities;
using Domain.ValueObjects;
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
                .HasKey(paragraph => paragraph.Id);
            builder
                .Property(paragraph => paragraph.ParagraphOrder)
                .IsRequired();
            builder
                .Property(paragraph => paragraph.Text)
                .HasMaxLength(5000)
                .IsRequired();
            builder
                .Property(paragraph => paragraph.ImageUrl)
                .HasConversion(
                    url => url.Value,
                    urlString => new Url(urlString)
                )
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
