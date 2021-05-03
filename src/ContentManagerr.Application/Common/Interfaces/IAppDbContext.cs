using System.Threading;
using System.Threading.Tasks;
using ContentManagerr.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContentManagerr.Application.Common.Interfaces
{
    public interface IAppDbContext
    {
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Domain.Entities.Application> Applications { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleVersion> ArticleVersions { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<User> Users { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}