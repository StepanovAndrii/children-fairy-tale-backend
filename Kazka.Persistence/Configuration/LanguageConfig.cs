using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.SeedGenerators;

namespace Persistence.Configuration
{
    public class LanguageConfig : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder
                .ToTable("languages");
            builder
                .Property(language => language.Code)
                .HasMaxLength(3);
            builder
                .HasAlternateKey(x => x.Code);
            builder
                .HasMany(language => language.Stories)
                .WithOne(book => book.Language)
                .HasForeignKey(book => book.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasData(
                    LanguageSeed.GetAllLanguages()
                );
        }
    }
}
