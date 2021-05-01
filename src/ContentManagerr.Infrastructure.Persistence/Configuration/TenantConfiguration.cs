using ContentManagerr.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContentManagerr.Infrastructure.Persistence.Configuration
{
    internal class TenantsEntityConfiguration : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.ToTable("Tenants");
            
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                .HasMaxLength(255);

            builder
                .HasMany(t => t.Users)
                .WithOne(u => u.Tenant);

            builder.Property(t => t.Status);
        }
    }
}