using Microsoft.EntityFrameworkCore;
using SoulsDB.Data.Entities;
using System.Reflection;

namespace SoulsDB.Data.Database
{
    public class DatabaseContext : DbContext
    {
        private IConfiguration configuration { get; }

        public DatabaseContext(IConfiguration configuration)
        {
            this.configuration = configuration;
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("database"));
        }
        public DbSet<NormWeapReinfMultiplier> normWeapReinfMultipliers { get; set; }
    }
}
