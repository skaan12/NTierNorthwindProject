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
    public class ShippersConfiguration : IEntityTypeConfiguration<Shippers>
    {
        public void Configure(EntityTypeBuilder<Shippers> builder)
        {
            builder.Property(x => x.CompanyName).IsRequired(true);
        }
    }
}
