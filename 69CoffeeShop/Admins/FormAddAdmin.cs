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
    public partial class FormAddAdmin : Form
    {
        Class.Connection connection = new Class.Connection();
        ErrorProvider error = new ErrorProvider();
        FormOverallAdmin previous;

        public FormAddAdmin()
        {
            InitializeComponent();
            this.AcceptButton = iconButtonCheck;
        }

        public FormAddAdmin(FormOverallAdmin previous)
        {
            InitializeComponent();
            this.AcceptButton = iconButtonCheck;
            this.previous = previous;
        }

        private Boolean validation()
        {
            Boolean validate = true;

            if (textBoxPassword.Text == "")
            {
                error.SetError(textBoxPassword, "Please enter your password");
               
                validate = false;
            }

            if(textBoxConfirm.Text == "")
            {
                error.SetError(textBoxConfirm, "Please enter your password");

                validate = false;
            }

            if (dropdownFQ.SelectedIndex < 0) 
            {
                error.SetError(dropdownFQ, "Please select your security question");

                validate = false;
            }

            if (dropdownSQ.SelectedIndex < 0)
            {
                error.SetError(dropdownSQ, "Please select your security question");
                validate = false;
            }

            if(textBoxFirstAns.Text == "")
            {
                error.SetError(textBoxFirstAns, "Please enter your security answer");

                validate = false;
            }

            if (textBoxSecAns.Text == "")
            {
                error.SetError(textBoxSecAns, "Please enter your security answer");

                validate = false;
            }

            return validate;
        }

        private void iconButtonConfirm_Click(object sender, EventArgs e)
        {
            error.Clear();
           
            if(validation() == true)
            {
                if (textBoxPassword.Text != textBoxConfirm.Text)
                {
                    error.SetError(textBoxPassword, "Password doesn't match");
                    error.SetError(textBoxConfirm, "Password doesn't match");
                }
                else
                {
                    string newAdminQry = "insert into admin values (@id, @secQues1, @secQues2, @secAns1, @secAns2, @password)";
                    MySqlCommand newAdminCmd = new MySqlCommand(newAdminQry, connection.conn);
                    connection.conn.Open();

                    newAdminCmd.Parameters.AddWithValue("@id", textBoxID.Text);
                    newAdminCmd.Parameters.AddWithValue("@secQues1", Class.Utilities.encryption(dropdownFQ.SelectedItem.ToString()));
                    newAdminCmd.Parameters.AddWithValue("@secQues2", Class.Utilities.encryption(dropdownSQ.SelectedItem.ToString()));
                    newAdminCmd.Parameters.AddWithValue("@secAns1", Class.Utilities.encryption(textBoxFirstAns.Text));
                    newAdminCmd.Parameters.AddWithValue("@secAns2", Class.Utilities.encryption(textBoxSecAns.Text));
                    newAdminCmd.Parameters.AddWithValue("@password", Class.Utilities.encryption(textBoxConfirm.Text));

                    newAdminCmd.ExecuteNonQuery();

                    connection.conn.Close();

                    previous.refreshGridView();

                    MessageBox.Show(textBoxName.Text + " (" + textBoxID.Text + ") has been added as new admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Class.Utilities.resetControlWithoutDropdown(this);
                }
            }   
        }

        private Boolean checkAdmin()
        {
            string checkAdminQry = "select * from admin where employeeID = @id";
            MySqlCommand checkAdminCmd = new MySqlCommand(checkAdminQry, connection.conn);
            checkAdminCmd.Parameters.AddWithValue("@id",textBoxID.Text);
            connection.conn.Open();
            MySqlDataReader checkAdminRdr = checkAdminCmd.ExecuteReader();

            if (checkAdminRdr.Read())
            {
                MessageBox.Show("Duplicate record !" + Environment.NewLine + "User has already added as admin before !", "Duplicate record", MessageBoxButtons.OK, MessageBoxIcon.Error);

                connection.conn.Close();
                return false;
            }
            else
            {
                connection.conn.Close();
                return true;
            }
        }

        private void iconButtonCheck_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text == "")
            {
                MessageBox.Show("Please enter employee ID to continue.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(checkAdmin() == true)
                {
                    string searchEmployeeQry = "select * from employees where employeeID = @id";
                    MySqlCommand searchEmployeeCmd = new MySqlCommand(searchEmployeeQry, connection.conn);
                    searchEmployeeCmd.Parameters.AddWithValue("@id", textBoxID.Text);
                    connection.conn.Open();
                    MySqlDataReader searchEmployeeRdr = searchEmployeeCmd.ExecuteReader();

                    if (searchEmployeeRdr.Read())
                    {
                        textBoxName.Text = Class.Utilities.decryption(searchEmployeeRdr["employeeName"].ToString());
                        textBoxPosition.Text = Class.Utilities.decryption(searchEmployeeRdr["position"].ToString());
                        textBoxStatus.Text = Class.Utilities.decryption(searchEmployeeRdr["employmentStatus"].ToString());

                        if (textBoxPosition.Text.ToUpper() != "MANAGER")
                        {
                            MessageBox.Show("ONLY MANAGEMENT LEVEL are allowed to add as admin. ", "Job Position not match !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            labelPw.Visible = false;
                            labelConfirm.Visible = false;
                            textBoxPassword.Visible = false;
                            textBoxConfirm.Visible = false;
                            groupBoxSQ.Visible = false;
                            iconButtonConfirm.Visible = false;
                            iconButtonCancel.Visible = false;
                        }
                        else
                        {
                            labelPw.Visible = true;
                            labelConfirm.Visible = true;
                            textBoxPassword.Visible = true;
                            textBoxConfirm.Visible = true;
                            groupBoxSQ.Visible = true;
                            iconButtonConfirm.Visible = true;
                            iconButtonCancel.Visible = true;

                            this.AcceptButton = iconButtonConfirm;
                            this.CancelButton = iconButtonCancel;
                        }
                    }
                    else
                    {
                        error.SetError(textBoxID, "No employee record found with entered ID");
                        textBoxID.Select();
                        labelPw.Visible = false;
                        labelConfirm.Visible = false;
                        textBoxPassword.Visible = false;
                        textBoxConfirm.Visible = false;
                        groupBoxSQ.Visible = false;
                        iconButtonConfirm.Visible = false;
                        iconButtonCancel.Visible = false;
                    }

                    searchEmployeeRdr.Close();
                    connection.conn.Close();
                }
            }
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dropdownFQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropdownSQ.Items.Clear();
            dropdownSQ.Items.AddRange(new string[] { "What is your favorite color?", "What is your father's name?", "What is your first dream car?", "What is your first pet's name?", "What is your dream when you were 16?" });
            dropdownSQ.Items.RemoveAt(dropdownFQ.SelectedIndex);
        }

        private void FormAddAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
