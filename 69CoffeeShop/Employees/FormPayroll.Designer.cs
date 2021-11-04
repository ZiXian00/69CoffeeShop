
namespace _69CoffeeShop.Employees
{
    partial class FormPayroll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.payroll = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.textBoxBankAcc = new System.Windows.Forms.TextBox();
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.iconButtonCheck = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNetSalary = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBoxDeduction = new System.Windows.Forms.GroupBox();
            this.textBoxTotalDeduction = new System.Windows.Forms.TextBox();
            this.textBoxSocso = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxEPF = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.domainUpDownEPF = new System.Windows.Forms.DomainUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxGrossSalary = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxOTRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxOT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.payrollList = new System.Windows.Forms.TabPage();
            this.dataGridViewPayroll = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.tabControl1.SuspendLayout();
            this.payroll.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxEmployeeDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDeduction.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.payrollList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.payroll);
            this.tabControl1.Controls.Add(this.payrollList);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1472, 673);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // payroll
            // 
            this.payroll.Controls.Add(this.panel1);
            this.payroll.Controls.Add(this.iconButtonAdd);
            this.payroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payroll.Location = new System.Drawing.Point(4, 27);
            this.payroll.Name = "payroll";
            this.payroll.Padding = new System.Windows.Forms.Padding(3);
            this.payroll.Size = new System.Drawing.Size(1464, 642);
            this.payroll.TabIndex = 0;
            this.payroll.Text = "Create Payroll";
            this.payroll.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBoxEmployeeDetails);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(8, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1448, 556);
            this.panel1.TabIndex = 16;
            // 
            // groupBoxEmployeeDetails
            // 
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxBankAcc);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxBankName);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxPosition);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxStatus);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxName);
            this.groupBoxEmployeeDetails.Controls.Add(this.iconButtonCheck);
            this.groupBoxEmployeeDetails.Controls.Add(this.label9);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxID);
            this.groupBoxEmployeeDetails.Controls.Add(this.label6);
            this.groupBoxEmployeeDetails.Controls.Add(this.label4);
            this.groupBoxEmployeeDetails.Controls.Add(this.label1);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelName);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelID);
            this.groupBoxEmployeeDetails.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEmployeeDetails.Location = new System.Drawing.Point(16, 28);
            this.groupBoxEmployeeDetails.Name = "groupBoxEmployeeDetails";
            this.groupBoxEmployeeDetails.Size = new System.Drawing.Size(889, 143);
            this.groupBoxEmployeeDetails.TabIndex = 5;
            this.groupBoxEmployeeDetails.TabStop = false;
            this.groupBoxEmployeeDetails.Text = "Employee Details";
            // 
            // textBoxBankAcc
            // 
            this.textBoxBankAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBankAcc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBankAcc.Location = new System.Drawing.Point(687, 101);
            this.textBoxBankAcc.Multiline = true;
            this.textBoxBankAcc.Name = "textBoxBankAcc";
            this.textBoxBankAcc.Size = new System.Drawing.Size(150, 23);
            this.textBoxBankAcc.TabIndex = 22;
            // 
            // textBoxBankName
            // 
            this.textBoxBankName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBankName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBankName.Location = new System.Drawing.Point(687, 68);
            this.textBoxBankName.Multiline = true;
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(150, 23);
            this.textBoxBankName.TabIndex = 21;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPosition.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPosition.Location = new System.Drawing.Point(687, 35);
            this.textBoxPosition.Multiline = true;
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(150, 23);
            this.textBoxPosition.TabIndex = 20;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(210, 103);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(150, 23);
            this.textBoxStatus.TabIndex = 19;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(210, 68);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 23);
            this.textBoxName.TabIndex = 18;
            // 
            // iconButtonCheck
            // 
            this.iconButtonCheck.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.iconButtonCheck.IconColor = System.Drawing.Color.Black;
            this.iconButtonCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCheck.IconSize = 20;
            this.iconButtonCheck.Location = new System.Drawing.Point(316, 34);
            this.iconButtonCheck.Name = "iconButtonCheck";
            this.iconButtonCheck.Size = new System.Drawing.Size(26, 28);
            this.iconButtonCheck.TabIndex = 17;
            this.iconButtonCheck.UseVisualStyleBackColor = true;
            this.iconButtonCheck.Click += new System.EventHandler(this.iconButtonCheck_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(556, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Job Position : ";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(210, 32);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 27);
            this.textBoxID.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Employment Status : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bank Account No.: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bank : ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(45, 68);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(159, 18);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Employee Name : ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(73, 35);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(131, 18);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Employee ID : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxNetSalary);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.groupBoxDeduction);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1420, 360);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payroll Details";
            this.groupBox1.Visible = false;
            // 
            // textBoxNetSalary
            // 
            this.textBoxNetSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNetSalary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetSalary.Location = new System.Drawing.Point(1000, 320);
            this.textBoxNetSalary.Multiline = true;
            this.textBoxNetSalary.Name = "textBoxNetSalary";
            this.textBoxNetSalary.Size = new System.Drawing.Size(123, 27);
            this.textBoxNetSalary.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(871, 317);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 18);
            this.label21.TabIndex = 13;
            this.label21.Text = "Net Salary : ";
            // 
            // groupBoxDeduction
            // 
            this.groupBoxDeduction.Controls.Add(this.textBoxTotalDeduction);
            this.groupBoxDeduction.Controls.Add(this.textBoxSocso);
            this.groupBoxDeduction.Controls.Add(this.label19);
            this.groupBoxDeduction.Controls.Add(this.textBoxEPF);
            this.groupBoxDeduction.Controls.Add(this.label17);
            this.groupBoxDeduction.Controls.Add(this.label16);
            this.groupBoxDeduction.Controls.Add(this.domainUpDownEPF);
            this.groupBoxDeduction.Controls.Add(this.label15);
            this.groupBoxDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDeduction.Location = new System.Drawing.Point(746, 26);
            this.groupBoxDeduction.Name = "groupBoxDeduction";
            this.groupBoxDeduction.Size = new System.Drawing.Size(613, 286);
            this.groupBoxDeduction.TabIndex = 1;
            this.groupBoxDeduction.TabStop = false;
            this.groupBoxDeduction.Text = "Deduction";
            // 
            // textBoxTotalDeduction
            // 
            this.textBoxTotalDeduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalDeduction.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalDeduction.Location = new System.Drawing.Point(367, 210);
            this.textBoxTotalDeduction.Multiline = true;
            this.textBoxTotalDeduction.Name = "textBoxTotalDeduction";
            this.textBoxTotalDeduction.Size = new System.Drawing.Size(120, 27);
            this.textBoxTotalDeduction.TabIndex = 17;
            // 
            // textBoxSocso
            // 
            this.textBoxSocso.Enabled = false;
            this.textBoxSocso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSocso.Location = new System.Drawing.Point(244, 132);
            this.textBoxSocso.Name = "textBoxSocso";
            this.textBoxSocso.ReadOnly = true;
            this.textBoxSocso.Size = new System.Drawing.Size(100, 27);
            this.textBoxSocso.TabIndex = 14;
            this.textBoxSocso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(210, 210);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(162, 18);
            this.label19.TabIndex = 13;
            this.label19.Text = "Total Deduction : ";
            // 
            // textBoxEPF
            // 
            this.textBoxEPF.Enabled = false;
            this.textBoxEPF.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEPF.Location = new System.Drawing.Point(244, 86);
            this.textBoxEPF.Name = "textBoxEPF";
            this.textBoxEPF.ReadOnly = true;
            this.textBoxEPF.Size = new System.Drawing.Size(100, 27);
            this.textBoxEPF.TabIndex = 13;
            this.textBoxEPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(94, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 18);
            this.label17.TabIndex = 4;
            this.label17.Text = "EPF Deduction : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(225, 18);
            this.label16.TabIndex = 2;
            this.label16.Text = "Socso Deduction (0.5%) : ";
            // 
            // domainUpDownEPF
            // 
            this.domainUpDownEPF.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownEPF.Items.Add("15%");
            this.domainUpDownEPF.Items.Add("14%");
            this.domainUpDownEPF.Items.Add("13%");
            this.domainUpDownEPF.Items.Add("12%");
            this.domainUpDownEPF.Items.Add("11%");
            this.domainUpDownEPF.Items.Add("10%");
            this.domainUpDownEPF.Items.Add("9%");
            this.domainUpDownEPF.Items.Add("8%");
            this.domainUpDownEPF.Items.Add("7%");
            this.domainUpDownEPF.Items.Add("6%");
            this.domainUpDownEPF.Location = new System.Drawing.Point(244, 40);
            this.domainUpDownEPF.Name = "domainUpDownEPF";
            this.domainUpDownEPF.ReadOnly = true;
            this.domainUpDownEPF.Size = new System.Drawing.Size(60, 27);
            this.domainUpDownEPF.TabIndex = 1;
            this.domainUpDownEPF.SelectedItemChanged += new System.EventHandler(this.domainUpDownEPF_SelectedItemChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(138, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "EPF Rate : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxGrossSalary);
            this.groupBox2.Controls.Add(this.buttonCalculate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelInfo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxOTRate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxOT);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBoxDays);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxHours);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 287);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Income";
            // 
            // textBoxGrossSalary
            // 
            this.textBoxGrossSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGrossSalary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrossSalary.Location = new System.Drawing.Point(582, 207);
            this.textBoxGrossSalary.Multiline = true;
            this.textBoxGrossSalary.Name = "textBoxGrossSalary";
            this.textBoxGrossSalary.Size = new System.Drawing.Size(123, 27);
            this.textBoxGrossSalary.TabIndex = 16;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(592, 240);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(103, 30);
            this.buttonCalculate.TabIndex = 15;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "*";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(28, 207);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(81, 18);
            this.labelInfo.TabIndex = 13;
            this.labelInfo.Text = "labelInfo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(449, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 18);
            this.label14.TabIndex = 11;
            this.label14.Text = "Gross Salary : ";
            // 
            // textBoxOTRate
            // 
            this.textBoxOTRate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOTRate.Location = new System.Drawing.Point(572, 153);
            this.textBoxOTRate.Name = "textBoxOTRate";
            this.textBoxOTRate.Size = new System.Drawing.Size(100, 27);
            this.textBoxOTRate.TabIndex = 10;
            this.textBoxOTRate.Text = "8";
            this.textBoxOTRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(397, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "OT rate per hour  : ";
            // 
            // textBoxOT
            // 
            this.textBoxOT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOT.Location = new System.Drawing.Point(218, 156);
            this.textBoxOT.Name = "textBoxOT";
            this.textBoxOT.Size = new System.Drawing.Size(100, 27);
            this.textBoxOT.TabIndex = 8;
            this.textBoxOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(95, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "OT Hour(s) : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxRate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxSalary);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(689, 76);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wages Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(340, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "/";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Enabled = false;
            this.textBoxRate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRate.Location = new System.Drawing.Point(212, 29);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.ReadOnly = true;
            this.textBoxRate.Size = new System.Drawing.Size(100, 27);
            this.textBoxRate.TabIndex = 2;
            this.textBoxRate.Text = "-";
            this.textBoxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rate per Hour: ";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.Location = new System.Drawing.Point(568, 33);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(101, 27);
            this.textBoxSalary.TabIndex = 7;
            this.textBoxSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Fixed Salary : ";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDays.Location = new System.Drawing.Point(574, 104);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(100, 27);
            this.textBoxDays.TabIndex = 5;
            this.textBoxDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Working Day(s) : ";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHours.Location = new System.Drawing.Point(218, 104);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(100, 27);
            this.textBoxHours.TabIndex = 3;
            this.textBoxHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Working Hour(s) : ";
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonAdd.IconColor = System.Drawing.Color.Black;
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.IconSize = 40;
            this.iconButtonAdd.Location = new System.Drawing.Point(1292, 592);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Size = new System.Drawing.Size(164, 44);
            this.iconButtonAdd.TabIndex = 15;
            this.iconButtonAdd.Text = "Add Record";
            this.iconButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdd.UseVisualStyleBackColor = true;
            this.iconButtonAdd.Visible = false;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // payrollList
            // 
            this.payrollList.Controls.Add(this.dataGridViewPayroll);
            this.payrollList.Controls.Add(this.iconButtonDelete);
            this.payrollList.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollList.Location = new System.Drawing.Point(4, 27);
            this.payrollList.Name = "payrollList";
            this.payrollList.Padding = new System.Windows.Forms.Padding(3);
            this.payrollList.Size = new System.Drawing.Size(1464, 642);
            this.payrollList.TabIndex = 1;
            this.payrollList.Text = "Payroll List";
            this.payrollList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPayroll
            // 
            this.dataGridViewPayroll.AllowUserToAddRows = false;
            this.dataGridViewPayroll.AllowUserToDeleteRows = false;
            this.dataGridViewPayroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPayroll.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPayroll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPayroll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.id,
            this.position,
            this.date,
            this.wages,
            this.totalDays,
            this.totalHours,
            this.grossSalary,
            this.netSalary,
            this.status});
            this.dataGridViewPayroll.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPayroll.Name = "dataGridViewPayroll";
            this.dataGridViewPayroll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dataGridViewPayroll.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPayroll.Size = new System.Drawing.Size(1458, 582);
            this.dataGridViewPayroll.TabIndex = 123;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // position
            // 
            this.position.HeaderText = "Position";
            this.position.Name = "position";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 130;
            // 
            // wages
            // 
            this.wages.HeaderText = "Wages Type";
            this.wages.Name = "wages";
            this.wages.Width = 150;
            // 
            // totalDays
            // 
            this.totalDays.HeaderText = "Total Working Days";
            this.totalDays.Name = "totalDays";
            this.totalDays.Width = 150;
            // 
            // totalHours
            // 
            this.totalHours.HeaderText = "Total Working Hours";
            this.totalHours.Name = "totalHours";
            this.totalHours.Width = 150;
            // 
            // grossSalary
            // 
            this.grossSalary.HeaderText = "Gross Salary (RM)";
            this.grossSalary.Name = "grossSalary";
            this.grossSalary.Width = 150;
            // 
            // netSalary
            // 
            this.netSalary.HeaderText = "Net Salary (RM)";
            this.netSalary.Name = "netSalary";
            this.netSalary.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButtonDelete.IconColor = System.Drawing.Color.Black;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.IconSize = 40;
            this.iconButtonDelete.Location = new System.Drawing.Point(1321, 591);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(137, 45);
            this.iconButtonDelete.TabIndex = 121;
            this.iconButtonDelete.Text = "Delete";
            this.iconButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // FormPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 712);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPayroll";
            this.Text = "FormPayroll";
            this.Load += new System.EventHandler(this.FormPayroll_Load);
            this.tabControl1.ResumeLayout(false);
            this.payroll.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxEmployeeDetails.ResumeLayout(false);
            this.groupBoxEmployeeDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDeduction.ResumeLayout(false);
            this.groupBoxDeduction.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.payrollList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayroll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage payroll;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private System.Windows.Forms.TabPage payrollList;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxEmployeeDetails;
        private FontAwesome.Sharp.IconButton iconButtonCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBoxDeduction;
        private System.Windows.Forms.TextBox textBoxSocso;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxEPF;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DomainUpDown domainUpDownEPF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxOTRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxOT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBankAcc;
        private System.Windows.Forms.TextBox textBoxBankName;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.DataGridView dataGridViewPayroll;
        private System.Windows.Forms.TextBox textBoxNetSalary;
        private System.Windows.Forms.TextBox textBoxTotalDeduction;
        private System.Windows.Forms.TextBox textBoxGrossSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn wages;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn netSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}