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
    public class CustomerDemographicsConfiguration : IEntityTypeConfiguration<CustomerDemographics>
    {
        public void Configure(EntityTypeBuilder<CustomerDemographics> builder)
        {
            builder.Property(x=>x.CustomerDesc).HasMaxLength(50).IsRequired(false);
        }
    }
}
