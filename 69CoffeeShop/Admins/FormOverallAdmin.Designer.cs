
namespace _69CoffeeShop.Admins
{
    partial class FormOverallAdmin
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
            this.dataGridViewAdminList = new System.Windows.Forms.DataGridView();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonChangePw = new FontAwesome.Sharp.IconButton();
            this.iconButtonRemove = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdminList
            // 
            this.dataGridViewAdminList.AllowUserToAddRows = false;
            this.dataGridViewAdminList.AllowUserToDeleteRows = false;
            this.dataGridViewAdminList.AllowUserToResizeColumns = false;
            this.dataGridViewAdminList.AllowUserToResizeRows = false;
            this.dataGridViewAdminList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAdminList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewAdminList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAdminList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAdminList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdminList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeName,
            this.employeeID,
            this.employeePosition,
            this.lastCheckIn,
            this.lastCheckOut});
            this.dataGridViewAdminList.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdminList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAdminList.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewAdminList.Name = "dataGridViewAdminList";
            this.dataGridViewAdminList.ReadOnly = true;
            this.dataGridViewAdminList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAdminList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdminList.Size = new System.Drawing.Size(1149, 547);
            this.dataGridViewAdminList.TabIndex = 10;
            this.dataGridViewAdminList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdminList_CellContentClick);
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
            // iconButtonChangePw
            // 
            this.iconButtonChangePw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonChangePw.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonChangePw.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButtonChangePw.IconColor = System.Drawing.Color.Black;
            this.iconButtonChangePw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonChangePw.IconSize = 40;
            this.iconButtonChangePw.Location = new System.Drawing.Point(12, 585);
            this.iconButtonChangePw.Name = "iconButtonChangePw";
            this.iconButtonChangePw.Size = new System.Drawing.Size(217, 45);
            this.iconButtonChangePw.TabIndex = 11;
            this.iconButtonChangePw.Text = "Change my password";
            this.iconButtonChangePw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonChangePw.UseVisualStyleBackColor = true;
            this.iconButtonChangePw.Click += new System.EventHandler(this.iconButtonChangePw_Click);
            // 
            // iconButtonRemove
            // 
            this.iconButtonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonRemove.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRemove.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.iconButtonRemove.IconColor = System.Drawing.Color.Black;
            this.iconButtonRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRemove.IconSize = 40;
            this.iconButtonRemove.Location = new System.Drawing.Point(990, 585);
            this.iconButtonRemove.Name = "iconButtonRemove";
            this.iconButtonRemove.Size = new System.Drawing.Size(156, 45);
            this.iconButtonRemove.TabIndex = 9;
            this.iconButtonRemove.Text = "Remove User";
            this.iconButtonRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRemove.UseVisualStyleBackColor = true;
            this.iconButtonRemove.Click += new System.EventHandler(this.iconButtonRemove_Click);
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonAdd.IconColor = System.Drawing.Color.Black;
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.IconSize = 40;
            this.iconButtonAdd.Location = new System.Drawing.Point(834, 585);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Size = new System.Drawing.Size(150, 45);
            this.iconButtonAdd.TabIndex = 8;
            this.iconButtonAdd.Text = "Add User";
            this.iconButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdd.UseVisualStyleBackColor = true;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // FormOverallAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 642);
            this.Controls.Add(this.iconButtonChangePw);
            this.Controls.Add(this.dataGridViewAdminList);
            this.Controls.Add(this.iconButtonRemove);
            this.Controls.Add(this.iconButtonAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOverallAdmin";
            this.Text = "FormOverallAdmin";
            this.Load += new System.EventHandler(this.FormOverallAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonRemove;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private System.Windows.Forms.DataGridView dataGridViewAdminList;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCheckOut;
        private FontAwesome.Sharp.IconButton iconButtonChangePw;
    }
}