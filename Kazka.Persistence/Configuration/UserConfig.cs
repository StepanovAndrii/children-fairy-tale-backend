using Domain.Entities;
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
                .HasAlternateKey(user => user.GoogleId);
            builder
                .Property(user => user.Role)
                .HasConversion<string>()
                .HasMaxLength(20);
            builder
                .Property(user => user.Email)
                .HasMaxLength(320);
            builder
                .HasIndex(user => user.Email)
                .IsUnique();
            builder
                .Property(user => user.Name)
                .HasMaxLength(100);
            builder
                .Property(user => user.NormalizedEmail)
                .HasMaxLength(320);
            builder
                .HasIndex(user => user.NormalizedEmail)
                .IsUnique();
            builder
                .Property(user => user.ProfilePictureUrl)
                .HasMaxLength(2083);
            builder
                .Property<DateTime>("_createdAt")
                .HasColumnName("CreatedAt")
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd();
        }
    }
}
