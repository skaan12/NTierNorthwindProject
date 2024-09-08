using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class EmployeeTerritories:BaseClass
    {
        public int TerritoryID { get; set; }

        public Employees Employees { get; set; }

        public Territories Territories { get; set; }
    }
}
