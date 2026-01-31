using Microsoft.EntityFrameworkCore;

namespace ProductCatalog.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Data/mydb.db;");

            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
