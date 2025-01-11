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
    public class ProductServiceImpl : IProductService
    {
        private AbstractRepositoryBase<Product> ProductRepository;

        public ProductServiceImpl()
        {
            ProductRepository = new ProductRamRepositoryImpl();
        }

        public ProductModel CreateProduct(ProductModel p)
        {
            p.ProductLastStockQuantity = p.ProductFirstStockQuantity;
            var product = ConvertToProduct(p);
            product.Id = ProductRepository.GetAll().Count()+1;
            ProductRepository.Add(product);
            p.ProductId = product.Id;
            return p;
        }

        public ProductModel DeleteProduct(ProductModel p)
        {
            var product = ConvertToProduct(p);
            ProductRepository.Delete(product);
            return p;
        }

        public List<ProductModel> GetProducts()
        {
            return ProductRepository.GetAll()
                .Select(u => ConvertToProductModel(u))
                .ToList();
        }

        public ProductModel InsertProduct(ProductModel p)
        {
            var product = ConvertToProduct(p);
            ProductRepository.Update(product);
            return p;

        }

        private Product ConvertToProduct(ProductModel p)
        {
            double productPurchasePrice = 0;
            double productSalesPrice = 0;
            double productProfit = 0;
            int productFirstStockQuantity = 0;
            int productLastStockQuantity = 0;

            try
            {
                productPurchasePrice = Convert.ToDouble(p.ProductPurchasePrice);
            }
            catch
            {
                throw new Exception();
            }

            try
            {
                productSalesPrice = Convert.ToDouble(p.ProductSalesPrice);
            }
            catch
            {
                throw new Exception();
            }

            try
            {
                productProfit = Convert.ToDouble(p.ProductProfit);
            }
            catch
            {
                throw new Exception();
            }
            try
            {
                productFirstStockQuantity = Convert.ToInt32(p.ProductFirstStockQuantity);
            }
            catch
            {
                throw new Exception();
            }

            try
            {
                productLastStockQuantity = Convert.ToInt32(p.ProductLastStockQuantity);
            }
            catch
            {
                throw new Exception();
            }

            return new Product(p.ProductId, p.ProductName, productPurchasePrice, productSalesPrice, productProfit, productFirstStockQuantity, productLastStockQuantity);
        }
        private ProductModel ConvertToProductModel(Product p)
        {
            return new ProductModel(p.Id, p.ProductName, p.ProductPurchasePrice.ToString(), p.ProductSalesPrice.ToString(), p.ProductProfit.ToString(), p.ProductFirstStockQuantity.ToString(), p.ProductLastStockQuantity.ToString());
        }
    }
}
