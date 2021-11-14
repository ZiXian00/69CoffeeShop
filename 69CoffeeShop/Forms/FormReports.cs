using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Forms
{
    public partial class FormReports : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        Reports.ReportViewer rptView = new Reports.ReportViewer();
        public FormReports()
        {
            InitializeComponent();

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            if(rbInvenReport.Checked == true)
            {
                rptView.Show();
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();


                DataTable tableInven = new DataTable();
                tableInven.Columns.Add(new DataColumn("inventoryID"));
                tableInven.Columns.Add(new DataColumn("inventoryName"));
                tableInven.Columns.Add(new DataColumn("description"));
                tableInven.Columns.Add(new DataColumn("unitPrice"));
                tableInven.Columns.Add(new DataColumn("quantity"));
                tableInven.Columns.Add(new DataColumn("supplierID"));

                string invenQuery = "Select* FROM inventory";
                MySqlCommand cmdInventory = new MySqlCommand(invenQuery, conn);
                MySqlDataReader dr = cmdInventory.ExecuteReader();


                while (dr.Read())
                {
                    tableInven.Rows.Add(Class.Utilities.decryption(dr["inventoryID"].ToString()),
                            Class.Utilities.decryption(dr["inventoryName"].ToString()),
                            Class.Utilities.decryption(dr["description"].ToString()),
                            Class.Utilities.decryption(dr["unitPrice"].ToString()),
                            Class.Utilities.decryption(dr["quantity"].ToString()),
                            Class.Utilities.decryption(dr["supplierID"].ToString()));
                    
                }
                Reports.ReportInventory rptInven = new Reports.ReportInventory();
                rptInven.SetDataSource(tableInven);
                rptView.crystalReportViewer1.ReportSource = rptInven;
                rptView.crystalReportViewer1.Refresh();
                conn.Close();
            }
        }
    }
}
