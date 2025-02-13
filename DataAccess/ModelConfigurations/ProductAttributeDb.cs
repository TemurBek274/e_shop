using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ModelConfigurations
{
    public class ProductAttributeDb : IEntityTypeConfiguration<ProductAttribute> 
    {
        public void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            builder.HasKey(r => new
            {
                r.ProductId,
                r.AttributeId
            });
            builder.HasOne(pa => pa.Product)
            .WithMany(d => d.ProductAttributes)
            .HasForeignKey(pa => pa.ProductId);

            builder.HasOne(pa => pa.AttributeDb)
            .WithMany(d => d.ProductAttributes)
            .HasForeignKey(pa => pa.AttributeId);
        }
    }
}
