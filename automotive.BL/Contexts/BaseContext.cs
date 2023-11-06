using automotive.BL.Models;
using Microsoft.EntityFrameworkCore;

namespace automotive.BL.Contexts
{
    internal class BaseContext: DbContext
    {
        public string ConnectionString { get; set; } = "Data Source=data.db";

        public DbSet<Car> Cars { get; set; }
        public DbSet<Moto> Motos { get; set; }
        public DbSet<Jeep> Jeeps { get; set; }

        public BaseContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }
    }
}
