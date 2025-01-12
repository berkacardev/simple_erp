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
using Utility.Exceptions;

namespace UserInterfaceWF
{
    public partial class SalesUI : Form
    {
        ISalesService SalesService;
        ICustomerService CustomerService;
        public SalesUI()
        {
            SalesService = new SalesServiceImpl();
            CustomerService = new CustomerServiceImpl();
            InitializeComponent();
            SalesService.CreateTemperarySales();
            
            CustomerService.GetCustomers().ForEach(u=> cmbxCustomers.Items.Add(u));


            dtGridView.ColumnCount = 2;
            dtGridView.Columns[0].Name = "Ürün Adı";
            dtGridView.Columns[1].Name = "Fiyat";
            dtGridView.Columns[0].Width = 520;
            dtGridView.Columns[1].Width = 110;
        }

        ProductModel selectedProduct = null;
        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            if (txtProductId.Text == String.Empty)
            {
                selectedProduct = null;
                ShowProductDetail(selectedProduct);
            }
            try
            {
                selectedProduct = SalesService.GetProduct(txtProductId.Text);
                ShowProductDetail(selectedProduct);
            }
            catch (ProductIdIsNotNumericException ex)
            {
                if (txtProductId.Text != String.Empty)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (ProductIsNotFoundException ex)
            {
                ShowProductDetail(null);
            }
        }
        private void ShowProductDetail(ProductModel productModel)
        {
            if (productModel == null)
            {
                ShowProductDetail(new ProductModel(0, "", "", "", "", ""));
            }
            else
            {
                lblProductName.Text = productModel.ProductName;
                lblProductPrice.Text = productModel.ProductSalesPrice + " TL";
            }
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                int i = dtGridView.Rows.Add();
                dtGridView.Rows[i].Cells[0].Value = selectedProduct.ProductName;
                dtGridView.Rows[i].Cells[1].Value = selectedProduct.ProductSalesPrice;
                SalesService.AddProductTemperarySalesChart(selectedProduct);
                lblSalesSum.Text = SalesService.GetTemperarySalesPrice().ToString() + "TL";
            }

        }

        private void btnMakePermananetSales_Click(object sender, EventArgs e)
        {
            CustomerModel customerModel = cmbxCustomers.SelectedItem as CustomerModel;
            SalesService.MakeSalesAsPermanent(customerModel);
            txtProductId.Enabled = false;
            MessageBox.Show("Satış başarılı bir şekilde ypaıldı");
        }
    }
}
