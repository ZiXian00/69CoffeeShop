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

namespace _69CoffeeShop.Suppliers
{
    public partial class viewSupplier : Form
    {

        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        editSupplier editSup;

        public viewSupplier()
        {
            InitializeComponent();
            editSup = new editSupplier();
        }

        private void viewSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_69coffeeshopDataSetSupplier.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this._69coffeeshopDataSetSupplier.supplier);
            PrintGridView();

        }

        public void PrintGridView()
        {
            dataGridViewSupplier.Rows.Clear();

            string memQuery = "SELECT * FROM supplier ORDER BY supplierID";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(memQuery, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                //dataGridViewSupplier.Rows.Add(Class.Utilities.decryption(dr["memberID"].ToString()), Class.Utilities.decryption(dr["memberName"].ToString()), Class.Utilities.decryption(dr["contactNo"].ToString()), Class.Utilities.decryption(dr["dateOfBirth"].ToString()), Class.Utilities.decryption(dr["email"].ToString()), Class.Utilities.decryption(dr["rewardsPoint"].ToString()));
                dataGridViewSupplier.Rows.Add(dr["supplierID"].ToString(), dr["companyName"].ToString(), dr["contactNo"].ToString(), dr["address"].ToString(), dr["contactName"].ToString(), dr["email"].ToString());
            }



            conn.Close();
        }

        private void dataGridViewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                editSup.supID = dataGridViewSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
                editSup.companyName = dataGridViewSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                editSup.contactNo = dataGridViewSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                editSup.contactName = dataGridViewSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                editSup.address = dataGridViewSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                editSup.email = dataGridViewSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
                editSup.UpdateSupplier();
                editSup.ShowDialog();
                PrintGridView();
                return;

            }
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DeleteSupplier(dataGridViewSupplier.Rows[e.RowIndex].Cells[0].Value.ToString());
                    PrintGridView();
                }

                return;

            }
        }

        public static void DeleteSupplier(string id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            string sql = "DELETE FROM supplier WHERE supplierID = @supplierID";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SupplierID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Supplier not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DisplaySearch("SELECT supplierID, companyName, contactName, contactNo, address, email FROM supplier WHERE supplierID LIKE '%" + txtSearch.Text + "%' OR contactNo LIKE '%" + txtSearch.Text + "%' OR companyName LIKE '%" + txtSearch.Text + "%' OR contactName LIKE '%" + txtSearch.Text + "%' OR address LIKE '%" + txtSearch.Text + "%'");
        }

        private void DisplaySearch(String query)
        {
            dataGridViewSupplier.Rows.Clear();

            string memQuery = query;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(memQuery, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
               dataGridViewSupplier.Rows.Add(dr["supplierID"].ToString(), dr["companyName"].ToString(), dr["contactNo"].ToString(), dr["address"].ToString(), dr["contactName"].ToString(), dr["email"].ToString());
            }



            conn.Close();
        }

        

    }
}
