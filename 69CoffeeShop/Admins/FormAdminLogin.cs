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

namespace _69CoffeeShop.Forms
{
    public partial class FormAdminLogin : Form
    {
        ErrorProvider error = new ErrorProvider();
        Class.Connection connection = new Class.Connection();
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void lblFrgtPw_Click(object sender, EventArgs e)
        {
            Form forgotPass = new Admins.FormFrgtPw();
            this.Close();
            forgotPass.ShowDialog(this);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(validation() == true)
            {
                error.Clear();
                string admLoginQry = "select * from admin where employeeID = @empID";
                MySqlCommand admLoginCmd = new MySqlCommand(admLoginQry, connection.conn);
                admLoginCmd.Parameters.AddWithValue("@empID", Class.Utilities.encryption(textBoxID.Text));
                connection.conn.Open();
                MySqlDataReader admLoginRdr = admLoginCmd.ExecuteReader();

                try
                {
                    if (admLoginRdr.Read())
                    {
                        string admPass = Class.Utilities.decryption(admLoginRdr.GetString(5));

                        if (admPass.Equals(textBoxPassword.Text.ToString()))
                        {
                            Class.Admin.adminID = textBoxID.Text;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            this.DialogResult = DialogResult.None;
                            textBoxPassword.Focus();
                            error.SetError(textBoxPassword, "Invalid Password");
                            connection.conn.Close();
                        }
                    }
                    else
                    {
                        textBoxID.Focus();
                        this.DialogResult = DialogResult.None;
                        error.SetError(textBoxID, "Invalid ID");
                        connection.conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    admLoginRdr.Close();
                    connection.conn.Close();
                }
               
            }
        }

        private Boolean validation()
        {
            StringBuilder error = new StringBuilder();
            Control ctrl = null;

            if(textBoxID.Text == "")
            {
                error.AppendLine("- Please enter ID to login");
                if (ctrl == null) ctrl = textBoxID;
            }

            if(textBoxPassword.Text == "")
            {
                error.AppendLine("- Please enter password to login");
                if (ctrl == null) ctrl = textBoxPassword;
            }

            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrl.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newEmpQry = "insert into employee_duty_record (month, year, employeeID, workingHours) values (@month, @year, @id, @hours)";
            MySqlCommand newEmpCmd = new MySqlCommand(newEmpQry, connection.conn);
            connection.conn.Open();

            //try
            //{
                newEmpCmd.Parameters.AddWithValue("@month", Class.Utilities.encryption("Oct"));
                newEmpCmd.Parameters.AddWithValue("@year", Class.Utilities.encryption("2021"));
                newEmpCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption("1002"));
                newEmpCmd.Parameters.AddWithValue("@hours", Class.Utilities.encryption("260"));
               
                newEmpCmd.ExecuteNonQuery();

                connection.conn.Close();
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Unexpected error occured." + Environment.NewLine + "Please try again.", "Error Handling", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    connection.conn.Close();
            //}

            // MessageBox.Show(Class.Utilities.encryption(textBoxID.Text));
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
    
}
