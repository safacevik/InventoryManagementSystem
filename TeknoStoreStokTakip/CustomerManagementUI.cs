using BL;
using Entities;
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
    public partial class CustomerManagementUI : Form
    {
        public CustomerManagementUI()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager();

        void load()
        {
            dgvCustomer.DataSource = customerManager.GetAll();
        }

        void Clear()
        {
            tbCustomerName.Text = string.Empty;
            tbCustomerSurname.Text = string.Empty;
            tbCustomerEmail.Text = string.Empty;
            tbCustomerPhoneNum.Text = string.Empty;
            rtbCustomerAddress.Text = string.Empty;
            lblId.Text = "0";
        }

        private void CustomerManagementUI_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbCustomerName.Text) || string.IsNullOrWhiteSpace(tbCustomerSurname.Text))
                {
                    MessageBox.Show("Please fill in the fields marked with '*'!");
                }
                else
                {
                    var result = customerManager.Add
                    (
                        new Customer
                        {
                            Name = tbCustomerName.Text,
                            Surname = tbCustomerSurname.Text,
                            Email = tbCustomerEmail.Text,
                            PhoneNum = tbCustomerPhoneNum.Text,
                            Address = rtbCustomerAddress.Text
                        }
                    );
                    if (result > 0)
                    {
                        Clear();
                        load();
                        MessageBox.Show("Registry Added!");
                    }
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
                    MessageBox.Show("Please select a registry from the list to delete!");
                }
                else
                {
                    var result = customerManager.Delete(Convert.ToInt32(lblId.Text));

                    if (result > 0)
                    {
                        Clear();
                        load();
                        MessageBox.Show("Registry Deleted!");
                    }
                    else MessageBox.Show("Failed to delete the registry!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\n> " + ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbCustomerName.Text) || string.IsNullOrWhiteSpace(tbCustomerSurname.Text))
                {
                    MessageBox.Show("Please fill in the fields marked with '*'!");
                }
                else
                {
                    if (lblId.Text == "0")
                    {
                        MessageBox.Show("Please select a registry from the list to update!");
                    }
                    else
                    {
                        var result = customerManager.Update
                        (
                            new Customer
                            {
                                Id = Convert.ToInt32(lblId.Text),
                                Name = tbCustomerName.Text,
                                Surname = tbCustomerSurname.Text,
                                Email = tbCustomerEmail.Text,
                                PhoneNum = tbCustomerPhoneNum.Text,
                                Address = rtbCustomerAddress.Text
                            }
                        );
                        if (result > 0)
                        {
                            Clear();
                            load();
                            MessageBox.Show("Registry Updated!");
                        }
                    }
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

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
                tbCustomerName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                tbCustomerSurname.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
                tbCustomerEmail.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
                tbCustomerPhoneNum.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
                rtbCustomerAddress.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\n> " + ex);
            }
        }

        private void label7_Click(object sender, EventArgs e) // close button
        {
            Application.Exit();
        }
    }
}
