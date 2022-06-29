using BL;
using Entities;
using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class OrderManagementUI : Form
    {
        public OrderManagementUI()
        {
            InitializeComponent();
        }

        OrderManager orderManager = new OrderManager();
        CustomerManager customerManager = new CustomerManager();
        ProductManager productManager = new ProductManager();

        void load()
        {
            dgvOrder.DataSource = orderManager.GetAll();
            cbCustomerOrder.DataSource = customerManager.GetAll();
            cbCustomerOrder.DisplayMember = "Name";
            cbCustomerOrder.ValueMember = "Id";
            cbProductOrder.DataSource = productManager.GetAll();
            cbProductOrder.DisplayMember = "ProductName";
            cbProductOrder.ValueMember = "Id";
            dgvOrder.Columns.Remove("Product");
            dgvOrder.Columns.Remove("Customer");
        }

        void Clear()
        {
            tbOrderNum.Text = string.Empty;
            lblId.Text = "0";
        }

        private void OrderManagementUI_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var result = orderManager.Add
                (
                    new Order
                    {
                        CustomerId = Convert.ToInt32(cbCustomerOrder.SelectedValue),
                        OrderNum = tbOrderNum.Text,
                        OrderQuantity = Convert.ToInt32(tbQuantity.Text),
                        OrderDate = dtpOrderDate.Value,
                        ProductId = Convert.ToInt32(cbProductOrder.SelectedValue)
                    }
                );

                if (result > 0)
                {
                    load();
                    Clear();
                    MessageBox.Show("Registry Added!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\n> " + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Please select a registry to delete!");
                }
                else
                {
                    var result = orderManager.Delete(Convert.ToInt32(lblId.Text));

                    if (result > 0)
                    {
                        load();
                        Clear();
                        MessageBox.Show("Kayıt Silindi!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Silinemedi!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var result = orderManager.Update
                    (
                    new Order
                    {
                        Id = Convert.ToInt32(lblId.Text),
                        CustomerId = Convert.ToInt32(cbCustomerOrder.SelectedValue),
                        OrderNum = tbOrderNum.Text,
                        OrderQuantity = Convert.ToInt32(tbQuantity.Text),
                        OrderDate = dtpOrderDate.Value,
                        ProductId = Convert.ToInt32(cbProductOrder.SelectedValue)
                    }
                    );
                    if (result > 0)
                    {
                        load();
                        Clear();
                        MessageBox.Show("Registry Updated!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a registry to update!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\n> " + ex);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePageUI home = new HomePageUI();
            home.Show();
            this.Hide();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var order = orderManager.Get(Convert.ToInt32(dgvOrder.CurrentRow.Cells[0].Value));
                tbOrderNum.Text = order.OrderNum;
                cbCustomerOrder.SelectedValue = order.CustomerId;
                cbProductOrder.SelectedValue = order.ProductId;
                tbQuantity.Text = order.OrderQuantity.ToString();
                dtpOrderDate.Value = order.OrderDate;
                lblId.Text = dgvOrder.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\n> " + ex);
            }
        }

        private void label2_Click(object sender, EventArgs e) // close button
        {
            Application.Exit();
        }
    }
}
