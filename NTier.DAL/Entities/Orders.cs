using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class Orders:BaseClass
    {
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }

        public int ShipVia { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public Customers Customers { get; set; }

        public Employees Employees { get; set; }

        public Shippers Shippers { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }

        
    }
}
