
namespace _69CoffeeShop.Employees
{
    partial class FormOverallEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEmployeeList = new System.Windows.Forms.DataGridView();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.iconButtonProfile = new FontAwesome.Sharp.IconButton();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployeeList
            // 
            this.dataGridViewEmployeeList.AllowUserToAddRows = false;
            this.dataGridViewEmployeeList.AllowUserToDeleteRows = false;
            this.dataGridViewEmployeeList.AllowUserToResizeColumns = false;
            this.dataGridViewEmployeeList.AllowUserToResizeRows = false;
            this.dataGridViewEmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployeeList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewEmployeeList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewEmployeeList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEmployeeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeName,
            this.employeeID,
            this.employeePosition,
            this.lastCheckIn,
            this.lastCheckOut});
            this.dataGridViewEmployeeList.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployeeList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmployeeList.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewEmployeeList.Name = "dataGridViewEmployeeList";
            this.dataGridViewEmployeeList.ReadOnly = true;
            this.dataGridViewEmployeeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployeeList.Size = new System.Drawing.Size(1119, 540);
            this.dataGridViewEmployeeList.TabIndex = 8;
            this.dataGridViewEmployeeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployeeList_CellDoubleClick);
            // 
            // employeeName
            // 
            this.employeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeName.HeaderText = "Name";
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "ID";
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.Width = 150;
            // 
            // employeePosition
            // 
            this.employeePosition.HeaderText = "Position";
            this.employeePosition.Name = "employeePosition";
            this.employeePosition.ReadOnly = true;
            this.employeePosition.Width = 150;
            // 
            // lastCheckIn
            // 
            this.lastCheckIn.HeaderText = "Last Checked In";
            this.lastCheckIn.Name = "lastCheckIn";
            this.lastCheckIn.ReadOnly = true;
            this.lastCheckIn.Width = 200;
            // 
            // lastCheckOut
            // 
            this.lastCheckOut.HeaderText = "Last Checked Out";
            this.lastCheckOut.Name = "lastCheckOut";
            this.lastCheckOut.ReadOnly = true;
            this.lastCheckOut.Width = 200;
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(209)))), ((int)(((byte)(68)))));
            this.iconButtonAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAdd.ForeColor = System.Drawing.Color.White;
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonAdd.IconColor = System.Drawing.Color.White;
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.IconSize = 35;
            this.iconButtonAdd.Location = new System.Drawing.Point(769, 590);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Size = new System.Drawing.Size(178, 43);
            this.iconButtonAdd.TabIndex = 9;
            this.iconButtonAdd.Text = "New Employee";
            this.iconButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdd.UseVisualStyleBackColor = false;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // iconButtonProfile
            // 
            this.iconButtonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonProfile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonProfile.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButtonProfile.IconColor = System.Drawing.Color.Black;
            this.iconButtonProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonProfile.IconSize = 35;
            this.iconButtonProfile.Location = new System.Drawing.Point(953, 590);
            this.iconButtonProfile.Name = "iconButtonProfile";
            this.iconButtonProfile.Size = new System.Drawing.Size(178, 43);
            this.iconButtonProfile.TabIndex = 10;
            this.iconButtonProfile.Text = "Employee Profile";
            this.iconButtonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonProfile.UseVisualStyleBackColor = true;
            this.iconButtonProfile.Click += new System.EventHandler(this.iconButtonProfile_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(786, 15);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(151, 18);
            this.labelSearch.TabIndex = 17;
            this.labelSearch.Text = "Search by name :  ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(943, 12);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(188, 25);
            this.textBoxSearch.TabIndex = 16;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // FormOverallEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1143, 637);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.iconButtonProfile);
            this.Controls.Add(this.iconButtonAdd);
            this.Controls.Add(this.dataGridViewEmployeeList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOverallEmployee";
            this.Text = "FormOverallEmployee";
            this.Load += new System.EventHandler(this.FormOverallEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEmployeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCheckOut;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private FontAwesome.Sharp.IconButton iconButtonProfile;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}