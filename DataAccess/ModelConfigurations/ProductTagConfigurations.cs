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
    public class ProductTagConfigurations : IEntityTypeConfiguration<ProductTag>
    {
        public void Configure(EntityTypeBuilder<ProductTag> builder)
        {
             builder.HasKey(w => new
            {
                w.TagId,
                w.ProductId
            });

            builder.HasOne(pt => pt.Tag)
            .WithMany(q => q.ProductTags)
            .HasForeignKey(pt => pt.TagId);

            builder.HasOne(pt => pt.Product)
            .WithMany(x => x.ProductTags)
            .HasForeignKey(pt => pt.ProductId);
        }
    }
}
