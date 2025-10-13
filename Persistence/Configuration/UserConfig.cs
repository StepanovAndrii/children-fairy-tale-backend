using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("users");
            builder
                .HasKey(user => user.Id);
            builder
                .HasAlternateKey(user => user.GoogleId);
            builder
                .Property(user => user.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(user => user.Email)
                .HasConversion(
                    email => email.Value,
                    value => new Email(value))
                .HasMaxLength(320)
                .IsRequired();
            builder
                .HasIndex(user => user.Email)
                .IsUnique();
            builder
                .Property(user => user.NormalizedEmail)
                .HasMaxLength(320)
                .IsRequired();
            builder
                .HasIndex(user => user.NormalizedEmail)
                .IsUnique();
            builder
                .Property(user => user.ProfilePictureUrl)
                .HasConversion(
                    url => url != null ? url.Value : null,
                    value => !string.IsNullOrWhiteSpace(value) ? new Url(value) : null
                )
                .HasMaxLength(2083);
            builder
                .Property(user => user.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(user => user.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAddOrUpdate()
                .IsRequired();
            builder
                .HasMany(user => user.Likes)
                .WithOne(like => like.User)
                .HasForeignKey(like => like.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
