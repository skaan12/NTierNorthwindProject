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
    public class EmployeesTerritoriesConfiguration : IEntityTypeConfiguration<EmployeeTerritories>
    {
        public void Configure(EntityTypeBuilder<EmployeeTerritories> builder)
        {
            builder.HasKey(x => new { x.ID, x.TerritoryID });

            builder.HasOne(x => x.Employees).WithMany(x => x.EmployeeTerritories).HasForeignKey(x => x.ID);
            builder.HasOne(x=>x.Territories).WithMany(x=>x.EmployeeTerritories).HasForeignKey(x=>x.TerritoryID);
        }
    }
}
