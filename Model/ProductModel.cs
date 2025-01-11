using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float ProductPurchasePrice { get; set; }
        public float ProductSalesPrice { get; set; }
        public float ProductProfit { get; set; }
        public int ProductFirstStockQuantity { get; set; }
        public int ProductLastStockQuantity { get; set; }

    }
}
