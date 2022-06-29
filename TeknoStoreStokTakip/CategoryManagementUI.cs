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
    public partial class CategoryManagementUI : Form
    {
        CategoryManager categoryManager = new CategoryManager();

        public CategoryManagementUI()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoryManagementUI_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            dgvCategory.DataSource = categoryManager.GetAll();
        }

        void Clear()
        {
            tbCategoryName.Text = string.Empty;
            rtbCategoryDescription.Text = string.Empty;
            lblId.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var result = categoryManager.Add
                (
                    new Category
                    {
                        CategoryName = tbCategoryName.Text,
                        CategoryDescription = rtbCategoryDescription.Text,
                        UploadDate = dtpCategoryUploadDate.Value
                    }
                );

                if (result > 0)
                {
                    Clear();
                    load();
                    MessageBox.Show("Registry Added Successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\n> " + ex);
            }
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
                tbCategoryName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
                rtbCategoryDescription.Text = dgvCategory.CurrentRow.Cells[2].Value.ToString();
                dtpCategoryUploadDate.Value = (DateTime)dgvCategory.CurrentRow.Cells[3].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var result = categoryManager.Update(
                new Category
                {
                    Id = int.Parse(lblId.Text),
                    CategoryName = tbCategoryName.Text,
                    CategoryDescription = rtbCategoryDescription.Text,
                    UploadDate = dtpCategoryUploadDate.Value
                }
                );
                if (result > 0)
                {
                    Clear();
                    load();
                    MessageBox.Show("Registry Updated Successfully.");
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
                    MessageBox.Show("Please Select a Registry to Delete!");
                }
                else
                {
                    var result = categoryManager.Delete(int.Parse(lblId.Text));
                    if (result > 0)
                    {
                        Clear();
                        load();
                        MessageBox.Show("Registry Deleted Successfully!");
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
    }
}
