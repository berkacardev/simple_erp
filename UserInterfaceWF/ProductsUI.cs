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
using UserInterfaceWF.CustomComponents;

namespace UserInterfaceWF
{
    public partial class ProductsUI : Form
    {
        private IProductService ProductService;
        public ProductsUI()
        {
            ProductService = new ProductServiceImpl();
            InitializeComponent();
            btnInsertProduct.Hide();
            btnDeleteProduct.Hide();
            btnCreateNewProduct.Hide();
        }

        private void ProductsUI_Load(object sender, EventArgs e)
        {
            ProductService.GetProducts().ForEach(p =>
            {
                ListViewItem listViewItem = new CustomListviewItem();
                listViewItem.Tag = p;
                listViewItem.Text = p.ToString();
                lstViewProducts.Items.Add(listViewItem);
            });
        }

        private void lstViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem listViewItem = (ListViewItem)lstViewProducts.SelectedItem;
            var item = (ProductModel)listViewItem.Tag;
            if (item != null)
            {
                ShowProductDetail(item);
                btnInsertProduct.Show();
                btnDeleteProduct.Show();
                btnCreateNewProduct.Show();
            }
        }
        private void ShowProductDetail(ProductModel productModel)
        {
            txtProductId.Text = productModel.ProductId.ToString();
            txtProductName.Text = productModel.ProductName.ToString();
            txtProductPurchasePrice.Text = productModel.ProductPurchasePrice.ToString();
            txtProductSalesPrice.Text = productModel.ProductSalesPrice.ToString();
            txtProductFirstStockQuantity.Text = productModel.ProductFirstStockQuantity.ToString();
            lblProductLastStockQuantity.Text = productModel.ProductLastStockQuantity.ToString();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new ProductModel(-1, txtProductName.Text, txtProductPurchasePrice.Text, txtProductSalesPrice.Text, txtProductFirstStockQuantity.Text, txtProductFirstStockQuantity.Text);
                var result = ProductService.CreateProduct(item);
                ListViewItem listViewItem = new CustomListviewItem();
                listViewItem.Tag = result;
                listViewItem.Text = result.ToString();
                lstViewProducts.Items.Add(listViewItem);
                lstViewProducts.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem listViewItem = (ListViewItem)lstViewProducts.SelectedItem;
                var item = (ProductModel)listViewItem.Tag;
                ProductService.DeleteProduct(item);
                RefreshOrLoadCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void RefreshOrLoadCustomerList()
        {
            lstViewProducts.Items.Clear();
            ProductService.GetProducts().ForEach(p =>
            {
                ListViewItem listViewItem = new CustomListviewItem();
                listViewItem.Tag = p;
                listViewItem.Text = p.ToString();
                lstViewProducts.Items.Add(listViewItem);
            });
        }

        private void btnCreateNewProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ShowProductDetail(new ProductModel(-1, "", "", "", "", ""));
                btnInsertProduct.Hide();
                btnDeleteProduct.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem listViewItem = (ListViewItem)lstViewProducts.SelectedItem;
                var item = (ProductModel)listViewItem.Tag;
                item.ProductName = txtProductName.Text;
                item.ProductPurchasePrice = txtProductPurchasePrice.Text;
                item.ProductSalesPrice = txtProductSalesPrice.Text;
                item.ProductFirstStockQuantity = txtProductFirstStockQuantity.Text;
                var result = ProductService.InsertProduct(item);
                ShowProductDetail(result);
                int selectedIndex = lstViewProducts.SelectedIndex;
                RefreshOrLoadCustomerList();
                lstViewProducts.SelectedIndex = selectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
