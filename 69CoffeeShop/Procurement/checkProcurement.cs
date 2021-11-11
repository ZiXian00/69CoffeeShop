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

namespace _69CoffeeShop.Procurement
{

    public partial class checkProcurement : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public checkProcurement()
        {
            InitializeComponent();
        }

        private void checkProcurement_Load(object sender, EventArgs e)
        {
            PrintGridView();
        }

        public void PrintGridView()
        {
            dataGridViewProcurement.Rows.Clear();

            string memQuery = "SELECT * FROM procurement ORDER BY proCount ";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(memQuery, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                dataGridViewProcurement.Rows.Add(Class.Utilities.decryption(dr["procurementID"].ToString()), Class.Utilities.decryption(dr["orderedProduct"].ToString()), Class.Utilities.decryption(dr["unitPrice"].ToString()), Class.Utilities.decryption(dr["quantity"].ToString()), Class.Utilities.decryption(dr["procurementDate"].ToString()), Class.Utilities.decryption(dr["supplierID"].ToString()));
            }



            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                foreach (DataGridViewRow row in dataGridViewProcurement.Rows)
                {
                    if (row.Cells["procurementID"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["orderedProduct"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["procurementDate"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["supplierID"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
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

    }
}
