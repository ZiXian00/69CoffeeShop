using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

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
        private void FormReports_Load(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(DateTime.Today.Year);
            ArrayList month = new ArrayList();
            month.Add(year + "-01-");
            month.Add(year + "-02-");
            month.Add(year + "-03-");
            month.Add(year + "-04-");
            month.Add(year + "-05-");
            month.Add(year + "-06-");
            month.Add(year + "-07-");
            month.Add(year + "-08-");
            month.Add(year + "-09-");
            month.Add(year + "-10-");
            month.Add(year + "-11-");
            month.Add(year + "-12-");
            cbMonth.DataSource = month;
            cbMonth.SelectedIndex = 0;

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
           

            if (rbInvenReport.Checked == true)
            {

                

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
                rptView.ShowDialog();
                dr.Close();
                conn.Close();
                
                

            }


            else if (rbSupplier.Checked == true)
            {
                
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
                rptView.ShowDialog();
                dr.Close();
                conn.Close();
            }


            else if (rbSalesProduct.Checked == true)
            {
               
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
                rptView.ShowDialog();
                dr.Close();
                conn.Close();
            }


            else if (rbSales.Checked == true)
            {
                
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                if (rbToday.Checked == false && rbMonthly.Checked == false && rbYearly.Checked == false)
                {
                    MessageBox.Show("Please Choose a duration to continue..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {

                    DataTable tableSales = new DataTable();
                    Reports.ReportSales rptSales = new Reports.ReportSales();
                    tableSales.Columns.Add(new DataColumn("salesID"));
                    tableSales.Columns.Add(new DataColumn("orderID"));
                    tableSales.Columns.Add(new DataColumn("date"));
                    tableSales.Columns.Add(new DataColumn("salesAmount"));

                    string salesQuery = "Select salesID, orderID, date, salesAmount FROM sales ORDER BY salesCount";
                    MySqlCommand cmdSales = new MySqlCommand(salesQuery, conn);


                    if (rbToday.Checked == true)
                    {
                        MySqlDataReader dr = cmdSales.ExecuteReader();
                        while (dr.Read())
                        {
                            if ((DateTime.Today.ToString("yyyy-MM-dd")) == Class.Utilities.decryption(dr["date"].ToString()))
                            {
                                tableSales.Rows.Add(Class.Utilities.decryption(dr["salesID"].ToString()),
                                    Class.Utilities.decryption(dr["orderID"].ToString()),
                                    Class.Utilities.decryption(dr["date"].ToString()),
                                    Class.Utilities.decryption(dr["salesAmount"].ToString()));
                            }
                        }
                        rptSales.SetDataSource(tableSales);
                        rptView.crystalReportViewer1.ReportSource = rptSales;
                        rptView.crystalReportViewer1.Refresh();
                        rptView.ShowDialog();
                        dr.Close();
                    }
                    else if (rbMonthly.Checked == true)
                    {
                        MySqlDataReader dr = cmdSales.ExecuteReader();
                        while (dr.Read())
                        {
                            if (Class.Utilities.decryption(dr["date"].ToString()).Contains(cbMonth.Text.ToString()))
                            {
                                tableSales.Rows.Add(Class.Utilities.decryption(dr["salesID"].ToString()),
                                    Class.Utilities.decryption(dr["orderID"].ToString()),
                                    Class.Utilities.decryption(dr["date"].ToString()),
                                    Class.Utilities.decryption(dr["salesAmount"].ToString()));
                            }
                        }
                        rptSales.SetDataSource(tableSales);
                        rptView.crystalReportViewer1.ReportSource = rptSales;
                        rptView.crystalReportViewer1.Refresh();
                        rptView.ShowDialog();
                        dr.Close();
                    }
                    else if (rbYearly.Checked == true)
                    {
                        if (txtYear.Text == "" || txtYear.Text == "0" || txtYear.Text == "00" || txtYear.Text == "000" || txtYear.Text == "0000")
                        {
                            MessageBox.Show("Please enter a valid year.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (txtYear.TextLength < 4)
                        {
                            MessageBox.Show("Please enter a valid year.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MySqlDataReader dr = cmdSales.ExecuteReader();
                            while (dr.Read())
                            {
                                if (Class.Utilities.decryption(dr["date"].ToString()).Contains(txtYear.Text.ToString()))
                                {
                                    tableSales.Rows.Add(Class.Utilities.decryption(dr["salesID"].ToString()),
                                        Class.Utilities.decryption(dr["orderID"].ToString()),
                                        Class.Utilities.decryption(dr["date"].ToString()),
                                        Class.Utilities.decryption(dr["salesAmount"].ToString()));
                                }
                            }
                            rptSales.SetDataSource(tableSales);
                            rptView.crystalReportViewer1.ReportSource = rptSales;
                            rptView.crystalReportViewer1.Refresh();
                            rptView.ShowDialog();
                            dr.Close();
                        }

                    }




                }

                
                conn.Close();
            }


            else if (rbMember.Checked == true)
            {
                
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
                rptView.ShowDialog();
                dr.Close();
                conn.Close();
            }


            else if (rbProcurement.Checked == true)
            {

                MySqlConnection conn = new MySqlConnection(connStr);
                Reports.ReportProcurement rptProcurement = new Reports.ReportProcurement();
                conn.Open();
                if (rbToday.Checked == false && rbMonthly.Checked == false && rbYearly.Checked == false)
                {
                    MessageBox.Show("Please Choose a duration to continue..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    
                    DataTable tableProcurement = new DataTable();

                    tableProcurement.Columns.Add(new DataColumn("procurementID"));
                    tableProcurement.Columns.Add(new DataColumn("orderedProduct"));
                    tableProcurement.Columns.Add(new DataColumn("unitPrice"));
                    tableProcurement.Columns.Add(new DataColumn("quantity"));
                    tableProcurement.Columns.Add(new DataColumn("procurementDate"));
                    tableProcurement.Columns.Add(new DataColumn("supplierID"));

                    string procurementQuery = "Select * FROM procurement Order By proCount";
                    MySqlCommand cmdProcure = new MySqlCommand(procurementQuery, conn);

                    if (rbToday.Checked == true)
                    {

                        MySqlDataReader dr = cmdProcure.ExecuteReader();


                        while (dr.Read())
                        {
                            if ((DateTime.Today.ToString("yyyy-MM-dd")) == Class.Utilities.decryption(dr["procurementDate"].ToString()))
                            {
                                tableProcurement.Rows.Add(Class.Utilities.decryption(dr["procurementID"].ToString()),
                                    Class.Utilities.decryption(dr["orderedProduct"].ToString()),
                                    Class.Utilities.decryption(dr["unitPrice"].ToString()),
                                    Class.Utilities.decryption(dr["quantity"].ToString()),
                                    Class.Utilities.decryption(dr["procurementDate"].ToString()),
                                    Class.Utilities.decryption(dr["supplierID"].ToString()));
                            }

                        }
                        rptProcurement.SetDataSource(tableProcurement);
                        rptView.crystalReportViewer1.ReportSource = rptProcurement;
                        rptView.crystalReportViewer1.Refresh();
                        dr.Close();



                    }
                    else if (rbMonthly.Checked == true)
                    {
                        MySqlDataReader dr = cmdProcure.ExecuteReader();


                        while (dr.Read())
                        {
                            if (Class.Utilities.decryption(dr["procurementDate"].ToString()).Contains(cbMonth.Text.ToString()))
                            {
                                tableProcurement.Rows.Add(Class.Utilities.decryption(dr["procurementID"].ToString()),
                                    Class.Utilities.decryption(dr["orderedProduct"].ToString()),
                                    Class.Utilities.decryption(dr["unitPrice"].ToString()),
                                    Class.Utilities.decryption(dr["quantity"].ToString()),
                                    Class.Utilities.decryption(dr["procurementDate"].ToString()),
                                    Class.Utilities.decryption(dr["supplierID"].ToString()));
                            }

                        }
                        rptProcurement.SetDataSource(tableProcurement);
                        rptView.crystalReportViewer1.ReportSource = rptProcurement;
                        rptView.crystalReportViewer1.Refresh();
                        dr.Close();
                    }
                    else if (rbYearly.Checked == true)
                    {

                        if (txtYear.Text == "" || txtYear.Text == "0" || txtYear.Text == "00" || txtYear.Text == "000" || txtYear.Text == "0000")
                        {
                            MessageBox.Show("Please enter a valid year.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (txtYear.TextLength < 4)
                        {
                            MessageBox.Show("Please enter a valid year.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MySqlDataReader dr = cmdProcure.ExecuteReader();


                            while (dr.Read())
                            {
                                if (Class.Utilities.decryption(dr["procurementDate"].ToString()).Contains(txtYear.Text.ToString()))
                                {
                                    tableProcurement.Rows.Add(Class.Utilities.decryption(dr["procurementID"].ToString()),
                                        Class.Utilities.decryption(dr["orderedProduct"].ToString()),
                                        Class.Utilities.decryption(dr["unitPrice"].ToString()),
                                        Class.Utilities.decryption(dr["quantity"].ToString()),
                                        Class.Utilities.decryption(dr["procurementDate"].ToString()),
                                        Class.Utilities.decryption(dr["supplierID"].ToString()));
                                }

                            }
                            rptProcurement.SetDataSource(tableProcurement);
                            rptView.crystalReportViewer1.ReportSource = rptProcurement;
                            rptView.crystalReportViewer1.Refresh();
                            dr.Close();
                        }
                    }


                }

                rptView.ShowDialog();
                conn.Close();
            }


            else if (rbPayroll.Checked == true)
            {
                
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();


                DataTable tablePay = new DataTable();
                tablePay.Columns.Add(new DataColumn("employeeId"));
                tablePay.Columns.Add(new DataColumn("totalWorkingHours"));
                tablePay.Columns.Add(new DataColumn("totalWorkingDays"));
                tablePay.Columns.Add(new DataColumn("netPay"));

                string payQuery = "Select employeeID, totalWorkingHours, totalWorkingDays, netPay FROM payroll_record";
                MySqlCommand cmdPay = new MySqlCommand(payQuery, conn);
                MySqlDataReader dr = cmdPay.ExecuteReader();


                while (dr.Read())
                {
                    tablePay.Rows.Add(Class.Utilities.decryption(dr["employeeID"].ToString()),
                            Class.Utilities.decryption(dr["totalWorkingHours"].ToString()),
                            Class.Utilities.decryption(dr["totalWorkingDays"].ToString()),
                            Class.Utilities.decryption(dr["netPay"].ToString()));
                }


                Reports.ReportPayroll rptPay = new Reports.ReportPayroll();
                rptPay.SetDataSource(tablePay);
                rptView.crystalReportViewer1.ReportSource = rptPay;
                rptView.crystalReportViewer1.Refresh();
                rptView.ShowDialog();
                dr.Close();
                conn.Close();
            }
        }

        private void rbSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSales.Checked == true)
            {
                gbDuration.Visible = true;
                gbMonth.Visible = false;
                gbYear.Visible = false;
                rbToday.Checked = false;
                rbMonthly.Checked = false;
                rbYearly.Checked = false;
            }


        }

        private void rbProcurement_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProcurement.Checked == true)
            {
                gbDuration.Visible = true;
                gbMonth.Visible = false;
                gbYear.Visible = false;
                rbToday.Checked = false;
                rbMonthly.Checked = false;
                rbYearly.Checked = false;
            }


        }

        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonthly.Checked == true)
            {
                gbMonth.Visible = true;
                gbYear.Visible = false;
            }


        }

        private void rbYearly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYearly.Checked == true)
            {
                gbMonth.Visible = false;
                gbYear.Visible = true;
                txtYear.Text = "";
                txtYear.Focus();
            }


        }
        private void rbToday_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToday.Checked == true)
            {
                gbMonth.Visible = false;
                gbYear.Visible = false;
            }
        }

        private void rbInvenReport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInvenReport.Checked == true)
            {
                gbDuration.Visible = false;
                gbMonth.Visible = false;
                gbYear.Visible = false;
            }
        }

        private void rbSalesProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSalesProduct.Checked == true)
            {
                gbDuration.Visible = false;
                gbMonth.Visible = false;
                gbYear.Visible = false;
            }
        }

        private void rbSupplier_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSupplier.Checked == true)
            {
                gbDuration.Visible = false;
                gbMonth.Visible = false;
                gbYear.Visible = false;
            }
        }

        private void rbMember_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMember.Checked == true)
            {
                gbDuration.Visible = false;
                gbMonth.Visible = false;
                gbYear.Visible = false;
            }
        }

        private void rbPayroll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPayroll.Checked == true)
            {
                gbDuration.Visible = true;
                gbMonth.Visible = false;
                gbYear.Visible = false;
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
