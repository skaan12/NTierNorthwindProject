using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class CustomerDemographics:BaseClass
    {
        public string CustomerDesc { get; set; }

        public List<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
    }
}
