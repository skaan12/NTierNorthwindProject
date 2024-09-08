using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class Employees:BaseClass
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public int ReportsTo { get; set; }

        public virtual Employees Manager { get; set; }

        public virtual List<Employees> Subordinates { get; set; }
        public List<EmployeeTerritories> EmployeeTerritories { get; set; }
    }
}
