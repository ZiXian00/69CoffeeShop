
namespace _69CoffeeShop.Forms
{
    partial class FormReports
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
            this.label14 = new System.Windows.Forms.Label();
            this.rbInvenReport = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.rbSupplier = new System.Windows.Forms.RadioButton();
            this.rbProcurement = new System.Windows.Forms.RadioButton();
            this.rbMember = new System.Windows.Forms.RadioButton();
            this.rbPayroll = new System.Windows.Forms.RadioButton();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.rbSalesProduct = new System.Windows.Forms.RadioButton();
            this.rbToday = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbYearly = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.gbDuration = new System.Windows.Forms.GroupBox();
            this.gbMonth = new System.Windows.Forms.GroupBox();
            this.gbYear = new System.Windows.Forms.GroupBox();
            this.gbDuration.SuspendLayout();
            this.gbMonth.SuspendLayout();
            this.gbYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(42)))), ((int)(((byte)(23)))));
            this.label14.Location = new System.Drawing.Point(179, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 47);
            this.label14.TabIndex = 68;
            this.label14.Text = "Report";
            // 
            // rbInvenReport
            // 
            this.rbInvenReport.AutoSize = true;
            this.rbInvenReport.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInvenReport.Location = new System.Drawing.Point(410, 155);
            this.rbInvenReport.Name = "rbInvenReport";
            this.rbInvenReport.Size = new System.Drawing.Size(119, 22);
            this.rbInvenReport.TabIndex = 69;
            this.rbInvenReport.TabStop = true;
            this.rbInvenReport.Text = "Inventories";
            this.rbInvenReport.UseVisualStyleBackColor = true;
            this.rbInvenReport.CheckedChanged += new System.EventHandler(this.rbInvenReport_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 12, 2, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 71;
            this.label2.Text = "Report for";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 12, 2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = ":";
            // 
            // rbSales
            // 
            this.rbSales.AutoSize = true;
            this.rbSales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSales.Location = new System.Drawing.Point(410, 181);
            this.rbSales.Name = "rbSales";
            this.rbSales.Size = new System.Drawing.Size(70, 22);
            this.rbSales.TabIndex = 73;
            this.rbSales.TabStop = true;
            this.rbSales.Text = "Sales";
            this.rbSales.UseVisualStyleBackColor = true;
            this.rbSales.CheckedChanged += new System.EventHandler(this.rbSales_CheckedChanged);
            // 
            // rbSupplier
            // 
            this.rbSupplier.AutoSize = true;
            this.rbSupplier.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSupplier.Location = new System.Drawing.Point(410, 237);
            this.rbSupplier.Name = "rbSupplier";
            this.rbSupplier.Size = new System.Drawing.Size(101, 22);
            this.rbSupplier.TabIndex = 74;
            this.rbSupplier.TabStop = true;
            this.rbSupplier.Text = "Suppliers";
            this.rbSupplier.UseVisualStyleBackColor = true;
            this.rbSupplier.CheckedChanged += new System.EventHandler(this.rbSupplier_CheckedChanged);
            // 
            // rbProcurement
            // 
            this.rbProcurement.AutoSize = true;
            this.rbProcurement.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProcurement.Location = new System.Drawing.Point(410, 265);
            this.rbProcurement.Name = "rbProcurement";
            this.rbProcurement.Size = new System.Drawing.Size(137, 22);
            this.rbProcurement.TabIndex = 75;
            this.rbProcurement.TabStop = true;
            this.rbProcurement.Text = "Procurements";
            this.rbProcurement.UseVisualStyleBackColor = true;
            this.rbProcurement.CheckedChanged += new System.EventHandler(this.rbProcurement_CheckedChanged);
            // 
            // rbMember
            // 
            this.rbMember.AutoSize = true;
            this.rbMember.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMember.Location = new System.Drawing.Point(410, 291);
            this.rbMember.Name = "rbMember";
            this.rbMember.Size = new System.Drawing.Size(99, 22);
            this.rbMember.TabIndex = 76;
            this.rbMember.TabStop = true;
            this.rbMember.Text = "Members";
            this.rbMember.UseVisualStyleBackColor = true;
            this.rbMember.CheckedChanged += new System.EventHandler(this.rbMember_CheckedChanged);
            // 
            // rbPayroll
            // 
            this.rbPayroll.AutoSize = true;
            this.rbPayroll.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPayroll.Location = new System.Drawing.Point(410, 317);
            this.rbPayroll.Name = "rbPayroll";
            this.rbPayroll.Size = new System.Drawing.Size(81, 22);
            this.rbPayroll.TabIndex = 77;
            this.rbPayroll.TabStop = true;
            this.rbPayroll.Text = "Payroll";
            this.rbPayroll.UseVisualStyleBackColor = true;
            this.rbPayroll.CheckedChanged += new System.EventHandler(this.rbPayroll_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(209)))), ((int)(((byte)(68)))));
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.Location = new System.Drawing.Point(1287, 731);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(121, 50);
            this.btnPrint.TabIndex = 78;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rbSalesProduct
            // 
            this.rbSalesProduct.AutoSize = true;
            this.rbSalesProduct.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSalesProduct.Location = new System.Drawing.Point(410, 209);
            this.rbSalesProduct.Name = "rbSalesProduct";
            this.rbSalesProduct.Size = new System.Drawing.Size(137, 22);
            this.rbSalesProduct.TabIndex = 80;
            this.rbSalesProduct.TabStop = true;
            this.rbSalesProduct.Text = "Sales Product";
            this.rbSalesProduct.UseVisualStyleBackColor = true;
            this.rbSalesProduct.CheckedChanged += new System.EventHandler(this.rbSalesProduct_CheckedChanged);
            // 
            // rbToday
            // 
            this.rbToday.AutoSize = true;
            this.rbToday.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbToday.Location = new System.Drawing.Point(65, 59);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(73, 22);
            this.rbToday.TabIndex = 81;
            this.rbToday.TabStop = true;
            this.rbToday.Text = "Today";
            this.rbToday.UseVisualStyleBackColor = true;
            this.rbToday.CheckedChanged += new System.EventHandler(this.rbToday_CheckedChanged);
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMonthly.Location = new System.Drawing.Point(65, 87);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(76, 22);
            this.rbMonthly.TabIndex = 82;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Month";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.rbMonthly_CheckedChanged);
            // 
            // rbYearly
            // 
            this.rbYearly.AutoSize = true;
            this.rbYearly.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYearly.Location = new System.Drawing.Point(65, 115);
            this.rbYearly.Name = "rbYearly";
            this.rbYearly.Size = new System.Drawing.Size(62, 22);
            this.rbYearly.TabIndex = 83;
            this.rbYearly.TabStop = true;
            this.rbYearly.Text = "Year";
            this.rbYearly.UseVisualStyleBackColor = true;
            this.rbYearly.CheckedChanged += new System.EventHandler(this.rbYearly_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 12, 2, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 18);
            this.label5.TabIndex = 87;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 12, 2, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 86;
            this.label6.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(183, 19);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(160, 26);
            this.txtYear.TabIndex = 88;
            // 
            // cbMonth
            // 
            this.cbMonth.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(183, 26);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(160, 26);
            this.cbMonth.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 12, 2, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 18);
            this.label7.TabIndex = 91;
            this.label7.Text = ":";
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(47, 30);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(2, 12, 2, 16);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(59, 18);
            this.lblMonth.TabIndex = 90;
            this.lblMonth.Text = "Month";
            // 
            // gbDuration
            // 
            this.gbDuration.Controls.Add(this.rbToday);
            this.gbDuration.Controls.Add(this.rbMonthly);
            this.gbDuration.Controls.Add(this.rbYearly);
            this.gbDuration.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDuration.Location = new System.Drawing.Point(605, 155);
            this.gbDuration.Name = "gbDuration";
            this.gbDuration.Size = new System.Drawing.Size(200, 204);
            this.gbDuration.TabIndex = 92;
            this.gbDuration.TabStop = false;
            this.gbDuration.Text = "Duration : ";
            this.gbDuration.Visible = false;
            // 
            // gbMonth
            // 
            this.gbMonth.Controls.Add(this.cbMonth);
            this.gbMonth.Controls.Add(this.label7);
            this.gbMonth.Controls.Add(this.lblMonth);
            this.gbMonth.Location = new System.Drawing.Point(860, 155);
            this.gbMonth.Name = "gbMonth";
            this.gbMonth.Size = new System.Drawing.Size(372, 66);
            this.gbMonth.TabIndex = 93;
            this.gbMonth.TabStop = false;
            this.gbMonth.Visible = false;
            // 
            // gbYear
            // 
            this.gbYear.Controls.Add(this.txtYear);
            this.gbYear.Controls.Add(this.label5);
            this.gbYear.Controls.Add(this.label6);
            this.gbYear.Location = new System.Drawing.Point(860, 227);
            this.gbYear.Name = "gbYear";
            this.gbYear.Size = new System.Drawing.Size(372, 66);
            this.gbYear.TabIndex = 94;
            this.gbYear.TabStop = false;
            this.gbYear.Visible = false;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.BackgroundImage = global::_69CoffeeShop.Properties.Resources._69_Coffee_Shop_tpbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1441, 811);
            this.Controls.Add(this.gbYear);
            this.Controls.Add(this.gbMonth);
            this.Controls.Add(this.gbDuration);
            this.Controls.Add(this.rbSalesProduct);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rbPayroll);
            this.Controls.Add(this.rbMember);
            this.Controls.Add(this.rbProcurement);
            this.Controls.Add(this.rbSupplier);
            this.Controls.Add(this.rbSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbInvenReport);
            this.Controls.Add(this.label14);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.gbDuration.ResumeLayout(false);
            this.gbDuration.PerformLayout();
            this.gbMonth.ResumeLayout(false);
            this.gbMonth.PerformLayout();
            this.gbYear.ResumeLayout(false);
            this.gbYear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbInvenReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSales;
        private System.Windows.Forms.RadioButton rbSupplier;
        private System.Windows.Forms.RadioButton rbProcurement;
        private System.Windows.Forms.RadioButton rbMember;
        private System.Windows.Forms.RadioButton rbPayroll;
        private FontAwesome.Sharp.IconButton btnPrint;
        private System.Windows.Forms.RadioButton rbSalesProduct;
        private System.Windows.Forms.RadioButton rbToday;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbYearly;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.GroupBox gbDuration;
        private System.Windows.Forms.GroupBox gbMonth;
        private System.Windows.Forms.GroupBox gbYear;
    }
}