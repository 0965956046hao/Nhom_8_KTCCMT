using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = txtUserName.Text;
            password = txtpassword.Text;

            if (username == "admin" && password == "admin")
            {
                Login login = new Login();
                txtUserName.Text = "";
                txtpassword.Text = "";
                login.Show();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }
    }
}
