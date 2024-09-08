using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class CustomerCustomerDemo
    {
        public int CustomerID { get; set; }
        public int CustomerTypeID { get; set; }

        public Customers Customers { get; set; }

        public CustomerDemographics CustomerDemographics { get; set; }


    }
}
