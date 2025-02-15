using DataAccess.ModelConfigurations;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using System.Reflection;


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
        public DbSet<Role> Roles { get; set; }
        public DbSet<StaffAccount> StafAccounts { get; set; }
        public DbSet<StaffRole> StaffRoles { get; set; }
       

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=eCommers";

            optionsBuilder
                .UseNpgsql(ConnectionString)
                .UseSnakeCaseNamingConvention();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    modelBuilder.Entity<Product>(builder =>
            //    {
            //        builder.HasKey(p => p.Id);

            //        builder.Property(s => s.ProductName)
            //        .HasMaxLength(255)
            //        .IsRequired();

            //        builder.Property(d => d.ShortDescription)
            //        .HasMaxLength(255)
            //        .IsRequired();

            //    });

            //modelBuilder.Entity<ProductAttribute>(builder =>
            //{
            //    builder.HasKey(r => new
            //    {
            //        r.ProductId,
            //        r.AttributeId
            //    });
            //    builder.HasOne(pa => pa.Product)
            //    .WithMany(d => d.ProductAttributes)
            //    .HasForeignKey(pa => pa.ProductId);

            //    builder.HasOne(pa => pa.AttributeDb)
            //    .WithMany(d => d.ProductAttributes)
            //    .HasForeignKey(pa => pa.AttributeId);
            //});

            modelBuilder.Entity<StaffRole>(builder =>
            {
                builder.HasKey(r => new
                {
                    r.RoleId,
                    r.StaffId
                });

                builder.HasOne(st => st.Role)
                .WithMany(t => t.StaffRoles)
                .HasForeignKey(st => st.RoleId);

                builder.HasOne(st => st.StaffAccount)
                .WithMany(t => t.StaffRoles)
                .HasForeignKey(st => st.StaffId);
            });

            modelBuilder.ApplyConfiguration(new ProductAttributeDb());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTagConfigurations());
            modelBuilder.ApplyConfiguration(new StaffRoleConfiguration());

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // hammasini configuration qilish!!!


           

        }

    }
}
