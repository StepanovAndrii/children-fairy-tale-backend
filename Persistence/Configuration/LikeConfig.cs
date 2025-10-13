using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    internal class LikeConfig : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder
                .ToTable("likes");
            builder
                .HasKey(l => new { l.UserId, l.BookId });
            builder
                .HasOne(like => like.User)
                .WithMany(user => user.Likes)
                .HasForeignKey(like => like.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(like => like.Book)
                .WithMany(book => book.Likes)
                .HasForeignKey(like => like.BookId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
