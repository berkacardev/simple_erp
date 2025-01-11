using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IProductService
    {
        List<ProductModel> GetProducts();
        ProductModel CreateProduct(ProductModel productModel);
        ProductModel InsertProduct(ProductModel productModel);
        ProductModel DeleteProduct(ProductModel productModel);
    }
}
