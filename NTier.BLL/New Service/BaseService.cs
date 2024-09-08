using NTier.DAL.Context;
using NTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.New_Service
{
    public class BaseService : IBaseService<T> where T : BaseClass
    {
        NorthwindContext _context = new NorthwindContext();
        public string Create(T model)
        {
            _context.Set<T>().Add(model);
            _context.SaveChanges();
            return "dasdas";
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T>GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
