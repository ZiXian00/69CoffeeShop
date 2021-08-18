
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.lblFrgtPw = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBoxEmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmployeeDetails
            // 
            this.groupBoxEmployeeDetails.Controls.Add(this.textBox1);
            this.groupBoxEmployeeDetails.Controls.Add(this.label1);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBox2);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelID);
            this.groupBoxEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEmployeeDetails.Location = new System.Drawing.Point(198, 71);
            this.groupBoxEmployeeDetails.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEmployeeDetails.Name = "groupBoxEmployeeDetails";
            this.groupBoxEmployeeDetails.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEmployeeDetails.Size = new System.Drawing.Size(408, 260);
            this.groupBoxEmployeeDetails.TabIndex = 5;
            this.groupBoxEmployeeDetails.TabStop = false;
            this.groupBoxEmployeeDetails.Text = "Login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 137);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 30);
            this.textBox1.TabIndex = 5;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 78);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 30);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "1002";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(27, 81);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(139, 25);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Employee ID : ";
            // 
            // lblFrgtPw
            // 
            this.lblFrgtPw.AutoSize = true;
            this.lblFrgtPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrgtPw.ForeColor = System.Drawing.Color.Blue;
            this.lblFrgtPw.Location = new System.Drawing.Point(194, 338);
            this.lblFrgtPw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrgtPw.Name = "lblFrgtPw";
            this.lblFrgtPw.Size = new System.Drawing.Size(148, 20);
            this.lblFrgtPw.TabIndex = 7;
            this.lblFrgtPw.Text = "Forgot password ?";
            this.lblFrgtPw.Click += new System.EventHandler(this.lblFrgtPw_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(463, 338);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(143, 41);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // FormAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxEmployeeDetails);
            this.Controls.Add(this.lblFrgtPw);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormAdminLogin";
            this.Text = "FormAdminLogin";
            this.groupBoxEmployeeDetails.ResumeLayout(false);
            this.groupBoxEmployeeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmployeeDetails;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label lblFrgtPw;
        private System.Windows.Forms.Button buttonLogin;
    }
}