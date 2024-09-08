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
    public class CustomerCustomerDemoConfiguration : IEntityTypeConfiguration<CustomerCustomerDemo>
    {
        public void Configure(EntityTypeBuilder<CustomerCustomerDemo> builder)
        {
            builder.HasKey(x=> new {x.CustomerID, x.CustomerTypeID});

            builder.HasOne(x=>x.Customers).WithMany(x=>x.CustomerCustomerDemo).HasForeignKey(x=>x.CustomerID);
            builder.HasOne(x=>x.CustomerDemographics).WithMany(x=>x.CustomerCustomerDemo).HasForeignKey(x => x.CustomerTypeID);
            


            
        }
    }
}
