using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sales : BaseEntity
    {
        public Sales(int Id, List<Product> Product, Customer Customer, double SalesSum, DateTime SalesDateTime)
        {
            base.Id = Id;
            this.Product = Product;
            this.Customer = Customer;
            this.SalesSum = SalesSum;
            this.SalesDateTime = SalesDateTime;
        }
        public List<Product> Product { get; set; }
        public Customer Customer { get; set; }
        public double SalesSum { get; set; }
        public DateTime SalesDateTime { get; set; }
    }
}
