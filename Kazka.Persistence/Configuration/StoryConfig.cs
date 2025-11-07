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
                .Property(book => book.CoverPath)
                .HasMaxLength(2083);
            builder
                .Property<DateTime>("_createdAt")
                .HasColumnName("CreatedAt")
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd();
        }
    }
}
