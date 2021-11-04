
namespace _69CoffeeShop.Forms
{
    partial class FormAdminLogin
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
            this.groupBoxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.lblFrgtPw = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxEmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmployeeDetails
            // 
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxPassword);
            this.groupBoxEmployeeDetails.Controls.Add(this.label1);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxID);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelID);
            this.groupBoxEmployeeDetails.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEmployeeDetails.Location = new System.Drawing.Point(71, 65);
            this.groupBoxEmployeeDetails.Name = "groupBoxEmployeeDetails";
            this.groupBoxEmployeeDetails.Size = new System.Drawing.Size(306, 211);
            this.groupBoxEmployeeDetails.TabIndex = 5;
            this.groupBoxEmployeeDetails.TabStop = false;
            this.groupBoxEmployeeDetails.Text = "Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(150, 111);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(136, 26);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password : ";
            // 
            // textBoxID
            // 
            this.textBoxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxID.Location = new System.Drawing.Point(150, 63);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(136, 26);
            this.textBoxID.TabIndex = 3;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(20, 66);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(112, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Employee ID : ";
            // 
            // lblFrgtPw
            // 
            this.lblFrgtPw.AutoSize = true;
            this.lblFrgtPw.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrgtPw.ForeColor = System.Drawing.Color.Blue;
            this.lblFrgtPw.Location = new System.Drawing.Point(69, 282);
            this.lblFrgtPw.Name = "lblFrgtPw";
            this.lblFrgtPw.Size = new System.Drawing.Size(130, 16);
            this.lblFrgtPw.TabIndex = 7;
            this.lblFrgtPw.Text = "Forgot password ?";
            this.lblFrgtPw.Click += new System.EventHandler(this.lblFrgtPw_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(270, 282);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(107, 33);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdminLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxEmployeeDetails);
            this.Controls.Add(this.lblFrgtPw);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(472, 405);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(472, 405);
            this.Name = "FormAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.groupBoxEmployeeDetails.ResumeLayout(false);
            this.groupBoxEmployeeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmployeeDetails;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label lblFrgtPw;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button button1;
    }
}