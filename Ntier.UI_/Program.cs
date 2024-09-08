using NTier.BLL.Old_Service;
using NTier.DAL.Entities;

namespace NTier.UI_
{
    class Program
    {
        public static NorthwindService _northwindService = new NorthwindService();
        static void Main(string[] args)

        {
            foreach (Categories item in _northwindService.GetCategories() )
            {
                Console.WriteLine(item.ID + " " + item.CategoryName + " " + item.Description);
            }

        }
    }
}