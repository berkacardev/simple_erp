using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Resources
{
    public class ProductDummyResource : AbstractReosurce<Product>
    {
        private static List<Product> Products = new List<Product>();
        public ProductDummyResource() : base(Products)
        {
            Products.Add(new Product(123,"CocaCola 2.5 LT",40,60,5,25));
            Products.Add(new Product(215,"Pepsi 2.5 LT",30,45,2,38));
            Products.Add(new Product(18,"Nescafe 200 Gram Paket",90,110,5,17));
            Products.Add(new Product(99,"Uni-T Multimetre",600,700,1,1));
        }
    }
}
