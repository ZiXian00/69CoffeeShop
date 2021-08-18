
using System;

namespace _69CoffeeShop.Employees
{
    partial class FormAddEmployee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.radFullTime = new System.Windows.Forms.RadioButton();
            this.radioPartTime = new System.Windows.Forms.RadioButton();
            this.lblEmploymentStatus = new System.Windows.Forms.Label();
            this.dropdownPosition = new System.Windows.Forms.ComboBox();
            this.lblJobPosition = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dropdownBank = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIC = new System.Windows.Forms.TextBox();
            this.lblIC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtbDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtEmergency = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dropDownMarriage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gBoxPersonal = new System.Windows.Forms.GroupBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gBoxPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radFullTime);
            this.groupBox1.Controls.Add(this.radioPartTime);
            this.groupBox1.Controls.Add(this.lblEmploymentStatus);
            this.groupBox1.Controls.Add(this.dropdownPosition);
            this.groupBox1.Controls.Add(this.lblJobPosition);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 139);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Work Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(595, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date Hired : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radFullTime
            // 
            this.radFullTime.AutoSize = true;
            this.radFullTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFullTime.Location = new System.Drawing.Point(264, 72);
            this.radFullTime.Name = "radFullTime";
            this.radFullTime.Size = new System.Drawing.Size(76, 20);
            this.radFullTime.TabIndex = 20;
            this.radFullTime.TabStop = true;
            this.radFullTime.Text = "Full-time";
            this.radFullTime.UseVisualStyleBackColor = true;
            // 
            // radioPartTime
            // 
            this.radioPartTime.AutoSize = true;
            this.radioPartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPartTime.Location = new System.Drawing.Point(179, 72);
            this.radioPartTime.Name = "radioPartTime";
            this.radioPartTime.Size = new System.Drawing.Size(79, 20);
            this.radioPartTime.TabIndex = 19;
            this.radioPartTime.TabStop = true;
            this.radioPartTime.Text = "Part-time";
            this.radioPartTime.UseVisualStyleBackColor = true;
            // 
            // lblEmploymentStatus
            // 
            this.lblEmploymentStatus.AutoSize = true;
            this.lblEmploymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmploymentStatus.Location = new System.Drawing.Point(25, 74);
            this.lblEmploymentStatus.Name = "lblEmploymentStatus";
            this.lblEmploymentStatus.Size = new System.Drawing.Size(140, 16);
            this.lblEmploymentStatus.TabIndex = 21;
            this.lblEmploymentStatus.Text = "Employement Status : ";
            this.lblEmploymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dropdownPosition
            // 
            this.dropdownPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownPosition.FormattingEnabled = true;
            this.dropdownPosition.Items.AddRange(new object[] {
            "Manager",
            "Cashier",
            "Waiter"});
            this.dropdownPosition.Location = new System.Drawing.Point(170, 31);
            this.dropdownPosition.Name = "dropdownPosition";
            this.dropdownPosition.Size = new System.Drawing.Size(179, 23);
            this.dropdownPosition.TabIndex = 19;
            // 
            // lblJobPosition
            // 
            this.lblJobPosition.AutoSize = true;
            this.lblJobPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobPosition.Location = new System.Drawing.Point(73, 31);
            this.lblJobPosition.Name = "lblJobPosition";
            this.lblJobPosition.Size = new System.Drawing.Size(91, 16);
            this.lblJobPosition.TabIndex = 19;
            this.lblJobPosition.Text = "Job Position : ";
            this.lblJobPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(595, 208);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(190, 21);
            this.maskedTextBox1.TabIndex = 25;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(490, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Bank Account : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dropdownBank
            // 
            this.dropdownBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownBank.FormattingEnabled = true;
            this.dropdownBank.Items.AddRange(new object[] {
            "Public Bank Berhad",
            "Maybank Berhad",
            "CIMB Bank ",
            "Hong Leong Bank"});
            this.dropdownBank.Location = new System.Drawing.Point(595, 173);
            this.dropdownBank.Name = "dropdownBank";
            this.dropdownBank.Size = new System.Drawing.Size(259, 23);
            this.dropdownBank.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Bank : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 21;
            // 
            // txtIC
            // 
            this.txtIC.Location = new System.Drawing.Point(595, 33);
            this.txtIC.Name = "txtIC";
            this.txtIC.Size = new System.Drawing.Size(273, 21);
            this.txtIC.TabIndex = 20;
            // 
            // lblIC
            // 
            this.lblIC.AutoSize = true;
            this.lblIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIC.Location = new System.Drawing.Point(472, 33);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(117, 16);
            this.lblIC.TabIndex = 19;
            this.lblIC.Text = "IC / Passport No. : ";
            this.lblIC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Age : ";
            // 
            // dtbDateOfBirth
            // 
            this.dtbDateOfBirth.CustomFormat = "dd-MMM-yyyy";
            this.dtbDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbDateOfBirth.Location = new System.Drawing.Point(171, 141);
            this.dtbDateOfBirth.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtbDateOfBirth.Name = "dtbDateOfBirth";
            this.dtbDateOfBirth.Size = new System.Drawing.Size(116, 21);
            this.dtbDateOfBirth.TabIndex = 17;
            // 
            // txtEmergency
            // 
            this.txtEmergency.Location = new System.Drawing.Point(171, 104);
            this.txtEmergency.Name = "txtEmergency";
            this.txtEmergency.Size = new System.Drawing.Size(273, 21);
            this.txtEmergency.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Emergency Contact No. : ";
            // 
            // dropDownMarriage
            // 
            this.dropDownMarriage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownMarriage.FormattingEnabled = true;
            this.dropDownMarriage.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Seperated",
            "Widowed"});
            this.dropDownMarriage.Location = new System.Drawing.Point(595, 139);
            this.dropDownMarriage.Name = "dropDownMarriage";
            this.dropDownMarriage.Size = new System.Drawing.Size(155, 23);
            this.dropDownMarriage.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marital Status : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(595, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 21);
            this.txtEmail.TabIndex = 11;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(76, 141);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(89, 16);
            this.lblDOB.TabIndex = 16;
            this.lblDOB.Text = "Date of Birth : ";
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonAdd.IconColor = System.Drawing.Color.Black;
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.Location = new System.Drawing.Point(857, 578);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Size = new System.Drawing.Size(126, 45);
            this.iconButtonAdd.TabIndex = 9;
            this.iconButtonAdd.Text = "Add";
            this.iconButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdd.UseVisualStyleBackColor = true;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(484, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 16);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email Address : ";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(171, 211);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(274, 113);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Address : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOther.Location = new System.Drawing.Point(727, 104);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(127, 20);
            this.radOther.TabIndex = 7;
            this.radOther.TabStop = true;
            this.radOther.Text = "Prefer Not to Say";
            this.radOther.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.Location = new System.Drawing.Point(649, 104);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(72, 20);
            this.radFemale.TabIndex = 6;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(527, 104);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 16);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender : ";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(171, 68);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(273, 21);
            this.txtContact.TabIndex = 3;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(79, 69);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(86, 16);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact No. : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(110, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name : ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gBoxPersonal
            // 
            this.gBoxPersonal.Controls.Add(this.maskedTextBox1);
            this.gBoxPersonal.Controls.Add(this.label8);
            this.gBoxPersonal.Controls.Add(this.dropdownBank);
            this.gBoxPersonal.Controls.Add(this.label7);
            this.gBoxPersonal.Controls.Add(this.label6);
            this.gBoxPersonal.Controls.Add(this.txtIC);
            this.gBoxPersonal.Controls.Add(this.lblIC);
            this.gBoxPersonal.Controls.Add(this.label4);
            this.gBoxPersonal.Controls.Add(this.dtbDateOfBirth);
            this.gBoxPersonal.Controls.Add(this.lblDOB);
            this.gBoxPersonal.Controls.Add(this.txtEmergency);
            this.gBoxPersonal.Controls.Add(this.label3);
            this.gBoxPersonal.Controls.Add(this.dropDownMarriage);
            this.gBoxPersonal.Controls.Add(this.label2);
            this.gBoxPersonal.Controls.Add(this.txtEmail);
            this.gBoxPersonal.Controls.Add(this.lblEmail);
            this.gBoxPersonal.Controls.Add(this.txtAddress);
            this.gBoxPersonal.Controls.Add(this.label1);
            this.gBoxPersonal.Controls.Add(this.radOther);
            this.gBoxPersonal.Controls.Add(this.radFemale);
            this.gBoxPersonal.Controls.Add(this.radMale);
            this.gBoxPersonal.Controls.Add(this.lblGender);
            this.gBoxPersonal.Controls.Add(this.txtContact);
            this.gBoxPersonal.Controls.Add(this.lblContact);
            this.gBoxPersonal.Controls.Add(this.txtName);
            this.gBoxPersonal.Controls.Add(this.lblName);
            this.gBoxPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxPersonal.Location = new System.Drawing.Point(34, 65);
            this.gBoxPersonal.MaximumSize = new System.Drawing.Size(950, 345);
            this.gBoxPersonal.MinimumSize = new System.Drawing.Size(950, 345);
            this.gBoxPersonal.Name = "gBoxPersonal";
            this.gBoxPersonal.Size = new System.Drawing.Size(950, 345);
            this.gBoxPersonal.TabIndex = 7;
            this.gBoxPersonal.TabStop = false;
            this.gBoxPersonal.Text = "Personal Information";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(595, 104);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(56, 20);
            this.radMale.TabIndex = 5;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(131, 16);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(85, 20);
            this.txtEmployeeID.TabIndex = 6;
            this.txtEmployeeID.Text = "1015";
            this.txtEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(31, 16);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(95, 16);
            this.lblEmployeeID.TabIndex = 5;
            this.lblEmployeeID.Text = "Employee ID : ";
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 639);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconButtonAdd);
            this.Controls.Add(this.gBoxPersonal);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddEmployee";
            this.Text = "FormAddEmployee";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxPersonal.ResumeLayout(false);
            this.gBoxPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radFullTime;
        private System.Windows.Forms.RadioButton radioPartTime;
        private System.Windows.Forms.Label lblEmploymentStatus;
        private System.Windows.Forms.ComboBox dropdownPosition;
        private System.Windows.Forms.Label lblJobPosition;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dropdownBank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIC;
        private System.Windows.Forms.Label lblIC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtbDateOfBirth;
        private System.Windows.Forms.TextBox txtEmergency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dropDownMarriage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDOB;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gBoxPersonal;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
    }
}