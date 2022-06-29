using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        UserManager manager = new UserManager();

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '•';
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            tbUserName.Text = "";
            tbPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Username or Password can not be null!");
            }
            else
            {
                var user = manager.Find(k => k.UserName == tbUserName.Text && k.Password == tbPassword.Text);
                if (user != null)
                {
                    HomePageUI home = new HomePageUI();
                    this.Hide();
                    home.Show();
                }
                else MessageBox.Show("Username or Password is Wrong!");
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }
    }
}
