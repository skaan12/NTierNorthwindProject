using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.SampleData
{
    public class CategoriesData
    {
        public static List<Categories> GetCategories()
        {
            return new List<Categories>
            {
                new Categories { ID = 1, CategoryName = "Basd", Description = "High quality product" },
            };
        }
    }
}

