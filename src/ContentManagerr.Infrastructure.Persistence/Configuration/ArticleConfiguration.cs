using ContentManagerr.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContentManagerr.Infrastructure.Persistence.Configuration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");

            builder.HasKey(a => a.Id);

            builder.HasOne(a => a.Application)
                .WithMany(a => a.Articles);

            builder.Property(a => a.Sluggish);
            builder.Property(a => a.Title);
            builder.Property(a => a.Status);

            builder.HasOne(a => a.ActiveVersion);

            builder.HasMany(a => a.ArticleVersions)
                .WithOne(av => av.Article);
            
            builder.Property(a => a.CreatedAt);
            builder.Property(a => a.UpdatedAt);
            builder.Property(a => a.DeletedAt);
        }
    }
}