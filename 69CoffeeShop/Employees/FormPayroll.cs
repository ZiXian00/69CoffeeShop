using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _69CoffeeShop.Employees
{
    public partial class FormPayroll : Form
    {
        ErrorProvider error = new ErrorProvider();
        Class.Connection connection = new Class.Connection();
        DateTime dt = DateTime.Now;
        int lastMonth;
        string wagesType;
        double requiredHours;

        public FormPayroll()
        {
            InitializeComponent();
            lastMonth = dt.AddMonths(-1).Month;
            requiredHours = (8 * DateTime.DaysInMonth(DateTime.Now.Year, lastMonth));
            labelInfo.Text = "There is " + DateTime.DaysInMonth(DateTime.Now.Year, lastMonth) + " days in previous month. " + Environment.NewLine +
                "Total of " + requiredHours.ToString("0") + " hours is required for full time employee." + Environment.NewLine +
                "Exceeded time on employee record will be calculated as OT";
        }

        double salary_rate = 0;
        double hours = 0;

        private void iconButtonCheck_Click(object sender, EventArgs e)
        {
            Boolean exist;
            error.Clear();
            if (textBoxID.Text == "")
            {
                error.SetError(textBoxID, "Please enter employee ID to continue");
            }
            else
            {
                textBoxOtherDD.Text = "";
                textBoxOtherDD1.Text = "";
                textBoxOtherDD2.Text = "";
                textBoxOtherDeduct.Text = "";
                textBoxOtherDeduct1.Text = "";
                textBoxOtherDeduct2.Text = "";
                textBoxOtherInc.Text = "";
                textBoxOtherInc1.Text = "";
                textBoxOtherInc2.Text = "";
                textBoxOtherIncD.Text = "";
                textBoxOtherIncD1.Text = "";
                textBoxOtherIncD2.Text = "";

                string checkEmpQry = "select * from employees where employeeID = @id";
                MySqlCommand checkEmpCmd = new MySqlCommand(checkEmpQry, connection.conn);
                connection.conn.Open();
                checkEmpCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(textBoxID.Text));
                MySqlDataReader checkEmpRdr = checkEmpCmd.ExecuteReader();

                if (checkEmpRdr.Read())
                {
                    exist = true;
                    textBoxName.Text = Class.Utilities.decryption(checkEmpRdr["employeeName"].ToString());
                    textBoxPosition.Text = Class.Utilities.decryption(checkEmpRdr["position"].ToString());
                    textBoxStatus.Text = Class.Utilities.decryption(checkEmpRdr["employmentStatus"].ToString());
                    textBoxBankName.Text = Class.Utilities.decryption(checkEmpRdr["bankName"].ToString());
                    textBoxBankAcc.Text = Class.Utilities.decryption(checkEmpRdr["bankAccountNo"].ToString());

                    if (Class.Utilities.decryption(checkEmpRdr["employmentStatus"].ToString()).ToUpper() == "FULL TIME")
                    {
                        textBoxRate.Enabled = false;
                        textBoxRate.Text = "-";
                        textBoxRate.ReadOnly = true;
                        textBoxRate.TextAlign = HorizontalAlignment.Center;

                        wagesType = "Fixed Salary";

                        textBoxSalary.Enabled = true;
                        textBoxSalary.Text = Class.Utilities.decryption(checkEmpRdr["salary_rate"].ToString());
                        textBoxSalary.ReadOnly = false;
                        textBoxSalary.TextAlign = HorizontalAlignment.Right;
                    }
                    else if (Class.Utilities.decryption(checkEmpRdr["employmentStatus"].ToString()).ToUpper() == "PART TIME")
                    {
                        textBoxRate.Enabled = true;
                        textBoxRate.Text = Class.Utilities.decryption(checkEmpRdr["salary_rate"].ToString());
                        textBoxRate.ReadOnly = false;
                        textBoxRate.TextAlign = HorizontalAlignment.Right;

                        wagesType = "Rate per Hour";

                        textBoxSalary.Enabled = false;
                        textBoxSalary.Text = "-";
                        textBoxSalary.ReadOnly = true;
                        textBoxSalary.TextAlign = HorizontalAlignment.Center;
                    }
                }
                else
                {
                    exist = false;
                    MessageBox.Show("No employee record found with entered ID. ", "No record found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                checkEmpRdr.Close();
                connection.conn.Close();

                if (exist == true && checkRecordExist() == false)
                {
                    hours = 0;
                    string getWorkingHoursQry = "select workingHours from employee_duty_record where employeeID = @id AND month = @month AND year = @year";
                    MySqlCommand getWorkingHoursCmd = new MySqlCommand(getWorkingHoursQry, connection.conn);
                    getWorkingHoursCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(textBoxID.Text));
                    getWorkingHoursCmd.Parameters.AddWithValue("@month", Class.Utilities.encryption(DateTime.Now.AddMonths(-1).ToString("MMM")));
                    getWorkingHoursCmd.Parameters.AddWithValue("@year", Class.Utilities.encryption(DateTime.Now.ToString("yyyy")));
                    connection.conn.Open();
                    MySqlDataReader getWorkingHoursRdr = getWorkingHoursCmd.ExecuteReader();

                    if (getWorkingHoursRdr.HasRows)
                    {
                        try
                        {
                            while (getWorkingHoursRdr.Read())
                            {
                                hours += Double.Parse(Class.Utilities.decryption(getWorkingHoursRdr["workingHours"].ToString()));
                                textBoxHours.Text = hours.ToString("0");

                                groupBox1.Visible = true;
                                iconButtonAdd.Visible = true;
                                domainUpDownEPF.SelectedIndex = 4;
                            }

                            if (hours - requiredHours < 0)
                            {
                                textBoxHours.ForeColor = Color.Red;

                                textBoxOtherDD.Text = "Short of working hour(s)";
                            }

                            calculateGrossPay();
                        }
                        catch
                        {
                            MessageBox.Show("No duty record found with entered ID in previous month. ", "No record found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No duty record for this employee in previous month", "No record found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = false;

                        iconButtonAdd.Visible = false;
                    }

                    getWorkingHoursRdr.Close();
                }
                connection.conn.Close();
            }
        }

        private Boolean checkRecordExist()
        {
            string payrollExistQry = "select * from payroll_record where employeeID = @id";
            MySqlCommand payrollExistCmd = new MySqlCommand(payrollExistQry, connection.conn);
            payrollExistCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(textBoxID.Text));
            connection.conn.Open();
            MySqlDataReader payrollExistRdr = payrollExistCmd.ExecuteReader();

            DateTime recordDate;
            while (payrollExistRdr.Read())
            {
                recordDate = DateTime.ParseExact(Class.Utilities.decryption(payrollExistRdr.GetString(9)), "yyyy-MM-dd", CultureInfo.InvariantCulture);

                if (recordDate.Month == DateTime.Now.Month && recordDate.Year == DateTime.Now.Year)
                {
                    MessageBox.Show("This employee already has payroll record created on current month." + Environment.NewLine + Environment.NewLine
                        + "Please delete previous record before adding new record.", "Duplicate Record !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    groupBox1.Visible = false;
                    iconButtonAdd.Visible = false;
                    payrollExistRdr.Close();
                    connection.conn.Close();
                    return true;
                }
                else
                {
                    payrollExistRdr.Close();
                    connection.conn.Close();
                    return false;
                }
            }

            connection.conn.Close();
            return false;
        }

        double grossPay = 0;
        private void calculateGrossPay()
        {
            double days = hours / 8;

            if (days > DateTime.DaysInMonth(DateTime.Now.Year, lastMonth))
            {
                days = DateTime.DaysInMonth(DateTime.Now.Year, lastMonth);
            }

            double overtime = hours - requiredHours;

            if (overtime < 1)
            {
                overtime = 0;
            }

            textBoxOT.Text = overtime.ToString("0");

            textBoxDays.Text = days.ToString("0");

            if (textBoxSalary.Text != "-")
            {
                salary_rate = Double.Parse(textBoxSalary.Text);
                grossPay = salary_rate + (overtime * (double.Parse(textBoxOTRate.Text.ToString())));
            }
            else if (textBoxRate.Text != "-")
            {
                salary_rate = Double.Parse(textBoxRate.Text);
                grossPay = (salary_rate * hours);
            }

            if (textBoxOtherInc.Text != "")
            {
                double otherIncome = double.Parse(textBoxOtherInc.Text);
                grossPay += otherIncome;
            }

            if (textBoxOtherInc1.Text != "")
            {
                double otherIncome = double.Parse(textBoxOtherInc1.Text);
                grossPay += otherIncome;
            }

            if (textBoxOtherInc2.Text != "")
            {
                double otherIncome = double.Parse(textBoxOtherInc2.Text);
                grossPay += otherIncome;
            }

            textBoxGrossSalary.Text = grossPay.ToString("RM 0.00");
            calculateDeduction();
        }

        private void calculateDeduction()
        {
            string epfRate = domainUpDownEPF.SelectedItem.ToString();
            epfRate = epfRate.Remove(epfRate.Length - 1, 1);
            double epf_rate = double.Parse(epfRate);

            double epfDeduction = (grossPay * (epf_rate / 100));
            double socsoDeduction = grossPay * (0.005);
            double totalDeduction = epfDeduction + socsoDeduction;

            if (textBoxOtherDeduct.Text != "")
            {
                double otherDeduction = double.Parse(textBoxOtherDeduct.Text);
                totalDeduction += otherDeduction;
            }

            if (textBoxOtherDeduct1.Text != "")
            {
                double otherDeduction = double.Parse(textBoxOtherDeduct1.Text);
                totalDeduction += otherDeduction;
            }

            if (textBoxOtherDeduct1.Text != "")
            {
                double otherDeduction = double.Parse(textBoxOtherDeduct1.Text);
                totalDeduction += otherDeduction;
            }

            double netSalary = grossPay - totalDeduction;

            textBoxEPF.Text = epfDeduction.ToString("0.00");
            textBoxSocso.Text = socsoDeduction.ToString("0.00");
            textBoxTotalDeduction.Text = totalDeduction.ToString("RM 0.00");
            textBoxNetSalary.Text = netSalary.ToString("RM 0.00");
        }

        private void FormPayroll_Load(object sender, EventArgs e)
        {
            textBoxID.Select();
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            if (checkRecordExist() == false)
            {
                if (validation() == true)
                {
                    string payrollQry = "insert into payroll_record (employeeID, totalWorkingHours, overtime, EPF_rate, EPF_deduction, grossPay, totalDeduction, " +
               "netPay, date, overtimeRate, socso, wagesType, totalWorkingDays, status) values" +
               " (@id, @hours, @ot, @epfRate, @epfDeduction, @grossPay, @totalDeduction, @netPay, @date, @otRate, @socso, @wagesType, @days, @status)";
                    MySqlCommand payrollCmd = new MySqlCommand(payrollQry, connection.conn);
                    connection.conn.Open();
                    payrollCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(textBoxID.Text));
                    payrollCmd.Parameters.AddWithValue("@hours", Class.Utilities.encryption(textBoxHours.Text));
                    payrollCmd.Parameters.AddWithValue("@ot", Class.Utilities.encryption(textBoxOT.Text));
                    payrollCmd.Parameters.AddWithValue("@epfRate", Class.Utilities.encryption(domainUpDownEPF.SelectedItem.ToString()));
                    payrollCmd.Parameters.AddWithValue("@epfDeduction", Class.Utilities.encryption(textBoxEPF.Text));
                    payrollCmd.Parameters.AddWithValue("@grossPay", Class.Utilities.encryption(textBoxGrossSalary.Text.Substring(2)));
                    payrollCmd.Parameters.AddWithValue("@totalDeduction", Class.Utilities.encryption(textBoxTotalDeduction.Text.Substring(2)));
                    payrollCmd.Parameters.AddWithValue("@netPay", Class.Utilities.encryption(textBoxNetSalary.Text.Substring(2)));
                    payrollCmd.Parameters.AddWithValue("@date", Class.Utilities.encryption(DateTime.Now.ToString("yyyy-MM-dd")));
                    payrollCmd.Parameters.AddWithValue("@otRate", Class.Utilities.encryption(textBoxOTRate.Text));
                    payrollCmd.Parameters.AddWithValue("@socso", Class.Utilities.encryption(textBoxSocso.Text));
                    payrollCmd.Parameters.AddWithValue("@wagesType", Class.Utilities.encryption(wagesType));
                    payrollCmd.Parameters.AddWithValue("@days", Class.Utilities.encryption(textBoxDays.Text));
                    payrollCmd.Parameters.AddWithValue("@status", Class.Utilities.encryption("Pending"));
                    payrollCmd.ExecuteNonQuery();

                    connection.conn.Close();

                    MessageBox.Show("1 record has been added." + Environment.NewLine + Environment.NewLine + "Status : Pending", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    groupBox1.Visible = false;
                    textBoxBankAcc.Text = "";
                    textBoxBankName.Text = "";
                    textBoxID.Text = "";
                    textBoxName.Text = "";
                    textBoxPosition.Text = "";
                    textBoxStatus.Text = "";
                    iconButtonAdd.Visible = false;
                }
            }
        }

        private void domainUpDownEPF_SelectedItemChanged(object sender, EventArgs e)
        {
            calculateDeduction();
        }

        private Boolean validation()
        {
            error.Clear();
            if (textBoxOtherIncD.Text != "")
            {
                if (textBoxOtherInc.Text == "")
                {
                    error.SetError(textBoxOtherInc, "This field must not be empty.");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            if (textBoxOtherIncD1.Text != "")
            {
                if (textBoxOtherInc1.Text == "")
                {
                    error.SetError(textBoxOtherInc1, "This field must not be empty.");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            if (textBoxOtherIncD2.Text != "")
            {
                if (textBoxOtherInc2.Text == "")
                {
                    error.SetError(textBoxOtherInc2, "This field must not be empty.");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            if (textBoxOtherDD.Text != "")
            {
                if (textBoxOtherDeduct.Text == "")
                {
                    error.SetError(textBoxOtherDeduct, "This field must not be empty.");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            if (textBoxOtherDD1.Text != "")
            {
                if (textBoxOtherDeduct.Text == "")
                {
                    error.SetError(textBoxOtherDeduct, "This field must not be empty.");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            if (textBoxOtherDD2.Text != "")
            {
                if (textBoxOtherDeduct1.Text == "")
                {
                    error.SetError(textBoxOtherDeduct1, "This field must not be empty.");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["payrollList"])
            {
                refreshGridView();
            }
        }

        private void refreshGridView()
        {
            dataGridViewPayroll.Rows.Clear();

            string payrollRecordQry = "select * from employees e INNER JOIN payroll_record p ON e.employeeID = p.employeeID ORDER BY p.payroll_id DESC";
            MySqlCommand payrollRecordCmd = new MySqlCommand(payrollRecordQry, connection.conn);
            connection.conn.Open();
            MySqlDataReader payrollRecordRdr = payrollRecordCmd.ExecuteReader();

            while (payrollRecordRdr.Read())
            {
                //DateTime getDate = (DateTime);
                string _date = Class.Utilities.decryption(payrollRecordRdr["date"].ToString());

                //Double getGross = (Double);
                string _gross = Class.Utilities.decryption(payrollRecordRdr["grossPay"].ToString());

                //Double getNet = (Double);
                string _net = Class.Utilities.decryption(payrollRecordRdr["netPay"].ToString());

                dataGridViewPayroll.Rows.Add(Class.Utilities.decryption(payrollRecordRdr["employeeName"].ToString()), Class.Utilities.decryption(payrollRecordRdr["employeeID"].ToString()), Class.Utilities.decryption(payrollRecordRdr["position"].ToString()), _date,
                    Class.Utilities.decryption(payrollRecordRdr["wagesType"].ToString()), Class.Utilities.decryption(payrollRecordRdr["totalWorkingDays"].ToString()), Class.Utilities.decryption(payrollRecordRdr["totalWorkingHours"].ToString()), _gross,
                    _net, Class.Utilities.decryption(payrollRecordRdr["status"].ToString()));
            }

            payrollRecordRdr.Close();
            connection.conn.Close();
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPayroll.SelectedRows.Count == 0 && dataGridViewPayroll.SelectedCells.Count == 0)
            {
                dataGridViewPayroll.Rows[0].Selected = true;
            }

            int rowIndex = dataGridViewPayroll.SelectedCells[0].RowIndex;

            DialogResult ds = MessageBox.Show("Delete selected record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ds == DialogResult.Yes)
            {
                if (dataGridViewPayroll.Rows[rowIndex].Cells["status"].Value.ToString() != "Complete")
                {
                    string deletePayrollRecordQry = "delete from payroll_record where employeeID = @id AND date = @date";
                    MySqlCommand deletePayrollRecordCmd = new MySqlCommand(deletePayrollRecordQry, connection.conn);
                    deletePayrollRecordCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(dataGridViewPayroll.Rows[rowIndex].Cells["id"].Value.ToString()));
                    deletePayrollRecordCmd.Parameters.AddWithValue("@date", Class.Utilities.encryption(dataGridViewPayroll.Rows[rowIndex].Cells["date"].Value.ToString()));
                    connection.conn.Open();
                    deletePayrollRecordCmd.ExecuteNonQuery();

                    connection.conn.Close();

                    refreshGridView();
                }
                else
                {
                    MessageBox.Show("You can't delete a completed transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBoxRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string str = textBox.Text;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(str, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (str.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string str = textBox.Text;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(str, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (str.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != string.Empty)
            {
                foreach (DataGridViewRow row in dataGridViewPayroll.Rows)
                {
                    if (row.Cells["name"].Value.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                        row.Visible = false;
                }
            }
            else
            {
                refreshGridView();
            }
        }

        private void textBoxRate_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if(textBox.Text != "")
            {
                textBox.Text = (double.Parse(textBox.Text)).ToString("0.00");

                calculateGrossPay();                
            }
        }
    }
}
