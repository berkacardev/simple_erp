using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product : BaseEntity
    {
        public Product(int id, string productName, double productPurchasePrice, double productSalesPrice, double productProfit, int productFirstStockQuantity, int productLastStockQuantity) : base(id)
        {
            this.ProductName = productName;
            this.ProductPurchasePrice = productPurchasePrice;
            this.ProductSalesPrice = productSalesPrice;
            this.ProductProfit = productProfit;
            this.ProductFirstStockQuantity = productFirstStockQuantity;
            this.ProductLastStockQuantity = productLastStockQuantity;
        }

        public string ProductName { get; set; }
        public double ProductPurchasePrice { get; set; }
        public double ProductSalesPrice { get; set; }
        public double ProductProfit { get; set; }
        public int ProductFirstStockQuantity { get; set; }
        public int ProductLastStockQuantity { get; set; }
    }
}
