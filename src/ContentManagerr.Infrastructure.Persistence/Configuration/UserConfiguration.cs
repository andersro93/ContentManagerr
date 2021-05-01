using ContentManagerr.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContentManagerr.Infrastructure.Persistence.Configuration
{
    internal class UsersEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder
                .HasOne(u => u.Tenant)
                .WithMany(t => t.Users);
            
            builder.Property(u => u.FirstName)
                .HasMaxLength(255);
            
            builder.Property(u => u.LastName)
                .HasMaxLength(255);
            
            builder.Property(u => u.Email)
                .HasMaxLength(254);

            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(15);

            builder.Property(u => u.Status);
        }
    }
}