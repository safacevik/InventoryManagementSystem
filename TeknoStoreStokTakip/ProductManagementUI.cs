using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entities;

namespace InventoryManagementSystem
{
    public partial class ProductManagementUI : Form
    {
        public ProductManagementUI()
        {
            InitializeComponent();
        }

        ProductManager productManager = new ProductManager();
        CategoryManager categoryManager = new CategoryManager();
        BrandManager brandManager = new BrandManager();

        private void button4_Click(object sender, EventArgs e) // home button
        {
            HomePageUI home = new HomePageUI();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e) // close button
        {
            Application.Exit();
        }

        void load()
        {
            //dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = productManager.GetAll();
            cbProductCategory.DataSource = categoryManager.GetAll();
            cbBrand.DataSource = brandManager.GetAll();
            dgvProduct.Columns.Remove("Category");
            dgvProduct.Columns.Remove("Brand");
        }

        void Clear()
        {
            tbDiscount.Text = string.Empty;
            tbTax.Text = string.Empty;
            tbQuantity.Text = string.Empty;
            tbProductName.Text = string.Empty;
            tbPrice.Text = string.Empty;
            rtbDescription.Text = string.Empty;
            lblId.Text = "0";
        }

        private void ProductManagementUI_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbPrice.Text))
            {
                try
                {
                    var result = productManager.Add
                    (
                        new Product
                        {
                            ProductName = tbProductName.Text,
                            Price = decimal.Parse(tbPrice.Text),
                            Description = rtbDescription.Text,
                            UploadDate = dtpProductUploadDate.Value,
                            Discount = decimal.Parse(tbDiscount.Text),
                            Tax = decimal.Parse(tbTax.Text),
                            Quantity = int.Parse(tbQuantity.Text),
                            WholesalePrice = decimal.Parse(tbPrice.Text),
                            CategoryId = int.Parse(cbProductCategory.SelectedValue.ToString()),
                            BrandId = int.Parse(cbBrand.SelectedValue.ToString())
                        }
                    );

                    if (result > 0)
                    {
                        Clear();
                        load();
                        MessageBox.Show("Registry Successfully Added!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured!\n> " + ex);
                }
            }
            else MessageBox.Show("Price of the product must be written!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Please Select a Product From the List!");
                }
                else
                {
                    var result = productManager.Delete(int.Parse(lblId.Text));
                    if (result > 0)
                    {
                        Clear();
                        load();
                        MessageBox.Show("Registry Deleted!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\n> " + ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbPrice.Text))
            {
                try
                {
                    int productId = Convert.ToInt32(lblId.Text);
                    if (productId > 0)
                    {
                        var result = productManager.Update
                        (
                            new Product
                            {
                                Id = productId,
                                ProductName = tbProductName.Text,
                                Price = decimal.Parse(tbPrice.Text),
                                Description = rtbDescription.Text,
                                UploadDate = dtpProductUploadDate.Value,
                                Discount = decimal.Parse(tbDiscount.Text),
                                Tax = decimal.Parse(tbTax.Text),
                                Quantity = int.Parse(tbQuantity.Text),
                                WholesalePrice = decimal.Parse(tbPrice.Text),
                                CategoryId = int.Parse(cbProductCategory.SelectedValue.ToString()),
                                BrandId = int.Parse(cbBrand.SelectedValue.ToString())
                            }
                        );

                        if (result > 0)
                        {
                            Clear();
                            load();
                            MessageBox.Show("Registry Successfully Updated!");
                        }
                    }
                    else MessageBox.Show("Please Select a Product From the List!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured!\n> " + ex);
                }
            }
            else MessageBox.Show("Price of the product must be written!");
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
                int productId = Convert.ToInt32(lblId.Text);

                if (productId > 0)
                {
                    var product = productManager.Get(productId);

                    if (product != null)
                    {
                        tbDiscount.Text = product.Discount.ToString();
                        tbTax.Text = product.Tax.ToString();
                        tbQuantity.Text = product.Quantity.ToString();
                        tbProductName.Text = product.ProductName;
                        tbPrice.Text = product.Price.ToString();
                        rtbDescription.Text = product.Description;
                        dtpProductUploadDate.Value = product.UploadDate.Date;
                        cbProductCategory.SelectedValue = product.CategoryId;
                        cbBrand.SelectedValue = product.BrandId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\n> " + ex);
            }
        }
    }
}
