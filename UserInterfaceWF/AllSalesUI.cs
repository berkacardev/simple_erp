using Model;
using Service;
using Service.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceWF
{
    public partial class AllSalesUI : Form
    {
        private ISalesService SalesService;
        public AllSalesUI()
        {
            SalesService = new SalesServiceImpl();
            InitializeComponent();
        }

        private void AllSalesUI_Load(object sender, EventArgs e)
        {
            SalesService.GetAllSales().ForEach(u => lstBoxSales.Items.Add(u));
        }

        private void ShowCustomerInfo(CustomerModel customerModel)
        {
            lblCustomerNameSurname.Text = customerModel.CustomerName + " " + customerModel.CustomerSurname;
            lblCustomerPhoneNumber.Text = customerModel.CustomerPhoneNumber;
            lblCustomerAddress.Text = customerModel.CustomerAdress;
        }

        private void lstBoxSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalesModel selectedSales = lstBoxSales.SelectedItem as SalesModel;
            ShowCustomerInfo(selectedSales.Customer);
            lstBoxSelledProducts.Items.Clear();
            selectedSales.Products.ForEach(u => lstBoxSelledProducts.Items.Add(u));
            lblSalesSum.Text = selectedSales.SalesSum.ToString() + " TL";
        }
    }
}
