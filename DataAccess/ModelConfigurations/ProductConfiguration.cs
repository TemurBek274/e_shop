using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ModelConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductCategorie>
    {


        public void Configure(EntityTypeBuilder<ProductCategorie> builder)
        {

                builder.HasKey(i => i.CategoryId);

                builder.HasKey(e => e.ProducrId);

                builder.HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProducrId);

                builder.HasOne(pc => pc.Category)
                .WithMany(s => s.ProductCategories)
                .HasForeignKey(pc => pc.CategoryId);

        }
    }
}
