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
    public class StaffRoleConfiguration : IEntityTypeConfiguration<StaffRole>
    {
        public void Configure(EntityTypeBuilder<StaffRole> builder)
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
        }
    }
}
