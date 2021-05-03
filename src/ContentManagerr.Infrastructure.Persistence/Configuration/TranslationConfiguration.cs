using ContentManagerr.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContentManagerr.Infrastructure.Persistence.Configuration
{
    public class TranslationConfiguration : IEntityTypeConfiguration<Translation>
    {
        public void Configure(EntityTypeBuilder<Translation> builder)
        {
            builder.ToTable("Translations");

            builder.HasKey(t => t.Id);

            builder.HasOne(t => t.Application)
                .WithMany(a => a.Translations);

            builder.HasOne(t => t.Language)
                .WithMany(l => l.Translations);

            builder.Property(t => t.Key)
                .HasMaxLength(255);
            
            builder.Property(t => t.Value);
        }
    }
}