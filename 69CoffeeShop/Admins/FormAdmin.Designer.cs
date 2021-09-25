
namespace _69CoffeeShop.Forms
{
    partial class FormAdmin
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButtonUser = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnInventories = new FontAwesome.Sharp.IconButton();
            this.btnEmployees = new FontAwesome.Sharp.IconButton();
            this.btnSuppliers = new FontAwesome.Sharp.IconButton();
            this.panelDesktop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.panelDesktop.Controls.Add(this.lblAdminName);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(165, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(547, 529);
            this.panelDesktop.TabIndex = 5;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAdminName.Location = new System.Drawing.Point(339, 23);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(222, 30);
            this.lblAdminName.TabIndex = 0;
            this.lblAdminName.Text = "Hi, Sam Chun Hang";
            this.lblAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.iconButtonUser);
            this.panelMenu.Controls.Add(this.btnProduct);
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnInventories);
            this.panelMenu.Controls.Add(this.btnEmployees);
            this.panelMenu.Controls.Add(this.btnSuppliers);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 529);
            this.panelMenu.TabIndex = 3;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(-2, 362);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconButton2.Size = new System.Drawing.Size(165, 49);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.Text = "Backup / Restore";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButtonUser
            // 
            this.iconButtonUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonUser.FlatAppearance.BorderSize = 0;
            this.iconButtonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUser.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.iconButtonUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButtonUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.iconButtonUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUser.Location = new System.Drawing.Point(0, 480);
            this.iconButtonUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButtonUser.Name = "iconButtonUser";
            this.iconButtonUser.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconButtonUser.Size = new System.Drawing.Size(165, 49);
            this.iconButtonUser.TabIndex = 8;
            this.iconButtonUser.Text = "User";
            this.iconButtonUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUser.UseVisualStyleBackColor = true;
            this.iconButtonUser.Click += new System.EventHandler(this.iconButtonUser_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.btnProduct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 114);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnProduct.Size = new System.Drawing.Size(165, 49);
            this.btnProduct.TabIndex = 10;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnReport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(-2, 314);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnReport.Size = new System.Drawing.Size(165, 49);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 114);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Image = global::_69CoffeeShop.Properties.Resources.admin;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 101);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnInventories
            // 
            this.btnInventories.FlatAppearance.BorderSize = 0;
            this.btnInventories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventories.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnInventories.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.btnInventories.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnInventories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventories.Location = new System.Drawing.Point(0, 162);
            this.btnInventories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventories.Name = "btnInventories";
            this.btnInventories.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnInventories.Size = new System.Drawing.Size(165, 49);
            this.btnInventories.TabIndex = 4;
            this.btnInventories.Text = "Inventories";
            this.btnInventories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventories.UseVisualStyleBackColor = true;
            this.btnInventories.Click += new System.EventHandler(this.btnInventories_Click_1);
            // 
            // btnEmployees
            // 
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnEmployees.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnEmployees.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(-2, 265);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnEmployees.Size = new System.Drawing.Size(165, 49);
            this.btnEmployees.TabIndex = 6;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click_1);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnSuppliers.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.btnSuppliers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnSuppliers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.Location = new System.Drawing.Point(-2, 216);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnSuppliers.Size = new System.Drawing.Size(165, 49);
            this.btnSuppliers.TabIndex = 5;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click_1);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 529);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnEmployees;
        private FontAwesome.Sharp.IconButton btnSuppliers;
        private FontAwesome.Sharp.IconButton btnInventories;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblAdminName;
        private FontAwesome.Sharp.IconButton iconButtonUser;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnProduct;
    }
}