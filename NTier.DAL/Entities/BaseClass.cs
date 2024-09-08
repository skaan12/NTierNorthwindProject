using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.DAL.Entities
{
    public abstract class BaseClass
    {
        public int ID { get; set; }

        //public DateTime CreatedTime { get; set; }

        public bool IsActive { get; set; }
    }
}
