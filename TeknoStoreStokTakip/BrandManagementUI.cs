using System;
using System.Windows.Forms;
using BL;
using Entities;

namespace InventoryManagementSystem
{
    public partial class BrandManagementUI : Form
    {
        public BrandManagementUI()
        {
            InitializeComponent();
        }

        BrandManager brandManager = new BrandManager();
        public static int BrandId = 0;

        void load()
        {
            dgvBrand.DataSource = brandManager.GetAll();
        }

        void Clear()
        {
            rtbBrandDescription.Text = string.Empty;
            tbBrandName.Text = string.Empty;
            lblId.Text = "0";
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BrandManagementUI_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int result = brandManager.Add
                (
                    new Brand
                    {
                        BrandName = tbBrandName.Text,
                        BrandDescription = rtbBrandDescription.Text,
                        UploadDate = dtpBrandUploadDate.Value
                    }
                );

                if (result > 0)
                {
                    MessageBox.Show("Registration Successfully Added.");
                    Clear();
                    load();
                }
                else
                {
                    MessageBox.Show("Cannot Add Registration, Please Check Your Entry.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\n> " + ex.StackTrace);
            }
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            load();
        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgvBrand.CurrentRow.Cells[0].Value.ToString();
            tbBrandName.Text = dgvBrand.CurrentRow.Cells[1].Value.ToString();
            rtbBrandDescription.Text = dgvBrand.CurrentRow.Cells[2].Value.ToString();
            dtpBrandUploadDate.Value = (DateTime)dgvBrand.CurrentRow.Cells[3].Value;

            //try
            //{
            //    BrandId = int.Parse(dgvBrand.CurrentRow.Cells[0].Value.ToString());
            //    var brand = brandManager.Get(BrandId);

            //    if (brand != null)
            //    {
            //        BrandId = brand.Id;
            //        tbBrandName.Text = brand.BrandName;
            //        rtbBrandDescription.Text = brand.BrandDescription;
            //        dtpBrandUploadDate.Value = brand.UploadDate;

            //        btnAdd.Enabled = false;
            //        btnUpdate.Enabled = true;
            //        btnDelete.Enabled = true;

            //        this.FindForm().AcceptButton = btnUpdate;
            //    }
            //    //else Clear();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An Error Occured!\n> " + ex.StackTrace);
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);

            if (id > 0)
            {
                int result = brandManager.Update
                (
                    new Brand
                    {
                        Id = id,
                        BrandName = tbBrandName.Text,
                        BrandDescription = rtbBrandDescription.Text,
                        UploadDate = dtpBrandUploadDate.Value
                    }
                );

                if (result > 0)
                {
                    Clear();
                    load();
                    MessageBox.Show("Registry Successfully Updated.");
                }
                else MessageBox.Show("Registry Update Failed!");
            }
            else MessageBox.Show("Please Select a Registry to Update!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);

            if (id > 0)
            {
                if (MessageBox.Show("Are you sure that you want to delete registry?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int islemSonucu = brandManager.Delete(id);
                    if (islemSonucu > 0)
                    {
                        Clear();
                        load();
                        MessageBox.Show("Registry Deleted.");
                    }
                    else MessageBox.Show("Failed to Delete Registry!");
                }

            }
            else MessageBox.Show("Please Select a Registry to Delete!");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePageUI home = new HomePageUI();
            home.Show();
            this.Hide();
        }
    }
}
