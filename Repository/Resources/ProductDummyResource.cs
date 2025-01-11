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
            Products.Add(new Product(1,"CocaCola 2.5 LT",40,60,20,5,25));
            Products.Add(new Product(2,"Pepsi 2.5 LT",30,45,50,2,38));
        }
    }
}
