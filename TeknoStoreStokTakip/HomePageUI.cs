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
    public partial class HomePageUI : Form
    {
        public HomePageUI()
        {
            InitializeComponent();
        }

        private void HomePageUI_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e) // users
        {

        }

        private void pbProducts_Click(object sender, EventArgs e)
        {
            ProductManagementUI pm = new ProductManagementUI();
            pm.Show();
            this.Hide();
        }

        private void pbCustomers_Click(object sender, EventArgs e)
        {
            CustomerManagementUI cm = new CustomerManagementUI();
            cm.Show();
            this.Hide();
        }

        private void pbCategories_Click(object sender, EventArgs e)
        {
            CategoryManagementUI cm = new CategoryManagementUI();
            cm.Show();
            this.Hide();
        }

        private void pbUsers_Click(object sender, EventArgs e)
        {
            UserManagementUI um = new UserManagementUI();
            um.Show();
            this.Hide();
        }

        private void pbOrders_Click(object sender, EventArgs e)
        {
            OrderManagementUI om = new OrderManagementUI();
            om.Show();
            this.Hide();
        }

        private void pbBrands_Click(object sender, EventArgs e)
        {
            BrandManagementUI bm = new BrandManagementUI();
            bm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginUI login = new LoginUI();
            login.Show();
            this.Hide();
        }

        private void HomePageUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
