using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTier.DAL.Entities;
using NTier.DAL.SampleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Configuration
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.Property(x=>x.CategoryName).HasMaxLength(200).IsRequired(true);

            builder.Property(x=>x.Description).HasMaxLength(255).IsRequired(false);

            //builder.HasOne(p => p.Categories).WithMany(x => x.Products).HasForeignKey(pd => pd.CategoryID);
            builder.HasKey(x => x.ID);

            builder.HasData(CategoriesData.GetCategories());

            
        }
    }
}
