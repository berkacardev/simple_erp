using Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Exceptions;

namespace Utility.Parser
{
    public static class GlobalParser
    {
        public static Product ConvertToProduct(ProductModel p)
        {
            double productPurchasePrice = 0;
            double productSalesPrice = 0;
            int productFirstStockQuantity = 0;
            int productLastStockQuantity = 0;

            try
            {
                productPurchasePrice = Convert.ToDouble(p.ProductPurchasePrice);
            }
            catch
            {
                throw new ProductPurchasePriceIsNotNumericException();
            }

            try
            {
                productSalesPrice = Convert.ToDouble(p.ProductSalesPrice);
            }
            catch
            {
                throw new ProductSalesPriceIsNotNumericException();
            }

            try
            {
                productFirstStockQuantity = Convert.ToInt32(p.ProductFirstStockQuantity);
            }
            catch
            {
                throw new ProductFirstStockQuaintityIsNotNumericException();
            }
            try
            {
                productFirstStockQuantity = Convert.ToInt32(p.ProductLastStockQuantity);
            }
            catch
            {
                throw new ProductFirstStockQuaintityIsNotNumericException();
            }
            return new Product(p.ProductId, p.ProductName, productPurchasePrice, productSalesPrice, productFirstStockQuantity, productLastStockQuantity);
        }
        public static ProductModel ConvertToProductModel(Product p)
        {
            return new ProductModel(p.Id, p.ProductName, p.ProductPurchasePrice.ToString(), p.ProductSalesPrice.ToString(), p.ProductFirstStockQuantity.ToString(), p.ProductLastStockQuantity.ToString());
        }
        public static CustomerModel ConverToCustomerModel(Customer customer)
        {
            return new CustomerModel(customer.Id, customer.CustomerName, customer.CustomerSurname, customer.CustomerPhoneNumber, customer.CustomerEmailAdress, customer.CustomerAdress);
        }
        public static Customer ConverToCustomer(CustomerModel customerModel)
        {
            return new Customer(customerModel.CustomerId, customerModel.CustomerName, customerModel.CustomerSurname, customerModel.CustomerPhoneNumber, customerModel.CustomerEmailAdress, customerModel.CustomerAdress);
        }
        public static SalesModel ConverToSalesModel(Sales sales)
        {
            return new SalesModel(sales.Id, sales.Product.Select(u => ConvertToProductModel(u)).ToList(), sales.SalesSum, ConverToCustomerModel(sales.Customer), sales.SalesDateTime);
        }
    }
}
