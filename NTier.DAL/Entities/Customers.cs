using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class Customers:BaseClass
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }

        public List<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }

        public List<Orders> Orders { get; set; }
    }
}
