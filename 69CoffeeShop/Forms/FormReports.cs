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


            if (rbInvenReport.Checked == true)
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

                string invenQuery = "Select* FROM inventory Order By invenCount";
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
                this.Refresh();
                conn.Close();

            }
            else if (rbSupplier.Checked == true)
            {
                rptView.Show();
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();


                DataTable tableSup = new DataTable();
                tableSup.Columns.Add(new DataColumn("supplierID"));
                tableSup.Columns.Add(new DataColumn("companyName"));
                tableSup.Columns.Add(new DataColumn("address"));
                tableSup.Columns.Add(new DataColumn("contactNo"));
                tableSup.Columns.Add(new DataColumn("contactName"));
                tableSup.Columns.Add(new DataColumn("email"));

                string supQuery = "Select * FROM supplier Order By supCount";
                MySqlCommand cmdSup = new MySqlCommand(supQuery, conn);
                MySqlDataReader dr = cmdSup.ExecuteReader();


                while (dr.Read())
                {
                    tableSup.Rows.Add(Class.Utilities.decryption(dr["supplierID"].ToString()),
                            Class.Utilities.decryption(dr["companyName"].ToString()),
                            Class.Utilities.decryption(dr["address"].ToString()),
                            Class.Utilities.decryption(dr["contactNo"].ToString()),
                            Class.Utilities.decryption(dr["contactName"].ToString()),
                            Class.Utilities.decryption(dr["email"].ToString()));

                }
                Reports.ReportSupplier rptSup = new Reports.ReportSupplier();
                rptSup.SetDataSource(tableSup);
                rptView.crystalReportViewer1.ReportSource = rptSup;
                rptView.crystalReportViewer1.Refresh();
                this.Refresh();
                conn.Close();
            }
            else if (rbSalesProduct.Checked == true)
            {
                rptView.Show();
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();


                DataTable tableSalesP = new DataTable();
                tableSalesP.Columns.Add(new DataColumn("orderID"));
                tableSalesP.Columns.Add(new DataColumn("productID"));
                tableSalesP.Columns.Add(new DataColumn("quantity"));

                string salesPQuery = "Select * FROM product_order";
                MySqlCommand cmdSalesP = new MySqlCommand(salesPQuery, conn);
                MySqlDataReader dr = cmdSalesP.ExecuteReader();


                while (dr.Read())
                {
                    tableSalesP.Rows.Add(Class.Utilities.decryption(dr["orderID"].ToString()),
                            Class.Utilities.decryption(dr["productID"].ToString()),
                            Class.Utilities.decryption(dr["quantity"].ToString()));
                }


                Reports.ReportSalesProduct rptSalesProduct = new Reports.ReportSalesProduct();
                rptSalesProduct.SetDataSource(tableSalesP);
                rptView.crystalReportViewer1.ReportSource = rptSalesProduct;
                rptView.crystalReportViewer1.Refresh();
                this.Refresh();
                conn.Close();
            }
            else if (rbSales.Checked == true)
            {
                rptView.Show();
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();


                DataTable tableSales = new DataTable();
                tableSales.Columns.Add(new DataColumn("salesID"));
                tableSales.Columns.Add(new DataColumn("orderID"));
                tableSales.Columns.Add(new DataColumn("date"));
                tableSales.Columns.Add(new DataColumn("salesAmount"));

                string salesQuery = "Select salesID, orderID, date, salesAmount FROM sales";
                MySqlCommand cmdSales = new MySqlCommand(salesQuery, conn);
                MySqlDataReader dr = cmdSales.ExecuteReader();


                while (dr.Read())
                {
                    tableSales.Rows.Add(Class.Utilities.decryption(dr["salesID"].ToString()),
                            Class.Utilities.decryption(dr["orderID"].ToString()), 
                            Class.Utilities.decryption(dr["date"].ToString()),
                            Class.Utilities.decryption(dr["salesAmount"].ToString()));
                }


                Reports.ReportSales rptSales = new Reports.ReportSales();
                rptSales.SetDataSource(tableSales);
                rptView.crystalReportViewer1.ReportSource = rptSales;
                rptView.crystalReportViewer1.Refresh();
                this.Refresh();
                conn.Close();
            }
            else if (rbMember.Checked == true)
            {
                rptView.Show();
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();


                DataTable tabelMem = new DataTable();
                tabelMem.Columns.Add(new DataColumn("memberID"));
                tabelMem.Columns.Add(new DataColumn("memberName"));
                tabelMem.Columns.Add(new DataColumn("contactNo"));
                tabelMem.Columns.Add(new DataColumn("dateOfBirth"));
                tabelMem.Columns.Add(new DataColumn("email"));
                tabelMem.Columns.Add(new DataColumn("rewardsPoint"));

                string memQuery = "Select * FROM member Order By memCount";
                MySqlCommand cmdMem = new MySqlCommand(memQuery, conn);
                MySqlDataReader dr = cmdMem.ExecuteReader();


                while (dr.Read())
                {
                    tabelMem.Rows.Add(Class.Utilities.decryption(dr["memberID"].ToString()),
                            Class.Utilities.decryption(dr["memberName"].ToString()),
                            Class.Utilities.decryption(dr["contactNo"].ToString()),
                            Class.Utilities.decryption(dr["dateOfBirth"].ToString()),
                            Class.Utilities.decryption(dr["email"].ToString()),
                            Class.Utilities.decryption(dr["rewardsPoint"].ToString()));
                }


                Reports.ReportMember rptMem = new Reports.ReportMember();
                rptMem.SetDataSource(tabelMem);
                rptView.crystalReportViewer1.ReportSource = rptMem;
                rptView.crystalReportViewer1.Refresh();
                this.Refresh();
                conn.Close();
            }
            else if (rbProcurement.Checked == true)
            {
                rptView.Show();
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();


                DataTable tableProcurement = new DataTable();
                tableProcurement.Columns.Add(new DataColumn("procurementID"));
                tableProcurement.Columns.Add(new DataColumn("orderedProduct"));
                tableProcurement.Columns.Add(new DataColumn("unitPrice"));
                tableProcurement.Columns.Add(new DataColumn("quantity"));
                tableProcurement.Columns.Add(new DataColumn("procurementDate"));
                tableProcurement.Columns.Add(new DataColumn("supplierID"));

                string procurementQuery = "Select * FROM procurement Order By proCount";
                MySqlCommand cmdProcure = new MySqlCommand(procurementQuery, conn);
                MySqlDataReader dr = cmdProcure.ExecuteReader();


                while (dr.Read())
                {
                    tableProcurement.Rows.Add(Class.Utilities.decryption(dr["procurementID"].ToString()),
                            Class.Utilities.decryption(dr["orderedProduct"].ToString()),
                            Class.Utilities.decryption(dr["unitPrice"].ToString()),
                            Class.Utilities.decryption(dr["quantity"].ToString()),
                            Class.Utilities.decryption(dr["procurementDate"].ToString()),
                            Class.Utilities.decryption(dr["supplierID"].ToString()));
                }


                Reports.ReportProcurement rptProcurement = new Reports.ReportProcurement();
                rptProcurement.SetDataSource(tableProcurement);
                rptView.crystalReportViewer1.ReportSource = rptProcurement;
                rptView.crystalReportViewer1.Refresh();
                this.Refresh();
                conn.Close();
            }
        }

    }
}
