using automotive.BL.Models;
using Microsoft.EntityFrameworkCore;

namespace automotive.BL.Contexts
{
    public class BaseContext: DbContext
    {
        public string ConnectionString { get; set; } = $"Data Source={AppDomain.CurrentDomain}/Data/data.db";

        public DbSet<Transport> Transport { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Moto> Moto { get; set; }
        public DbSet<Jeep> Jeep { get; set; }

        public BaseContext() => Database.MigrateAsync();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }
    }
}
