using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        void Add(T t);
        T Delete(T t);
        T Get(int id);
        List<T> GetAll();
        T Update(T t);
    }
}
