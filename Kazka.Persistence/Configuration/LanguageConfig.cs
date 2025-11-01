using Domain.Entities;
using Domain.ValueObjects;
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
                .HasKey(language => language.Id);
            builder
                .Property(language => language.Code)
                .HasConversion(
                    code => code.Value,
                    value => new LanguageCode(value)
                )
                .HasMaxLength(3)
                .IsRequired();
            builder
                .HasAlternateKey(x => x.Code);
            builder
                .HasMany(language => language.Books)
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
