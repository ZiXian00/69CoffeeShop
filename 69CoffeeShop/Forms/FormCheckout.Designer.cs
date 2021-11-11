namespace _69CoffeeShop.Forms
{
    partial class FormCheckout
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBoxMember = new System.Windows.Forms.GroupBox();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.lblMemName = new System.Windows.Forms.Label();
            this.lblMemID = new System.Windows.Forms.Label();
            this.cbRedeem = new System.Windows.Forms.CheckBox();
            this.lblTotalPoint = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButtonBack = new FontAwesome.Sharp.IconButton();
            this.tabControlPayment = new System.Windows.Forms.TabControl();
            this.tabPageCash = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxChanges = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustPaid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.tabPageQR = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.comboBoxCamera = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.panelRight.SuspendLayout();
            this.groupBoxMember.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            this.tabControlPayment.SuspendLayout();
            this.tabPageCash.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOrder.AllowUserToResizeColumns = false;
            this.dataGridViewOrder.AllowUserToResizeRows = false;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.qty,
            this.btnAdd,
            this.btnMinus,
            this.price});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrder.MultiSelect = false;
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOrder.RowHeadersVisible = false;
            this.dataGridViewOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOrder.RowTemplate.Height = 30;
            this.dataGridViewOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOrder.Size = new System.Drawing.Size(604, 753);
            this.dataGridViewOrder.TabIndex = 34;
            this.dataGridViewOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellClick);
            this.dataGridViewOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellValueChanged);
            this.dataGridViewOrder.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewOrder_RowsAdded);
            this.dataGridViewOrder.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewOrder_RowsRemoved);
            // 
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.product.Width = 230;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qty.Width = 80;
            // 
            // btnAdd
            // 
            this.btnAdd.HeaderText = "";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ReadOnly = true;
            this.btnAdd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnAdd.Text = "+";
            this.btnAdd.Width = 30;
            // 
            // btnMinus
            // 
            this.btnMinus.HeaderText = "";
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ReadOnly = true;
            this.btnMinus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnMinus.Text = "-";
            this.btnMinus.Width = 30;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBoxMember);
            this.panelRight.Controls.Add(this.groupBoxInfo);
            this.panelRight.Controls.Add(this.groupBoxPayment);
            this.panelRight.Controls.Add(this.iconButtonBack);
            this.panelRight.Controls.Add(this.tabControlPayment);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(604, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(705, 753);
            this.panelRight.TabIndex = 35;
            // 
            // groupBoxMember
            // 
            this.groupBoxMember.Controls.Add(this.txtMemID);
            this.groupBoxMember.Controls.Add(this.btnSearchMember);
            this.groupBoxMember.Controls.Add(this.lblMemName);
            this.groupBoxMember.Controls.Add(this.lblMemID);
            this.groupBoxMember.Controls.Add(this.cbRedeem);
            this.groupBoxMember.Controls.Add(this.lblTotalPoint);
            this.groupBoxMember.Controls.Add(this.label13);
            this.groupBoxMember.Controls.Add(this.label12);
            this.groupBoxMember.Controls.Add(this.label11);
            this.groupBoxMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMember.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMember.Location = new System.Drawing.Point(0, -106);
            this.groupBoxMember.Name = "groupBoxMember";
            this.groupBoxMember.Size = new System.Drawing.Size(705, 176);
            this.groupBoxMember.TabIndex = 37;
            this.groupBoxMember.TabStop = false;
            this.groupBoxMember.Text = "Member Info";
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(155, 25);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(190, 26);
            this.txtMemID.TabIndex = 15;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(367, 25);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(134, 23);
            this.btnSearchMember.TabIndex = 14;
            this.btnSearchMember.Text = "Search Member";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // lblMemName
            // 
            this.lblMemName.AutoSize = true;
            this.lblMemName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemName.Location = new System.Drawing.Point(160, 92);
            this.lblMemName.Name = "lblMemName";
            this.lblMemName.Size = new System.Drawing.Size(15, 16);
            this.lblMemName.TabIndex = 13;
            this.lblMemName.Text = "-";
            // 
            // lblMemID
            // 
            this.lblMemID.AutoSize = true;
            this.lblMemID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemID.Location = new System.Drawing.Point(160, 71);
            this.lblMemID.Name = "lblMemID";
            this.lblMemID.Size = new System.Drawing.Size(15, 16);
            this.lblMemID.TabIndex = 12;
            this.lblMemID.Text = "-";
            // 
            // cbRedeem
            // 
            this.cbRedeem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRedeem.AutoSize = true;
            this.cbRedeem.Location = new System.Drawing.Point(535, 135);
            this.cbRedeem.Name = "cbRedeem";
            this.cbRedeem.Size = new System.Drawing.Size(88, 22);
            this.cbRedeem.TabIndex = 11;
            this.cbRedeem.Text = "Redeem";
            this.cbRedeem.UseVisualStyleBackColor = true;
            this.cbRedeem.CheckedChanged += new System.EventHandler(this.cbRedeem_CheckedChanged);
            // 
            // lblTotalPoint
            // 
            this.lblTotalPoint.AutoSize = true;
            this.lblTotalPoint.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoint.Location = new System.Drawing.Point(160, 114);
            this.lblTotalPoint.Name = "lblTotalPoint";
            this.lblTotalPoint.Size = new System.Drawing.Size(15, 16);
            this.lblTotalPoint.TabIndex = 10;
            this.lblTotalPoint.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total Point(s) : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Member name : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Member ID : ";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelTime);
            this.groupBoxInfo.Controls.Add(this.label4);
            this.groupBoxInfo.Controls.Add(this.labelDate);
            this.groupBoxInfo.Controls.Add(this.label6);
            this.groupBoxInfo.Controls.Add(this.labelEmpName);
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Controls.Add(this.labelEmpID);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInfo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(0, 70);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(705, 165);
            this.groupBoxInfo.TabIndex = 36;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Additional Info";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(160, 72);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(51, 18);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time :  ";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(158, 41);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(51, 18);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date : ";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpName.Location = new System.Drawing.Point(161, 134);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(51, 18);
            this.labelEmpName.TabIndex = 3;
            this.labelEmpName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Staff name : ";
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpID.Location = new System.Drawing.Point(160, 103);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(51, 18);
            this.labelEmpID.TabIndex = 1;
            this.labelEmpID.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID : ";
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.lblDiscount);
            this.groupBoxPayment.Controls.Add(this.label14);
            this.groupBoxPayment.Controls.Add(this.labelGrandTotal);
            this.groupBoxPayment.Controls.Add(this.label5);
            this.groupBoxPayment.Controls.Add(this.labelTax);
            this.groupBoxPayment.Controls.Add(this.label9);
            this.groupBoxPayment.Controls.Add(this.labelSubTotal);
            this.groupBoxPayment.Controls.Add(this.label7);
            this.groupBoxPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxPayment.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPayment.Location = new System.Drawing.Point(0, 235);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(705, 161);
            this.groupBoxPayment.TabIndex = 3;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Payment";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(167, 63);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(65, 16);
            this.lblDiscount.TabIndex = 15;
            this.lblDiscount.Text = "RM 0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(72, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "Discount : ";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.Location = new System.Drawing.Point(167, 111);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(52, 16);
            this.labelGrandTotal.TabIndex = 13;
            this.labelGrandTotal.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Grand-Total : ";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.Location = new System.Drawing.Point(167, 87);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(69, 16);
            this.labelTax.TabIndex = 11;
            this.labelTax.Text = "labelTax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tax (6%)     : ";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.Location = new System.Drawing.Point(167, 39);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(52, 16);
            this.labelSubTotal.TabIndex = 9;
            this.labelSubTotal.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sub-Total    : ";
            // 
            // iconButtonBack
            // 
            this.iconButtonBack.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBack.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.iconButtonBack.IconColor = System.Drawing.Color.Black;
            this.iconButtonBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBack.IconSize = 25;
            this.iconButtonBack.Location = new System.Drawing.Point(6, 12);
            this.iconButtonBack.Name = "iconButtonBack";
            this.iconButtonBack.Size = new System.Drawing.Size(127, 35);
            this.iconButtonBack.TabIndex = 2;
            this.iconButtonBack.Text = "Back";
            this.iconButtonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBack.UseVisualStyleBackColor = true;
            this.iconButtonBack.Click += new System.EventHandler(this.iconButtonBack_Click);
            // 
            // tabControlPayment
            // 
            this.tabControlPayment.Controls.Add(this.tabPageCash);
            this.tabControlPayment.Controls.Add(this.tabPageQR);
            this.tabControlPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlPayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPayment.Location = new System.Drawing.Point(0, 396);
            this.tabControlPayment.Name = "tabControlPayment";
            this.tabControlPayment.SelectedIndex = 0;
            this.tabControlPayment.Size = new System.Drawing.Size(705, 357);
            this.tabControlPayment.TabIndex = 0;
            this.tabControlPayment.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlPayment_Selected);
            // 
            // tabPageCash
            // 
            this.tabPageCash.Controls.Add(this.panel2);
            this.tabPageCash.Controls.Add(this.panel1);
            this.tabPageCash.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCash.Location = new System.Drawing.Point(4, 28);
            this.tabPageCash.Name = "tabPageCash";
            this.tabPageCash.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCash.Size = new System.Drawing.Size(697, 325);
            this.tabPageCash.TabIndex = 0;
            this.tabPageCash.Tag = "Cash";
            this.tabPageCash.Text = "Cash";
            this.tabPageCash.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonComplete);
            this.panel2.Controls.Add(this.buttonCheck);
            this.panel2.Controls.Add(this.textBoxChanges);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxCustPaid);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 319);
            this.panel2.TabIndex = 1;
            // 
            // buttonComplete
            // 
            this.buttonComplete.Enabled = false;
            this.buttonComplete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComplete.Location = new System.Drawing.Point(212, 191);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(126, 44);
            this.buttonComplete.TabIndex = 54;
            this.buttonComplete.Tag = "Cash";
            this.buttonComplete.Text = "Complete";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Location = new System.Drawing.Point(68, 191);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(126, 44);
            this.buttonCheck.TabIndex = 53;
            this.buttonCheck.Tag = "";
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // textBoxChanges
            // 
            this.textBoxChanges.Enabled = false;
            this.textBoxChanges.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChanges.Location = new System.Drawing.Point(198, 138);
            this.textBoxChanges.Name = "textBoxChanges";
            this.textBoxChanges.ReadOnly = true;
            this.textBoxChanges.Size = new System.Drawing.Size(146, 23);
            this.textBoxChanges.TabIndex = 52;
            this.textBoxChanges.Leave += new System.EventHandler(this.textBoxCustPaid_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Changes (RM) : ";
            // 
            // textBoxCustPaid
            // 
            this.textBoxCustPaid.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustPaid.Location = new System.Drawing.Point(198, 88);
            this.textBoxCustPaid.Name = "textBoxCustPaid";
            this.textBoxCustPaid.Size = new System.Drawing.Size(146, 23);
            this.textBoxCustPaid.TabIndex = 50;
            this.textBoxCustPaid.Leave += new System.EventHandler(this.textBoxCustPaid_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Customer Paid (RM ) : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.iconButtonDelete);
            this.panel1.Controls.Add(this.buttonDot);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonSeven);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(334, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 319);
            this.panel1.TabIndex = 0;
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltLeft;
            this.iconButtonDelete.IconColor = System.Drawing.Color.Black;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.Location = new System.Drawing.Point(263, 15);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(70, 222);
            this.iconButtonDelete.TabIndex = 13;
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(263, 243);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(70, 70);
            this.buttonDot.TabIndex = 12;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(187, 243);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 70);
            this.button11.TabIndex = 11;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(35, 243);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(146, 70);
            this.button10.TabIndex = 10;
            this.button10.Text = "00";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(187, 167);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 8;
            this.button8.Text = "3";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(111, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 7;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(35, 167);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 6;
            this.button6.Text = "1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(187, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 5;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(111, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 4;
            this.button4.Text = "5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "9";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "8";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Location = new System.Drawing.Point(35, 15);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(70, 70);
            this.buttonSeven.TabIndex = 0;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonKeyPad_Click);
            // 
            // tabPageQR
            // 
            this.tabPageQR.Controls.Add(this.textBox1);
            this.tabPageQR.Controls.Add(this.buttonOK);
            this.tabPageQR.Controls.Add(this.pictureBoxQR);
            this.tabPageQR.Controls.Add(this.comboBoxCamera);
            this.tabPageQR.Controls.Add(this.label10);
            this.tabPageQR.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageQR.Location = new System.Drawing.Point(4, 28);
            this.tabPageQR.Name = "tabPageQR";
            this.tabPageQR.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQR.Size = new System.Drawing.Size(697, 325);
            this.tabPageQR.TabIndex = 1;
            this.tabPageQR.Tag = "e-Wallet";
            this.tabPageQR.Text = "e-Wallet";
            this.tabPageQR.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(528, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 319);
            this.textBox1.TabIndex = 54;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(430, 43);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(92, 29);
            this.buttonOK.TabIndex = 53;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxQR.Location = new System.Drawing.Point(59, 89);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(463, 217);
            this.pictureBoxQR.TabIndex = 52;
            this.pictureBoxQR.TabStop = false;
            // 
            // comboBoxCamera
            // 
            this.comboBoxCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCamera.FormattingEnabled = true;
            this.comboBoxCamera.Location = new System.Drawing.Point(157, 43);
            this.comboBoxCamera.Name = "comboBoxCamera";
            this.comboBoxCamera.Size = new System.Drawing.Size(256, 29);
            this.comboBoxCamera.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "Camera : ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 753);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.dataGridViewOrder);
            this.Name = "FormCheckout";
            this.Text = "FormCheckout";
            this.Load += new System.EventHandler(this.FormCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.groupBoxMember.ResumeLayout(false);
            this.groupBoxMember.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.tabControlPayment.ResumeLayout(false);
            this.tabPageCash.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPageQR.ResumeLayout(false);
            this.tabPageQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TabControl tabControlPayment;
        private System.Windows.Forms.TabPage tabPageCash;
        private System.Windows.Forms.TabPage tabPageQR;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewButtonColumn btnAdd;
        private System.Windows.Forms.DataGridViewButtonColumn btnMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private FontAwesome.Sharp.IconButton iconButtonBack;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBoxChanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustPaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.ComboBox comboBoxCamera;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxMember;
        private System.Windows.Forms.CheckBox cbRedeem;
        private System.Windows.Forms.Label lblTotalPoint;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMemName;
        private System.Windows.Forms.Label lblMemID;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TextBox txtMemID;
    }
}