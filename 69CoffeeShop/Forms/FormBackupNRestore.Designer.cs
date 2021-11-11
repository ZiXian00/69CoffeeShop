
namespace _69CoffeeShop.Forms
{
    partial class FormBackupNRestore
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
            this.iconButtonRestore = new FontAwesome.Sharp.IconButton();
            this.iconButtonBackup = new FontAwesome.Sharp.IconButton();
            this.labelLatestBackup = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonRestore
            // 
            this.iconButtonRestore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonRestore.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRestore.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.iconButtonRestore.IconColor = System.Drawing.Color.Black;
            this.iconButtonRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRestore.Location = new System.Drawing.Point(409, 369);
            this.iconButtonRestore.Name = "iconButtonRestore";
            this.iconButtonRestore.Size = new System.Drawing.Size(168, 49);
            this.iconButtonRestore.TabIndex = 7;
            this.iconButtonRestore.Text = "Restore Backup";
            this.iconButtonRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRestore.UseVisualStyleBackColor = true;
            this.iconButtonRestore.Click += new System.EventHandler(this.iconButtonRestore_Click);
            // 
            // iconButtonBackup
            // 
            this.iconButtonBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonBackup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBackup.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.iconButtonBackup.IconColor = System.Drawing.Color.Black;
            this.iconButtonBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBackup.Location = new System.Drawing.Point(184, 369);
            this.iconButtonBackup.Name = "iconButtonBackup";
            this.iconButtonBackup.Size = new System.Drawing.Size(157, 49);
            this.iconButtonBackup.TabIndex = 6;
            this.iconButtonBackup.Text = "Backup Now";
            this.iconButtonBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBackup.UseVisualStyleBackColor = true;
            this.iconButtonBackup.Click += new System.EventHandler(this.iconButtonBackup_Click);
            // 
            // labelLatestBackup
            // 
            this.labelLatestBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLatestBackup.AutoSize = true;
            this.labelLatestBackup.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestBackup.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLatestBackup.Location = new System.Drawing.Point(177, 290);
            this.labelLatestBackup.Name = "labelLatestBackup";
            this.labelLatestBackup.Size = new System.Drawing.Size(400, 29);
            this.labelLatestBackup.TabIndex = 5;
            this.labelLatestBackup.Text = "Last Backup : 3 July 2021 20:00";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CloudUploadAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 293;
            this.iconPictureBox1.Location = new System.Drawing.Point(137, 58);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(467, 293);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // FormBackupNRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 479);
            this.Controls.Add(this.iconButtonRestore);
            this.Controls.Add(this.iconButtonBackup);
            this.Controls.Add(this.labelLatestBackup);
            this.Controls.Add(this.iconPictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBackupNRestore";
            this.Text = "FormBackupNRestore";
            this.Load += new System.EventHandler(this.FormBackupNRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonRestore;
        private FontAwesome.Sharp.IconButton iconButtonBackup;
        private System.Windows.Forms.Label labelLatestBackup;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}