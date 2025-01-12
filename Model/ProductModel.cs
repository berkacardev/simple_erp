using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductModel
    {
        public ProductModel(int Id, string productName, string productPurchasePrice, string productSalesPrice,string productFirstStockQuantity, string productLastStockQuantity)
        {
            this.ProductId = Id;
            this.ProductName = productName;
            this.ProductPurchasePrice = productPurchasePrice;
            this.ProductSalesPrice = productSalesPrice;
            this.ProductFirstStockQuantity = productFirstStockQuantity;
            this.ProductLastStockQuantity = productLastStockQuantity;
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPurchasePrice { get; set; }
        public string ProductSalesPrice { get; set; }
        public string ProductFirstStockQuantity { get; set; }
        public string ProductLastStockQuantity { get; set; }

        public override string ToString()
        {
            return this.ProductName + " | " + this.ProductSalesPrice;
        }
    }
}
