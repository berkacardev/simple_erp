using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SalesModel
    {
        public SalesModel(int SalesId, List<ProductModel> Products,double SalesSum, CustomerModel Customer, DateTime SalesDateTime)
        {
            this.SalesId = SalesId;
            this.Products = Products;
            this.SalesSum = SalesSum;
            this.Customer = Customer;
            this.SalesDateTime = SalesDateTime;
        }
        public int SalesId;
        public List<ProductModel> Products { get; set; }
        public double SalesSum { get; set; }
        public CustomerModel Customer { get; set; }
        public DateTime SalesDateTime { get; set; }

        public override string ToString()
        {
            return "Satış Numarası: " + SalesId + " Satış Miktarı: "+SalesSum+ " Satış Tarihi: "+SalesDateTime.ToString();
        }
    }
}
