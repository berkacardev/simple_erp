using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ISalesService
    {
        ProductModel GetProduct(string id);

        double GetTemperarySalesPrice();
        void CreateTemperarySales();
        void AddProductTemperarySalesChart(ProductModel product);
        List<SalesModel> GetAllSales();
        void MakeSalesAsPermanent(CustomerModel customer);
    }
}
