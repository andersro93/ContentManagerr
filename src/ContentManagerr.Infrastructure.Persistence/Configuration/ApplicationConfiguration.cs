using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContentManagerr.Infrastructure.Persistence.Configuration
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Domain.Entities.Application>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Application> builder)
        {
            builder.ToTable("Applications");

            builder.HasKey(a => a.Id);

            builder.HasOne(a => a.Tenant)
                .WithMany(t => t.Applications);

            builder.HasMany(a => a.Languages)
                .WithMany(l => l.Applications);

            builder.HasMany(a => a.Articles)
                .WithOne(a => a.Application);

            builder.HasMany(a => a.Translations)
                .WithOne(t => t.Application);

            builder.Property(a => a.Name)
                .HasMaxLength(255);
        }
    }
}