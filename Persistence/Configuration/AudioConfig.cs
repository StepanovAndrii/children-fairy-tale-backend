using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class AudioConfig: IEntityTypeConfiguration<Audio>
    {
        public void Configure(EntityTypeBuilder<Audio> builder)
        {
            builder
                .ToTable("audios");
            builder
                .HasKey(audio => audio.ChapterId);
            builder
                .HasOne(audio => audio.Chapter)
                .WithOne(chapter => chapter.Audio)
                .HasForeignKey<Audio>(audio => audio.ChapterId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .Property(audio => audio.AudioUrl)
                .HasConversion(
                    audioUrl => audioUrl.Value,
                    value => new Url(value)
                )
                .HasMaxLength(2083)
                .IsRequired();
        }
    }
}
