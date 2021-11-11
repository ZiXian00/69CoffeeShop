using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Inventories
{
    public partial class checkInventories : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        editInventories edtInven;
        Procurement.newProcurement newPro;
        public checkInventories()
        {
            InitializeComponent();
            edtInven = new editInventories();
            newPro = new Procurement.newProcurement();
        }

        public void PrintGridView()
        {
            dataGridViewInventory.Rows.Clear();

            string memQuery = "SELECT * FROM inventory ORDER BY invenCount ";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(memQuery, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                dataGridViewInventory.Rows.Add(Class.Utilities.decryption(dr["inventoryID"].ToString()), Class.Utilities.decryption(dr["inventoryName"].ToString()), Class.Utilities.decryption(dr["description"].ToString()), Class.Utilities.decryption(dr["unitPrice"].ToString()), Class.Utilities.decryption(dr["quantity"].ToString()), Class.Utilities.decryption(dr["supplierID"].ToString()));
            }



            conn.Close();
        }

        private void checkInventories_Load(object sender, EventArgs e)
        {
            PrintGridView();
        }

        public static void DeleteInventory(string id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            string sql = "DELETE FROM inventory WHERE inventoryID = @inventoryID";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@inventoryID", MySqlDbType.VarChar).Value = Class.Utilities.encryption(id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Inventory not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                foreach (DataGridViewRow row in dataGridViewInventory.Rows)
                {
                    if (row.Cells["inventoryID"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["inventoryName"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["description"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
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
                PrintGridView();
            }
        }

        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                edtInven.invenID = dataGridViewInventory.Rows[e.RowIndex].Cells[0].Value.ToString();
                edtInven.invenName = dataGridViewInventory.Rows[e.RowIndex].Cells[1].Value.ToString();
                edtInven.description = dataGridViewInventory.Rows[e.RowIndex].Cells[2].Value.ToString();
                edtInven.unitPrice = dataGridViewInventory.Rows[e.RowIndex].Cells[3].Value.ToString();
                edtInven.quantity = dataGridViewInventory.Rows[e.RowIndex].Cells[4].Value.ToString();
                edtInven.supId = dataGridViewInventory.Rows[e.RowIndex].Cells[5].Value.ToString();
                edtInven.UpdateInventory();
                edtInven.ShowDialog();
                PrintGridView();
                return;
            }

            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DeleteInventory(dataGridViewInventory.Rows[e.RowIndex].Cells[0].Value.ToString());
                    PrintGridView();
                }

                return;
            }

            if (e.ColumnIndex == 8)
            {
                newPro.InvenID = dataGridViewInventory.Rows[e.RowIndex].Cells[0].Value.ToString();
                newPro.InvenName = dataGridViewInventory.Rows[e.RowIndex].Cells[1].Value.ToString();
                newPro.Description = dataGridViewInventory.Rows[e.RowIndex].Cells[2].Value.ToString();
                newPro.unitPrice = dataGridViewInventory.Rows[e.RowIndex].Cells[3].Value.ToString();
                newPro.SupID = dataGridViewInventory.Rows[e.RowIndex].Cells[5].Value.ToString();
                newPro.ShowDialog();
                return;
            }

        }
    }
}
