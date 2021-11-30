using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _69CoffeeShop.Employees
{
    public partial class FormEmployeeLogin : Form
    {
        Class.Connection connection = new Class.Connection();

        public FormEmployeeLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Boolean checkin = false;
            string emp_position = "";

            string empLoginQry = "select * from employees where employeeID = @id";
            MySqlCommand empLoginCmd = new MySqlCommand(empLoginQry, connection.conn);
            empLoginCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(textBoxID.Text));
            connection.conn.Open();
            MySqlDataReader empLoginReader = empLoginCmd.ExecuteReader();

            try
            {
                if (empLoginReader.Read())
                {
                    Class.Cashier.cashierID = Class.Utilities.decryption(empLoginReader.GetString(0));
                    Class.Cashier.cashierName = Class.Utilities.decryption(empLoginReader.GetString(1));
                    Class.Cashier.cashierLogin = true;
                    checkin = true;
                    emp_position = Class.Utilities.decryption(empLoginReader.GetString(3));

                    labelName.Text = "Welcome, " + Class.Utilities.decryption(empLoginReader.GetString(1));
                    buttonLogin.Enabled = false;
                    textBoxID.Enabled = false;
                        
                    timer1.Interval = 2500;
                    timer1.Start();
                }
                else
                {
                    checkin = false;
                    MessageBox.Show("No employee record with entered ID. Please try again", "No record found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                empLoginReader.Close();
                connection.conn.Close();
                updateDutyRecord(checkin, emp_position);
            }
        }

        private void updateDutyRecord(Boolean checkin, string position)
        {
            if (checkin == true)
            {
                try
                {
                    string checkInQry = "update employees set lastCheckedIn = @checkIn where employeeID = @id";
                    MySqlCommand checkInCmd = new MySqlCommand(checkInQry, connection.conn);
                    checkInCmd.Parameters.AddWithValue("@checkIn", Class.Utilities.encryption(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                    checkInCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(Class.Cashier.cashierID));
                    connection.conn.Open();
                    checkInCmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.conn.Close();
                }                
            }
        }

        private void FormEmployeeLogin_Load(object sender, EventArgs e)
        {
            textBoxID.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ((MainPage)this.Owner).changeClockStatus();

            this.Close();
            timer1.Stop();
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
