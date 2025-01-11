using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Resources
{
    public abstract class AbstractReosurce<T>
    {
        public AbstractReosurce(List<T> resource)
        {
            this.Resource = resource;
        }
        private List<T> Resource;

        public List<T> GetResource()
        {
            return Resource;
        }
    }
}
