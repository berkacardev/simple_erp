using Model;
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
    public partial class LoginUI : Form
    {
        private Service.IAuthenticationService authenticationService;
        public LoginUI()
        {
            InitializeComponent();
            authenticationService = new AuthenticationServiceImpl();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword = txtUserPassword.Text;
            try
            {
                var result = authenticationService.Login(new AuthUserModel(userName, userPassword));
                if (result != null)
                {
                    this.Hide();
                    new MainUI().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
