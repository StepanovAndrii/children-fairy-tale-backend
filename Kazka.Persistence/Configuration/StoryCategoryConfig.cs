using Kazka.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kazka.Persistence.Configuration
{
    public class StoryCategoryConfig : IEntityTypeConfiguration<StoryCategory>
    {
        public void Configure(EntityTypeBuilder<StoryCategory> builder)
        {
            builder
                .ToTable("story_categories");
            builder
                .HasKey(k => new { k.StoryId, k.CategoryId });
            builder
                .HasOne(storyCategory => storyCategory.Story)
                .WithMany(story => story.StoryCategories)
                .HasForeignKey(storyCategory => storyCategory.StoryId);
            builder
                .HasOne(storyCategory => storyCategory.Category)
                .WithMany(story => story.StoryCategories)
                .HasForeignKey(storyCategory => storyCategory.CategoryId);
        }
    }
}
