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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void picButtonProductsForm_Click(object sender, EventArgs e)
        {
            OpenProductsUIFormOnTabControl();
        }

        private void picButtonCustomersForm_Click(object sender, EventArgs e)
        {
            OpenCustomersUIFormOnTabControl();
        }

        private void picButtonSalesForm_Click(object sender, EventArgs e)
        {
            OpenSalesUIFormOnTabControl();
        }

        private void OpenProductsUIFormOnTabControl()
        {
            ProductsUI productsUI = (ProductsUI)Application.OpenForms["ProductsUI"];
            if (productsUI == null)
            {
                productsUI = new ProductsUI();
                tabControl.TabPages.Add(productsUI);
            }
            else
            {
                tabControl.TabPages[productsUI].Select();
            }
        }

        private void OpenCustomersUIFormOnTabControl()
        {
            CustomersUI customersUI = (CustomersUI)Application.OpenForms["CustomersUI"];
            if (customersUI == null)
            {
                customersUI = new CustomersUI();
                tabControl.TabPages.Add(customersUI);
            }
            else
            {
                tabControl.TabPages[customersUI].Select();
            }
        }
        private void OpenSalesUIFormOnTabControl()
        {
            SalesUI salesUI = (SalesUI)Application.OpenForms["SalesUI"];
            if (salesUI == null)
            {
                salesUI = new SalesUI();
                tabControl.TabPages.Add(salesUI);
            }
            else
            {
                tabControl.TabPages[salesUI].Select();
            }
        }
    }
}
