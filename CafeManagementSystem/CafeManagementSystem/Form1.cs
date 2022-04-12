using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "irtiza" || txtPassword.Text == "admin")
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();    
            }
        }
    }
}
