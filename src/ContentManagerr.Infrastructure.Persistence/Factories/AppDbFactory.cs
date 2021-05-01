using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ContentManagerr.Infrastructure.Persistence.Factories
{
    public class AppDbFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        private const string DevelopmentDbConnectionString = "Server=localhost;Database=appDb;User Id=sa;Password=C0nt3ntM4n4g3rr!;";
        
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(args.Length > 0 ? args[0] : DevelopmentDbConnectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}