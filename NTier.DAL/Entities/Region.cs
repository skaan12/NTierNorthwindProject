using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public class Region:BaseClass
    {
        public string RegionDescription { get; set; }

        public List<Territories> Territories { get; set; }
    }
}
