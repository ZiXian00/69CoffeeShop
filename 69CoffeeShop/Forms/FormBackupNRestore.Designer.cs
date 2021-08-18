
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonRestore
            // 
            this.iconButtonRestore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRestore.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.iconButtonRestore.IconColor = System.Drawing.Color.Black;
            this.iconButtonRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRestore.Location = new System.Drawing.Point(464, 454);
            this.iconButtonRestore.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonRestore.Name = "iconButtonRestore";
            this.iconButtonRestore.Size = new System.Drawing.Size(209, 60);
            this.iconButtonRestore.TabIndex = 7;
            this.iconButtonRestore.Text = "Restore Backup";
            this.iconButtonRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRestore.UseVisualStyleBackColor = true;
            // 
            // iconButtonBackup
            // 
            this.iconButtonBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBackup.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.iconButtonBackup.IconColor = System.Drawing.Color.Black;
            this.iconButtonBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBackup.Location = new System.Drawing.Point(246, 454);
            this.iconButtonBackup.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonBackup.Name = "iconButtonBackup";
            this.iconButtonBackup.Size = new System.Drawing.Size(209, 60);
            this.iconButtonBackup.TabIndex = 6;
            this.iconButtonBackup.Text = "Backup Now";
            this.iconButtonBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBackup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(236, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last Backup : 3 July 2021 20:00";
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
            this.iconPictureBox1.IconSize = 361;
            this.iconPictureBox1.Location = new System.Drawing.Point(166, 74);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(623, 361);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // FormBackupNRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 589);
            this.Controls.Add(this.iconButtonRestore);
            this.Controls.Add(this.iconButtonBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.Name = "FormBackupNRestore";
            this.Text = "FormBackupNRestore";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonRestore;
        private FontAwesome.Sharp.IconButton iconButtonBackup;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}