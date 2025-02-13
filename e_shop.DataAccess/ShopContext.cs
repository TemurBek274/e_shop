using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace e_shop.DataAccess
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionSting = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=eCommerce";
            optionsBuilder
                .UseNpgsql(connectionSting)
                .UseSnakeCaseNamingConvention();
        }
    }
}
