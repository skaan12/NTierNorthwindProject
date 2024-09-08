using NTier.DAL.Context;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.Old_Service
{
    public class NorthwindService
    {
        NorthwindContext NorthwindContext = new NorthwindContext();


        //List
        public List<Categories> GetCategories()
        {
            var categories = NorthwindContext.Categories.ToList();
            return categories;
        }
    }
}
