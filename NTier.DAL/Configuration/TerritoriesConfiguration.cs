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
    public class TerritoriesConfiguration : IEntityTypeConfiguration<Territories>
    {
        public void Configure(EntityTypeBuilder<Territories> builder)
        {
            builder.HasOne(x => x.Region).WithMany(x => x.Territories).HasForeignKey(x=>x.RegionID);
        }
    }
}
