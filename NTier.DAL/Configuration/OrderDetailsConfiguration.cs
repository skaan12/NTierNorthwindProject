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
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasKey(x => new { x.ID, x.ProductID });

            builder.HasOne(x => x.Products).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x=>x.Orders).WithMany(x=>x.OrderDetails).HasForeignKey(x=>x.ID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
