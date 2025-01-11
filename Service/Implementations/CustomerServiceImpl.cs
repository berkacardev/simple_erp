using Entity;
using Model;
using Repository;
using Repository.RamRepository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementations
{
    public class CustomerServiceImpl : ICustomerService
    {
        private AbstractRepositoryBase<Customer> CustomerRepository;

        public CustomerServiceImpl()
        {
            CustomerRepository = new CustomerRamRepositoryImpl();
        }

        public CustomerModel CreateCustomer(CustomerModel c)
        {
            var customer = ConvertToCustomer(c);
            customer.Id = CustomerRepository.GetAll().Count();
            CustomerRepository.Add(customer);
            c.CustomerId = customer.Id;
            return c;
        }

        public CustomerModel DeleteCustomer(CustomerModel c)
        {
            var customer = ConvertToCustomer(c);
            CustomerRepository.Delete(customer);
            return c;
        }

        public List<CustomerModel> GetCustomers()
        {
            return CustomerRepository.GetAll()
                .Select(u => new CustomerModel(u.Id, u.CustomerName, u.CustomerSurname, u.CustomerPhoneNumber, u.CustomerEmailAdress, u.CustomerAdress))
                .ToList();
        }

        public CustomerModel InsertCustomer(CustomerModel c)
        {
            var customer = ConvertToCustomer(c);
            CustomerRepository.Update(customer);
            return c;
        }
        private Customer ConvertToCustomer(CustomerModel c)
        {
            return new Customer(c.CustomerId, c.CustomerName, c.CustomerSurname, c.CustomerPhoneNumber, c.CustomerEmailAdress, c.CustomerAdress);
        }
    }
}
