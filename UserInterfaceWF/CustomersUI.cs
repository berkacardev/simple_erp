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
    public partial class CustomersUI : Form
    {
        private ICustomerService CustomerService;
        public CustomersUI()
        {
            CustomerService = new CustomerServiceImpl();
            InitializeComponent();
            btnInsertCustomer.Hide();
            btnDeleteCustomer.Hide();
            btnCreateNewCustomer.Hide();
        }

        private void CustomersUI_Load(object sender, EventArgs e)
        {
            RefreshOrLoadCustomerList();
        }
        private void ShowCustomerDetail(CustomerModel customerModel)
        {
            txtCustomerName.Text = customerModel.CustomerName.ToString();
            txtCustomerSurname.Text = customerModel.CustomerSurname.ToString();
            txtCustomerPhoneNumber.Text = customerModel.CustomerPhoneNumber.ToString();
            txtCustomerEmailAdress.Text = customerModel.CustomerEmailAdress.ToString();
            txtCustomerAdress.Text = customerModel.CustomerAdress.ToString();

        }

        private void lstViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem listViewItem = (ListViewItem)lstViewCustomers.SelectedItem;
            var item = (CustomerModel)listViewItem.Tag;
            if (item != null)
            {
                ShowCustomerDetail(item);
                btnInsertCustomer.Show();
                btnDeleteCustomer.Show();
                btnCreateNewCustomer.Show();
            }
        }

        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                ShowCustomerDetail(new CustomerModel(-1, "", "", "", "", ""));
                btnInsertCustomer.Hide();
                btnDeleteCustomer.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new CustomerModel(-1, txtCustomerName.Text, txtCustomerSurname.Text, txtCustomerPhoneNumber.Text, txtCustomerEmailAdress.Text, txtCustomerAdress.Text);
                var result = CustomerService.CreateCustomer(item);
                ListViewItem listViewItem = new CustomListviewItem();
                listViewItem.Tag = result;
                listViewItem.Text = result.ToString();
                lstViewCustomers.Items.Add(listViewItem);
                lstViewCustomers.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem listViewItem = (ListViewItem)lstViewCustomers.SelectedItem;
                var item = (CustomerModel)listViewItem.Tag;
                CustomerService.DeleteCustomer(item);
                RefreshOrLoadCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem listViewItem = (ListViewItem)lstViewCustomers.SelectedItem;
                var item = (CustomerModel)listViewItem.Tag;
                item.CustomerName = txtCustomerName.Text;
                item.CustomerSurname = txtCustomerSurname.Text;
                item.CustomerPhoneNumber = txtCustomerPhoneNumber.Text;
                item.CustomerEmailAdress = txtCustomerEmailAdress.Text;
                item.CustomerAdress = txtCustomerAdress.Text;
                var result = CustomerService.InsertCustomer(item);
                ShowCustomerDetail(result);
                int selectedIndex = lstViewCustomers.SelectedIndex;
                RefreshOrLoadCustomerList();
                lstViewCustomers.SelectedIndex = selectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RefreshOrLoadCustomerList()
        {
            lstViewCustomers.Items.Clear();
            CustomerService.GetCustomers().ForEach(p =>
            {
                ListViewItem listViewItem = new CustomListviewItem();
                listViewItem.Tag = p;
                listViewItem.Text = p.ToString();
                lstViewCustomers.Items.Add(listViewItem);
            });
        }
    }
}
