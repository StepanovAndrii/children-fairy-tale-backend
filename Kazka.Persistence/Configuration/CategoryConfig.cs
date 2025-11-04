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
                .ToTable("categories");
            builder
                .HasAlternateKey(category => category.Name);
            builder
                .HasMany(category => category.StoryCategories)
                .WithOne(storyCategories => storyCategories.Category)
                .HasForeignKey(category => category.StoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
