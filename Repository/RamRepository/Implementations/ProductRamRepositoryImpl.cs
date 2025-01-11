using Entity;
using Repository.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RamRepository.Implementations
{
    public class ProductRamRepositoryImpl : AbstractRepositoryBase<Product>

    {
        private static AbstractReosurce<Product> abstractResource = new ProductDummyResource();

        public ProductRamRepositoryImpl() : base(abstractResource)
        {
        }
    }
}
