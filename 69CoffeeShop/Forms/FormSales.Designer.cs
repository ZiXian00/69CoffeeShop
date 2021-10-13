
namespace _69CoffeeShop.Forms
{
    partial class FormSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSPrice = new System.Windows.Forms.Label();
            this.iconButtonCheckout = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOrder.AllowUserToResizeColumns = false;
            this.dataGridViewOrder.AllowUserToResizeRows = false;
            this.dataGridViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.qty,
            this.btnAdd,
            this.btnMinus,
            this.price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOrder.Location = new System.Drawing.Point(739, 0);
            this.dataGridViewOrder.MultiSelect = false;
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrder.RowHeadersVisible = false;
            this.dataGridViewOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOrder.RowTemplate.Height = 30;
            this.dataGridViewOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOrder.Size = new System.Drawing.Size(458, 750);
            this.dataGridViewOrder.TabIndex = 33;
            this.dataGridViewOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellClick);
            this.dataGridViewOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellValueChanged);
            this.dataGridViewOrder.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewOrder_RowsAdded);
            this.dataGridViewOrder.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewOrder_RowsRemoved);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(956, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sub-Total  : ";
            // 
            // labelSPrice
            // 
            this.labelSPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSPrice.Location = new System.Drawing.Point(1069, 646);
            this.labelSPrice.Name = "labelSPrice";
            this.labelSPrice.Size = new System.Drawing.Size(116, 28);
            this.labelSPrice.TabIndex = 35;
            this.labelSPrice.Text = "RM 0.00";
            this.labelSPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconButtonCheckout
            // 
            this.iconButtonCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonCheckout.Enabled = false;
            this.iconButtonCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCheckout.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconButtonCheckout.IconColor = System.Drawing.Color.Black;
            this.iconButtonCheckout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCheckout.IconSize = 30;
            this.iconButtonCheckout.Location = new System.Drawing.Point(1030, 686);
            this.iconButtonCheckout.Name = "iconButtonCheckout";
            this.iconButtonCheckout.Size = new System.Drawing.Size(131, 55);
            this.iconButtonCheckout.TabIndex = 30;
            this.iconButtonCheckout.Text = "Checkout";
            this.iconButtonCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCheckout.UseVisualStyleBackColor = true;
            this.iconButtonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMenu.ColumnCount = 4;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(82, 31);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 2;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(651, 719);
            this.tableLayoutPanelMenu.TabIndex = 36;
            // 
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.product.Width = 240;
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
            this.btnAdd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnAdd.Text = "+";
            this.btnAdd.Width = 20;
            // 
            // btnMinus
            // 
            this.btnMinus.HeaderText = "";
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnMinus.Text = "-";
            this.btnMinus.Width = 20;
            // 
            // price
            // 
            this.price.DividerWidth = 3;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 753);
            this.Controls.Add(this.tableLayoutPanelMenu);
            this.Controls.Add(this.labelSPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.iconButtonCheckout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSales";
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSPrice;
        private FontAwesome.Sharp.IconButton iconButtonCheckout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewButtonColumn btnAdd;
        private System.Windows.Forms.DataGridViewButtonColumn btnMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}