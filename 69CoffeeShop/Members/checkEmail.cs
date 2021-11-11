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

namespace _69CoffeeShop.Members
{
    public partial class checkEmail : Form
    {

        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public checkEmail()
        {
            InitializeComponent();
        }
        public void PrintGridView()
        {
            dataGridViewEmail.Rows.Clear();

            string memQuery = "SELECT * FROM email_promotion ORDER BY promoCount ";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(memQuery, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                dataGridViewEmail.Rows.Add(Class.Utilities.decryption(dr["promotionID"].ToString()), Class.Utilities.decryption(dr["memberID"].ToString()), Class.Utilities.decryption(dr["description"].ToString()), Class.Utilities.decryption(dr["date"].ToString()));
            }



            conn.Close();
        }

        private void checkEmail_Load(object sender, EventArgs e)
        {
            PrintGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                foreach (DataGridViewRow row in dataGridViewEmail.Rows)
                {
                    if (row.Cells["memberID"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["promotionID"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["description"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["date"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
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
