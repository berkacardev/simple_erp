using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Resources
{
    public class SalesDummyResource : AbstractReosurce<Sales>
    {
        private static List<Sales> Sales = new List<Sales>();
        public SalesDummyResource() : base(Sales)
        {

        }
    }
}
