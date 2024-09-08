using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class Territories:BaseClass
    {
        public string TerritoriesDescription { get; set; }

        public int RegionID { get; set; }

        public List<EmployeeTerritories> EmployeeTerritories { get; set; }

        public Region Region { get; set; }
    }
}
