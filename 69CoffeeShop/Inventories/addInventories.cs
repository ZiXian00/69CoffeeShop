using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class addInventories : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public addInventories()
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

        private void addInventories_Load(object sender, EventArgs e)
        {
            LoadSupID();
            LoadInvenID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            /*
             PROBLEM
             */
            if(txtInventoryName.Text == ""|| txtDescription.Text == "" ||txtQty.Text == "" ||txtUnitPrice.Text == "" || txtSupID.Text == "")
            {
                MessageBox.Show("Please fill in all the details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string query = "Insert into inventory (inventoryID, inventoryName, description, unitPrice, quantity, supplierID, invenCount) values (@inventoryID, @inventoryName, @description, @unitPrice, @quantity, @supplierID, @invenCount)";
                MySqlCommand insertCmd = new MySqlCommand(query, conn);
                insertCmd.Parameters.AddWithValue("@inventoryID", Class.Utilities.encryption(lblInvenID.Text));
                insertCmd.Parameters.AddWithValue("@inventoryName", Class.Utilities.encryption(txtInventoryName.Text));
                insertCmd.Parameters.AddWithValue("@description", Class.Utilities.encryption(txtDescription.Text));
                insertCmd.Parameters.AddWithValue("@unitPrice", Class.Utilities.encryption(txtUnitPrice.Text));
                insertCmd.Parameters.AddWithValue("@quantity", Class.Utilities.encryption(txtQty.Text));
                insertCmd.Parameters.AddWithValue("@supplierID", Class.Utilities.encryption(txtSupID.Text));
                insertCmd.Parameters.AddWithValue("@invenCount", lblCount.Text.Trim());
                try
                {
                    insertCmd.ExecuteNonQuery();
                    if (MessageBox.Show("Inventory saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        txtInventoryName.Text = "";
                        txtDescription.Text = "";
                        txtUnitPrice.Text = "";
                        txtQty.Text = "";
                        txtSupID.Text = "";
                        LoadInvenID();
                    }


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Inventory not save. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
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

        private void LoadInvenID()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "select invenCount from inventory ORDER BY invenCount DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int currentCount = Convert.ToInt32(dr.GetValue(0));
                currentCount++;
                string invenId = "I" + String.Format("{0:0000}", currentCount);
                lblInvenID.Text = invenId;
                lblCount.Text = currentCount.ToString();


            }
            else
            {
                lblInvenID.Text = "I0001";
                lblCount.Text = "1";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInventoryName.Text = txtDescription.Text = txtQty.Text = txtUnitPrice.Text = string.Empty;
        }

        private void dataGridViewSupId_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                txtSupID.Text = dataGridViewSupId.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                    else if(row.Cells["companyName"].Value.ToString().ToUpper().Contains(txtSupID.Text.ToUpper()))
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
    }
}
