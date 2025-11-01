using Domain.Entities;
using Domain.ValueObjects;
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
                .HasKey(book => book.Id);
            builder
                .Property(book => book.Title)
                .HasMaxLength(256)
                .IsRequired();
            builder
                .Property(book => book.Description)
                .HasMaxLength(1000);
            builder
                .HasOne(story => story.Category)
                .WithMany(category => category.Stories)
                .HasForeignKey(story => story.CategoryId);
            builder
                .Property(book => book.CoverPath)
                .HasConversion(
                   coverpathUrl => coverpathUrl == null ? null : coverpathUrl.Value,
                   value => value == null ? null : new Url(value)
                )
                .HasMaxLength(2083);
            builder
                .HasOne(book => book.Language)
                .WithMany(language => language.Books)
                .HasForeignKey(book => book.LanguageId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            builder
                .Property<DateTime>("_createdAt")
                .HasColumnName("CreatedAt")
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(book => book.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAddOrUpdate()
                .IsRequired();
            builder
                .HasMany(book => book.Likes)
                .WithOne(like => like.Book)
                .HasForeignKey(like => like.BookId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(book => book.Chapters)
                .WithOne(chapter => chapter.Book)
                .HasForeignKey(chapter => chapter.BookId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
