using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Inventories
{
    public partial class editInventories : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public string invenID, invenName, description, unitPrice, quantity, supId;
        public editInventories()
        {
            InitializeComponent();
        }
        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtUnitPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(txtUnitPrice.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtInvenName.Text == "" || txtDescription.Text == "" || txtQty.Text == "" || txtUnitPrice.Text == "" || txtSupID.Text == "")
            {
                MessageBox.Show("Please fill in all the details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                string sql = "UPDATE inventory SET inventoryName = @inventoryName, description= @description, unitPrice= @unitPrice, quantity= @quantity, supplierID = @supplierID WHERE inventoryID = @inventoryID";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@inventoryID", Class.Utilities.encryption(lblInvenID.Text));
                cmd.Parameters.AddWithValue("@inventoryName", Class.Utilities.encryption(txtInvenName.Text));
                cmd.Parameters.AddWithValue("@description", Class.Utilities.encryption(txtDescription.Text));
                cmd.Parameters.AddWithValue("@unitPrice", Class.Utilities.encryption(txtUnitPrice.Text));
                cmd.Parameters.AddWithValue("@quantity", Class.Utilities.encryption(txtQty.Text));
                cmd.Parameters.AddWithValue("@supplierID", Class.Utilities.encryption(txtSupID.Text));
                try
                {
                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("Update Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();


                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Inventory not update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();

            }
        }

        private void editInventories_Load(object sender, EventArgs e)
        {
            LoadSupID();
        }

        private void LoadSupID()
        {

            dataGridViewSupId.Rows.Clear();

            string supIdQuery = "SELECT supplierID, companyName FROM supplier ORDER BY supCount";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(supIdQuery, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                dataGridViewSupId.Rows.Add(Class.Utilities.decryption(dr["supplierID"].ToString()), Class.Utilities.decryption(dr["companyName"].ToString()));
            }


        }

        private void txtSupID_TextChanged(object sender, EventArgs e)
        {
            if (txtSupID.Text != string.Empty)
            {
                foreach (DataGridViewRow row in dataGridViewSupId.Rows)
                {
                    if (row.Cells["supplierID"].Value.ToString().ToUpper().Contains(txtSupID.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["companyName"].Value.ToString().ToUpper().Contains(txtSupID.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                LoadSupID();
            }
        }

        private void dataGridViewSupId_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                txtSupID.Text = dataGridViewSupId.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        public void UpdateInventory()
        {
            lblInvenID.Text = invenID;
            txtInvenName.Text = invenName;
            txtDescription.Text = description;
            txtUnitPrice.Text = unitPrice;
            txtQty.Text = quantity;
            txtSupID.Text = supId;
        }
    }
}
