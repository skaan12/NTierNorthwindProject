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
    internal class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            
            builder.HasOne(x => x.Categories).WithMany(x => x.Products).HasForeignKey(x => x.CategoryID);
            builder.HasOne(x => x.Suppliers).WithMany(xd => xd.Products).HasForeignKey(xd => xd.SupplierID);
        }
    }
}
