using System.Reflection;
using ContentManagerr.Application.Common.Interfaces;
using ContentManagerr.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContentManagerr.Infrastructure.Persistence
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        internal const string ConnectionStringKey = "AppDb";
        
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}