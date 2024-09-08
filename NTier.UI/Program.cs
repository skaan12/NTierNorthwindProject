using NTier.BLL.Old_Service;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NTier.UI
{
    public class Program
    {
        public static NorthwindService NorthwindService = new NorthwindService();
        static void Main(string[] args) 
        {

            foreach(Categories item in NorthwindService.GetCategories())
            {
                Console.WriteLine(item.ID+" "+ item.CategoryName+" "+ item.Description);
            }
        }
    }
}
