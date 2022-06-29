
namespace InventoryManagementSystem
{
    partial class HomePageUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbProducts = new System.Windows.Forms.PictureBox();
            this.pbCustomers = new System.Windows.Forms.PictureBox();
            this.pbCategories = new System.Windows.Forms.PictureBox();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.pbOrders = new System.Windows.Forms.PictureBox();
            this.pbBrands = new System.Windows.Forms.PictureBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblBrands = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // pbProducts
            // 
            this.pbProducts.BackColor = System.Drawing.Color.Transparent;
            this.pbProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbProducts.Image = ((System.Drawing.Image)(resources.GetObject("pbProducts.Image")));
            this.pbProducts.Location = new System.Drawing.Point(26, 86);
            this.pbProducts.Name = "pbProducts";
            this.pbProducts.Size = new System.Drawing.Size(83, 89);
            this.pbProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProducts.TabIndex = 1;
            this.pbProducts.TabStop = false;
            this.pbProducts.Click += new System.EventHandler(this.pbProducts_Click);
            // 
            // pbCustomers
            // 
            this.pbCustomers.BackColor = System.Drawing.Color.Transparent;
            this.pbCustomers.Image = ((System.Drawing.Image)(resources.GetObject("pbCustomers.Image")));
            this.pbCustomers.Location = new System.Drawing.Point(26, 293);
            this.pbCustomers.Name = "pbCustomers";
            this.pbCustomers.Size = new System.Drawing.Size(83, 89);
            this.pbCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCustomers.TabIndex = 1;
            this.pbCustomers.TabStop = false;
            this.pbCustomers.Click += new System.EventHandler(this.pbCustomers_Click);
            // 
            // pbCategories
            // 
            this.pbCategories.BackColor = System.Drawing.Color.Transparent;
            this.pbCategories.Image = ((System.Drawing.Image)(resources.GetObject("pbCategories.Image")));
            this.pbCategories.Location = new System.Drawing.Point(255, 168);
            this.pbCategories.Name = "pbCategories";
            this.pbCategories.Size = new System.Drawing.Size(83, 89);
            this.pbCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCategories.TabIndex = 1;
            this.pbCategories.TabStop = false;
            this.pbCategories.Click += new System.EventHandler(this.pbCategories_Click);
            // 
            // pbUsers
            // 
            this.pbUsers.BackColor = System.Drawing.Color.Transparent;
            this.pbUsers.Image = ((System.Drawing.Image)(resources.GetObject("pbUsers.Image")));
            this.pbUsers.Location = new System.Drawing.Point(478, 168);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(83, 89);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsers.TabIndex = 1;
            this.pbUsers.TabStop = false;
            this.pbUsers.Click += new System.EventHandler(this.pbUsers_Click);
            // 
            // pbOrders
            // 
            this.pbOrders.BackColor = System.Drawing.Color.Transparent;
            this.pbOrders.Image = ((System.Drawing.Image)(resources.GetObject("pbOrders.Image")));
            this.pbOrders.Location = new System.Drawing.Point(685, 86);
            this.pbOrders.Name = "pbOrders";
            this.pbOrders.Size = new System.Drawing.Size(83, 89);
            this.pbOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOrders.TabIndex = 1;
            this.pbOrders.TabStop = false;
            this.pbOrders.Click += new System.EventHandler(this.pbOrders_Click);
            // 
            // pbBrands
            // 
            this.pbBrands.BackColor = System.Drawing.Color.Transparent;
            this.pbBrands.Image = ((System.Drawing.Image)(resources.GetObject("pbBrands.Image")));
            this.pbBrands.Location = new System.Drawing.Point(685, 293);
            this.pbBrands.Name = "pbBrands";
            this.pbBrands.Size = new System.Drawing.Size(83, 89);
            this.pbBrands.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBrands.TabIndex = 1;
            this.pbBrands.TabStop = false;
            this.pbBrands.Click += new System.EventHandler(this.pbBrands_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblProducts.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.Transparent;
            this.lblProducts.Location = new System.Drawing.Point(39, 178);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(70, 22);
            this.lblProducts.TabIndex = 2;
            this.lblProducts.Text = "Products";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomers.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.Color.Transparent;
            this.lblCustomers.Location = new System.Drawing.Point(29, 385);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(80, 22);
            this.lblCustomers.TabIndex = 2;
            this.lblCustomers.Text = "Customers";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.Transparent;
            this.lblCategories.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.Color.Transparent;
            this.lblCategories.Location = new System.Drawing.Point(257, 260);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(81, 22);
            this.lblCategories.TabIndex = 2;
            this.lblCategories.Text = "Categories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(497, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Users";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblOrders.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.ForeColor = System.Drawing.Color.Transparent;
            this.lblOrders.Location = new System.Drawing.Point(698, 178);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(54, 22);
            this.lblOrders.TabIndex = 2;
            this.lblOrders.Text = "Orders";
            this.lblOrders.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.BackColor = System.Drawing.Color.Transparent;
            this.lblBrands.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrands.ForeColor = System.Drawing.Color.Transparent;
            this.lblBrands.Location = new System.Drawing.Point(698, 385);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(58, 22);
            this.lblBrands.TabIndex = 2;
            this.lblBrands.Text = "Brands";
            this.lblBrands.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Location = new System.Drawing.Point(341, 357);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(116, 50);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // HomePageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblBrands);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.pbBrands);
            this.Controls.Add(this.pbOrders);
            this.Controls.Add(this.pbUsers);
            this.Controls.Add(this.pbCategories);
            this.Controls.Add(this.pbCustomers);
            this.Controls.Add(this.pbProducts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePageUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePageUI_FormClosed);
            this.Load += new System.EventHandler(this.HomePageUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbProducts;
        private System.Windows.Forms.PictureBox pbCustomers;
        private System.Windows.Forms.PictureBox pbCategories;
        private System.Windows.Forms.PictureBox pbUsers;
        private System.Windows.Forms.PictureBox pbOrders;
        private System.Windows.Forms.PictureBox pbBrands;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblBrands;
        private System.Windows.Forms.Button btnLogOut;
    }
}