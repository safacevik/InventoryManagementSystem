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
    public partial class UserManagementUI : Form
    {
        public UserManagementUI()
        {
            InitializeComponent();
        }

        UserManager userManager = new UserManager();

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void load()
        {
            dgvUser.DataSource = userManager.GetAll();
        }

        void Clear()
        {
            tbName.Text = string.Empty;
            tbSurname.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbUserName.Text = string.Empty;
            tbPassword.Text = string.Empty;
            lblId.Text = "0";
            tbPhoneNumber.Text = string.Empty;
        }

        private void UserManagementUI_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var result = userManager.Add
                (
                    new User
                    {
                        UserName = tbUserName.Text,
                        Password = tbPassword.Text,
                        Email = tbEmail.Text,
                        PhoneNumber = tbPhoneNumber.Text,
                        Name = tbName.Text,
                        Surname = tbSurname.Text
                    }
                );

                if (result > 0)
                {
                    Clear();
                    load();
                    MessageBox.Show("Registry Added Successfully!");
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
                var result = userManager.Update
                (
                    new User
                    {
                        Id = int.Parse(lblId.Text),
                        UserName = tbUserName.Text,
                        Password = tbPassword.Text,
                        Email = tbEmail.Text,
                        PhoneNumber = tbPhoneNumber.Text,
                        Name = tbName.Text,
                        Surname = tbSurname.Text
                    }
                );

                if (result > 0)
                {
                    Clear();
                    load();
                    MessageBox.Show("Registry Added Successfully!");
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
                    MessageBox.Show("Please Select a Registry From the List to Delete!");
                }
                else
                {
                    var result = userManager.Delete(int.Parse(lblId.Text));

                    if (result > 0)
                    {
                        Clear();
                        load();
                        MessageBox.Show("Registry Successfully Deleted.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\n> " + ex);
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
                tbUserName.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
                tbPassword.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
                tbEmail.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
                tbPhoneNumber.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
                tbName.Text = dgvUser.CurrentRow.Cells[5].Value.ToString();
                tbSurname.Text = dgvUser.CurrentRow.Cells[6].Value.ToString();
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
    }
}
