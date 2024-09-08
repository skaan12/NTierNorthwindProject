using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Configuration
{
    internal class EmployeesConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(200).IsRequired(true);

            builder.HasOne(x => x.Manager).WithMany(x => x.Subordinates).HasForeignKey(x => x.ReportsTo).IsRequired(false);
        }
    }
}
