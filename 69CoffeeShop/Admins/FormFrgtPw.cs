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

namespace _69CoffeeShop.Admins
{
    public partial class FormFrgtPw : Form
    {
        Class.Connection connection = new Class.Connection();
        string secQues1;
        string secQues2;
        string secAns1;
        string secAns2;

        public FormFrgtPw()
        {
            InitializeComponent();
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text == "")
            {
                ErrorProvider error = new ErrorProvider();

                error.SetError(textBoxID, "Please enter your ID");
            }
            else
            {
                string adminForgotPwQry = "select * from admin where employeeID = @id";
                MySqlCommand adminForgotPwCmd = new MySqlCommand(adminForgotPwQry, connection.conn);
                connection.conn.Open();
                adminForgotPwCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(textBoxID.Text));
                MySqlDataReader adminForgotPwRdr = adminForgotPwCmd.ExecuteReader();

                if (adminForgotPwRdr.Read())
                {
                    secQues1 = Class.Utilities.decryption(adminForgotPwRdr.GetString(1));
                    secQues2 = Class.Utilities.decryption(adminForgotPwRdr.GetString(2));
                    secAns1 = Class.Utilities.decryption(adminForgotPwRdr.GetString(3));
                    secAns2 = Class.Utilities.decryption(adminForgotPwRdr.GetString(4));

                    groupBoxSQ.Visible = true;
                    this.AcceptButton = buttonNext;
                    textBoxID.Enabled = false;
                    buttonProceed.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No admin record found with entered ID.", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                adminForgotPwRdr.Close();
                connection.conn.Close();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (dropdownFQ.SelectedIndex < 0 && dropdownSQ.SelectedIndex < 0 && textBoxFirstAns.Text == "" && textBoxSecAns.Text == "") 
            {
                MessageBox.Show("Please enter all required input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (secQues1 == dropdownFQ.SelectedItem.ToString() && secAns1 == textBoxFirstAns.Text && secQues2 == dropdownSQ.SelectedItem.ToString() && secAns2 == textBoxSecAns.Text)
                {
                    groupBoxPassword.Visible = true;
                    groupBoxSQ.Enabled = false;
                    this.AcceptButton = buttonReset;
                }
                else
                {
                    MessageBox.Show("Incorrect question(s) or answer(s)." + Environment.NewLine + Environment.NewLine + "Please try again", "Failed Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if(textBoxNewPass.Text == textBoxConfirm.Text)
            {
                string adminUpdatePwQry = "update admin set password = @password where employeeID = @id";
                MySqlCommand adminUpdatePwCmd = new MySqlCommand(adminUpdatePwQry, connection.conn);
                adminUpdatePwCmd.Parameters.AddWithValue("@password", Class.Utilities.encryption(textBoxConfirm.Text));
                adminUpdatePwCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(textBoxID.Text));
                connection.conn.Open();
                adminUpdatePwCmd.ExecuteNonQuery();
                connection.conn.Close();

                MessageBox.Show("New password updated." + Environment.NewLine + "Please login again.");

                this.Close();
            }
            else
            {
                ErrorProvider error = new ErrorProvider();

                error.SetError(textBoxConfirm, "This field must be same with new password");
            }
        }

        private void FormFrgtPw_Load(object sender, EventArgs e)
        {
            this.AcceptButton = buttonProceed;
        }

        private void dropdownFQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropdownSQ.Items.Clear();
            dropdownSQ.Items.AddRange(new string[] { "What is your favorite color?", "What is your father's name?", "What is your first dream car?", "What is your first pet's name?", "What is your dream when you were 16?" });
            dropdownSQ.Items.RemoveAt(dropdownFQ.SelectedIndex);
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
