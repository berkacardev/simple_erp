using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ICustomerService
    {
        List<CustomerModel> GetCustomers();
        CustomerModel CreateCustomer(CustomerModel customerModel);
        CustomerModel DeleteCustomer(CustomerModel customerModel);
        CustomerModel InsertCustomer(CustomerModel customerModel);
    }
}
