using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class Products:BaseClass
    {
        public string ProductName { get; set; }

        public int SupplierID { get; set; }

        public int CategoryID { get; set; }

        public decimal UnitPrice { get; set; }

        public Categories Categories { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }

        public Suppliers Suppliers { get; set; }
    }
}
