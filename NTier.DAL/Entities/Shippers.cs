using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class Shippers:BaseClass
    {
        public string CompanyName { get; set; }

        public string Phone { get; set; }

       

        public List<Orders> Orders { get; set; }

        
    }
}
