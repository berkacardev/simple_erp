using Entity;
using Model;
using Repository;
using Repository.RamRepository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Exceptions;
using Utility.Parser;

namespace Service.Implementations
{
    public class SalesServiceImpl : ISalesService
    {
        private AbstractRepositoryBase<Product> ProductRepository;
        private AbstractRepositoryBase<Sales> SalesRepository;
        private List<ProductModel> TemperarySalesProducts;
        public SalesServiceImpl()
        {
            ProductRepository = new ProductRamRepositoryImpl();
            SalesRepository = new SalesRamRepositoryImpl();
        }
        public ProductModel GetProduct(string id)
        {
            int numericId = 0;
            try
            {
                numericId = Convert.ToInt32(id);
            }
            catch
            {
                throw new ProductIdIsNotNumericException();
            }
            var result = ProductRepository.Get(numericId);
            if (result == null)
            {
                throw new ProductIsNotFoundException();
            }
            return GlobalParser.ConvertToProductModel(ProductRepository.Get(numericId));
        }

        public double GetTemperarySalesPrice()
        {
            return TemperarySalesProducts.Sum(u => Convert.ToInt32(u.ProductSalesPrice));
        }
        public void AddProductTemperarySalesChart(ProductModel product)
        {
            TemperarySalesProducts.Add(product);
        }

        public void CreateTemperarySales()
        {
            TemperarySalesProducts = new List<ProductModel>();
        }

        public List<SalesModel> GetAllSales()
        {
            return SalesRepository.GetAll().Select(u => GlobalParser.ConverToSalesModel(u)).ToList();
        }

        public void MakeSalesAsPermanent(CustomerModel customerModel)
        {
            int salesId = SalesRepository.GetAll().Count + 1;
            Customer customer = GlobalParser.ConverToCustomer(customerModel);
            List<Product> products = TemperarySalesProducts.Select(u => GlobalParser.ConvertToProduct(u)).ToList();
            DateTime salesDateTime = DateTime.Now;
            SalesRepository.Add(new Sales(salesId, products, customer, GetTemperarySalesPrice(), salesDateTime));
            products.ForEach(u =>
            {
                u.ProductLastStockQuantity -= 1; ProductRepository.Update(u);
            });
        }
    }
}
