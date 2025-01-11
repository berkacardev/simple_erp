using Entity;
using Repository.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class AbstractRepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        private AbstractReosurce<T> reosurce;
        public AbstractRepositoryBase(AbstractReosurce<T> reosurce)
        {
            this.reosurce = reosurce;
        }

        public void Add(T t)
        {
            this.reosurce.GetResource().Add(t);
        }

        public T Delete(T t)
        {
            if (this.reosurce.GetResource().Contains(t))
            {
                this.reosurce.GetResource().Remove(t);
                return t;
            }
            else
            {
                return null;
            }
        }

        public T Get(int id)
        {
            return this.reosurce.GetResource().Where(u => u.Id == id).First();
        }


        public List<T> GetAll()
        {
            return this.reosurce.GetResource();
        }

        abstract public T Update(T t);
    }
}
