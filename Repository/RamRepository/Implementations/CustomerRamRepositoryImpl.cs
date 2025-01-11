using Entity;
using Repository.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RamRepository.Implementations
{
    public class CustomerRamRepositoryImpl : AbstractRepositoryBase<Customer>
    {
        private static AbstractReosurce<Customer> abstractResource = new CustomerDummyResource();
        public CustomerRamRepositoryImpl() : base(abstractResource)
        {
        }


    }
}
