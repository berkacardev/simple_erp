using Entity;
using Repository.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RamRepository.Implementations
{
    public class SalesRamRepositoryImpl : AbstractRepositoryBase<Sales>
    {
        private static AbstractReosurce<Sales> abstractResource = new SalesDummyResource();
        public SalesRamRepositoryImpl() : base(abstractResource)
        {

        }
    }
}
