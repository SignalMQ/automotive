using automotive.Models;
using Microsoft.EntityFrameworkCore;

namespace automotive.Contexts
{
    internal class BaseContext: DbContext
    {
        public string ConnectionString { get; set; } = "Data Source=data.db";

        public DbSet<Car> Transports { get; set; }

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
