using ContentManagerr.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContentManagerr.Infrastructure.Persistence.Configuration
{
    public class ArticleVersionConfiguration : IEntityTypeConfiguration<ArticleVersion>
    {
        public void Configure(EntityTypeBuilder<ArticleVersion> builder)
        {
            builder.ToTable("ArticleVersions");

            builder.HasKey(av => av.Id);

            builder.HasOne(av => av.Article)
                .WithMany(av => av.ArticleVersions);

            builder.HasOne(av => av.Language)
                .WithMany(l => l.ArticleVersions);

            builder.Property(av => av.Value)
                .IsRequired();

            builder.Property(av => av.CreatedAt);
            builder.Property(av => av.UpdatedAt);
            builder.Property(av => av.DeletedAt);

            builder.HasOne(av => av.CreatedBy)
                .WithMany(u => u.ArticleVersionsCreated);
            
            builder.HasOne(av => av.UpdatedBy)
                .WithMany(u => u.ArticleVersionsUpdated);
            
            builder.HasOne(av => av.DeletedBy)
                .WithMany(u => u.ArticleVersionsDeleted);
            
        }
    }
}