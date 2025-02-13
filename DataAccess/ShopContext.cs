using DataAccess.ModelConfigurations;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using System.Reflection;
using Attribute = System.Attribute;

namespace DataAccess
{
    public class ShopContext :DbContext
    {
        public DbSet<AttributeDb>Attributes {  get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategorie> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=eCommers";

            optionsBuilder
                .UseNpgsql(ConnectionString)
                .UseSnakeCaseNamingConvention();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(builder =>
            {
                builder.HasKey(p => p.Id);

                builder.Property(s => s.ProductName)
                .HasMaxLength(255)
                .IsRequired();

                builder.Property(d => d.ShortDescription)
                .HasMaxLength(255)
                .IsRequired();

            });


            modelBuilder.ApplyConfiguration(new ProductAttributeDb());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTagConfigurations());

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // hammasini configuration qilish!!!


           

        }

    }
}
