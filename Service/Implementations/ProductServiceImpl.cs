using Entity;
using Model;
using Repository;
using Repository.RamRepository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Parser;

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
            var product = GlobalParser.ConvertToProduct(p);
            product.Id = ProductRepository.GetAll().Count()+1;
            ProductRepository.Add(product);
            p.ProductId = product.Id;
            return p;
        }

        public ProductModel DeleteProduct(ProductModel p)
        {
            var product = GlobalParser.ConvertToProduct(p);
            ProductRepository.Delete(product);
            return p;
        }

        public List<ProductModel> GetProducts()
        {
            return ProductRepository.GetAll()
                .Select(u => GlobalParser.ConvertToProductModel(u))
                .ToList();
        }

        public ProductModel InsertProduct(ProductModel p)
        {
            var product = GlobalParser.ConvertToProduct(p);
            ProductRepository.Update(product);
            return p;

        }
    }
}
