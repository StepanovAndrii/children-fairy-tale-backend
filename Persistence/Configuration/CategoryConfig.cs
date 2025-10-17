using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(category => category.Id);
            builder
                .HasAlternateKey(category => category.Name);
            builder
                .HasMany(category => category.Stories)
                .WithOne(story => story.Category)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
