using NTier.DAL.Entities;

namespace NTier.BLL.New_Service
{
    public interface IBaseService<T> where T:BaseClass
    {
        List<T> GetAll();

        string Create(T model);

        string Delete(int id);


    }
}
