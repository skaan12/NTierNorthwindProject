using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class OrderDetails:BaseClass
    {
        public int ProductID { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal Discount { get; set; }

        public Products Products { get; set; }

        public Orders Orders { get; set; }



    }
}
