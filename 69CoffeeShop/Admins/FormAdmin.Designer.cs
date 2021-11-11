
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInventories = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnEmployee = new FontAwesome.Sharp.IconButton();
            this.btnSupplier = new FontAwesome.Sharp.IconButton();
            this.iconButtonUser = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnBackup = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(165, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(547, 529);
            this.panelDesktop.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.panelMenu.Controls.Add(this.btnBackup);
            this.panelMenu.Controls.Add(this.btnInventories);
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.btnEmployee);
            this.panelMenu.Controls.Add(this.btnSupplier);
            this.panelMenu.Controls.Add(this.iconButtonUser);
            this.panelMenu.Controls.Add(this.btnProduct);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 529);
            this.panelMenu.TabIndex = 3;
            // 
            // btnInventories
            // 
            this.btnInventories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.btnInventories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventories.FlatAppearance.BorderSize = 0;
            this.btnInventories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventories.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnInventories.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.btnInventories.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnInventories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventories.Location = new System.Drawing.Point(0, 310);
            this.btnInventories.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventories.Name = "btnInventories";
            this.btnInventories.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnInventories.Size = new System.Drawing.Size(165, 49);
            this.btnInventories.TabIndex = 14;
            this.btnInventories.Text = "Inventories";
            this.btnInventories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventories.UseVisualStyleBackColor = false;
            this.btnInventories.Click += new System.EventHandler(this.btnInventories_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnReport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 261);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnReport.Size = new System.Drawing.Size(165, 49);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnEmployee.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnEmployee.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 212);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnEmployee.Size = new System.Drawing.Size(165, 49);
            this.btnEmployee.TabIndex = 12;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployees_Click_1);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnSupplier.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.btnSupplier.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnSupplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(0, 163);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnSupplier.Size = new System.Drawing.Size(165, 49);
            this.btnSupplier.TabIndex = 11;
            this.btnSupplier.Text = "Suppliers";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSuppliers_Click_1);
            // 
            // iconButtonUser
            // 
            this.iconButtonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.iconButtonUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonUser.FlatAppearance.BorderSize = 0;
            this.iconButtonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUser.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.iconButtonUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButtonUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.iconButtonUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUser.Location = new System.Drawing.Point(0, 480);
            this.iconButtonUser.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonUser.Name = "iconButtonUser";
            this.iconButtonUser.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconButtonUser.Size = new System.Drawing.Size(165, 49);
            this.iconButtonUser.TabIndex = 8;
            this.iconButtonUser.Text = "User";
            this.iconButtonUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUser.UseVisualStyleBackColor = false;
            this.iconButtonUser.Click += new System.EventHandler(this.iconButtonUser_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.btnProduct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 114);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnProduct.Size = new System.Drawing.Size(165, 49);
            this.btnProduct.TabIndex = 10;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 114);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Image = global::_69CoffeeShop.Properties.Resources.admin1;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 101);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnBackup.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnBackup.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.btnBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(0, 359);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnBackup.Size = new System.Drawing.Size(165, 49);
            this.btnBackup.TabIndex = 15;
            this.btnBackup.Text = "Backup / Restore";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 529);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton iconButtonUser;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnInventories;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnEmployee;
        private FontAwesome.Sharp.IconButton btnSupplier;
        private FontAwesome.Sharp.IconButton btnBackup;
    }
}