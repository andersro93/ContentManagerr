using ContentManagerr.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContentManagerr.Infrastructure.Persistence.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Code);

            builder
                .HasMany(l => l.Applications)
                .WithMany(a => a.Languages);

            builder.HasMany(l => l.Users)
                .WithMany(u => u.Languages);
        }
    }
}