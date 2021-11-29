using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _69CoffeeShop.Employees
{
    public partial class FormEmployeeProfile : Form
    {
        Class.Connection connection = new Class.Connection();
        string position;
        ErrorProvider err = new ErrorProvider();
        FormOverallEmployee previous;

        public FormEmployeeProfile()
        {
            InitializeComponent();
        }

        private void updateEmpID()
        {
            iconButtonDelete.Visible = false;
            iconButtonEdit.Visible = false;
            iconButtonAdd.Visible = true;

            int age = DateTime.Now.Year - dateTimePickerDateOfBirth.Value.Year;
            labelAge.Text = age.ToString();

            string nextEmpIDQry = "select employeeID from employees ORDER BY employeeCount DESC LIMIT 1";
            MySqlCommand nextEmpIDCmd = new MySqlCommand(nextEmpIDQry, connection.conn);
            connection.conn.Open();
            MySqlDataReader nextEmpIDRdr = nextEmpIDCmd.ExecuteReader();

            if (nextEmpIDRdr.Read())
            {
                string previousID = Class.Utilities.decryption(nextEmpIDRdr.GetString(0));

                int _previousID = int.Parse(previousID);

                _previousID++;

                txtEmployeeID.Text = _previousID.ToString();

                txtName.Select();
            }

            nextEmpIDRdr.Close();
            connection.conn.Close();
        }

        public FormEmployeeProfile(string operation, string id, FormOverallEmployee previous)
        {
            InitializeComponent();
            this.previous = previous;

            if (operation == "add")
            {
                updateEmpID();
            }
            else if (operation == "view")
            {
                iconButtonDelete.Visible = true;
                iconButtonEdit.Visible = true;
                iconButtonAdd.Visible = false;

                string loadEmpProfileQry = "select * from employees where employeeID = @id";
                MySqlCommand loadEmpProfileCmd = new MySqlCommand(loadEmpProfileQry, connection.conn);
                loadEmpProfileCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(id));
                connection.conn.Open();
                MySqlDataReader loadEmpProfileRdr = loadEmpProfileCmd.ExecuteReader();

                try
                {
                    if (loadEmpProfileRdr.Read())
                    {
                        txtAddress.Text = Class.Utilities.decryption(loadEmpProfileRdr.GetString(9));
                        txtEmail.Text = Class.Utilities.decryption(loadEmpProfileRdr.GetString(5));
                        txtEmployeeID.Text = Class.Utilities.decryption(loadEmpProfileRdr.GetString(0));
                        txtName.Text = Class.Utilities.decryption(loadEmpProfileRdr.GetString(1));
                        textBoxBankAcc.Text = Class.Utilities.decryption(loadEmpProfileRdr.GetString(8));
                        textBoxContact.Text = Class.Utilities.decryption(loadEmpProfileRdr.GetString(4));
                        textBoxEContact.Text = Class.Utilities.decryption(loadEmpProfileRdr.GetString(11));
                        maskedTextBoxIC.Text = Class.Utilities.decryption(loadEmpProfileRdr.GetString(12));
                        labelAge.Text = Class.Utilities.decryption(loadEmpProfileRdr.GetString(10));
                        textBoxSalary.Text = Class.Utilities.decryption(loadEmpProfileRdr["salary_rate"].ToString());

                        DateTime dob = DateTime.ParseExact(Class.Utilities.decryption(loadEmpProfileRdr.GetString(2)), "yyyy-MM-dd", CultureInfo.InvariantCulture);

                        dateTimePickerDateOfBirth.Value = dob;

                        DateTime dateHired = DateTime.ParseExact(Class.Utilities.decryption(loadEmpProfileRdr.GetString(14)), "yyyy-MM-dd", CultureInfo.InvariantCulture);


                        dateTimePickerDateHired.Value = dateHired;

                        for (int i = 0; i < dropDownMarriage.Items.Count; i++)
                        {
                            if (Class.Utilities.decryption(loadEmpProfileRdr.GetString(15)).ToUpper() == dropDownMarriage.Items[i].ToString().ToUpper())
                            {
                                dropDownMarriage.SelectedIndex = i;
                            }
                        }

                        for (int i = 0; i < dropdownBank.Items.Count; i++)
                        {
                            if (Class.Utilities.decryption(loadEmpProfileRdr.GetString(7)).ToUpper() == dropdownBank.Items[i].ToString().ToUpper())
                            {
                                dropdownBank.SelectedIndex = i;
                            }
                        }

                        for (int i = 0; i < dropdownPosition.Items.Count; i++)
                        {
                            if (Class.Utilities.decryption(loadEmpProfileRdr.GetString(3)).ToUpper() == dropdownPosition.Items[i].ToString().ToUpper())
                            {
                                dropdownPosition.SelectedIndex = i;
                                position = loadEmpProfileRdr.GetString(3);
                            }
                        }

                        if (Class.Utilities.decryption(loadEmpProfileRdr.GetString(6)).ToUpper() == "FULL TIME")
                        {
                            radFullTime.Checked = true;
                        }
                        else if (Class.Utilities.decryption(loadEmpProfileRdr.GetString(6)).ToUpper() == "PART TIME")
                        {
                            radioPartTime.Checked = true;
                        }

                        if (Class.Utilities.decryption(loadEmpProfileRdr.GetString(13)).ToUpper() == "MALE")
                        {
                            radMale.Checked = true;
                        }
                        else if (Class.Utilities.decryption(loadEmpProfileRdr.GetString(13)).ToUpper() == "FEMALE")
                        {
                            radFemale.Checked = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected error occured." + Environment.NewLine + "Please try again.", "Error Handling", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    loadEmpProfileRdr.Close();
                    connection.conn.Close();
                }
            }
        }

        private void FormEmployeeProfile_Load(object sender, EventArgs e)
        {
            dateTimePickerDateOfBirth.MaxDate = DateTime.Now.AddYears(-16);
        }

        private Boolean checkEmployeeExist()
        {
            string checkEmpQry = "select * from employees where identityNo = @ic";
            MySqlCommand checkEmpCmd = new MySqlCommand(checkEmpQry, connection.conn);
            checkEmpCmd.Parameters.AddWithValue("@ic", Class.Utilities.encryption(maskedTextBoxIC.Text));
            connection.conn.Open();

            MySqlDataReader checkEmpRdr = checkEmpCmd.ExecuteReader();

            if (checkEmpRdr.Read())
            {
                MessageBox.Show("Duplicate record !" + Environment.NewLine + "User with same identity no. has been added before !", "Duplicate record", MessageBoxButtons.OK, MessageBoxIcon.Error);

                connection.conn.Close();
                return false;
            }
            else
            {
                connection.conn.Close();
                return true;
            }
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                if (checkEmployeeExist() == true)
                {
                    string newEmpQry = "insert into employees (employeeID, employeeName, dateOfBirth, position, contactNo, email, employmentStatus, bankName, bankAccountNo, " +
                   "address, age, emergencyContact, identityNo, gender, dateHired, maritalStatus, salary_rate) " +
                   "values (@id, @name, @dob, @position, @contact, @email, @status, @bankName, @bankAcc, @address, @age, @emergencyContact, @ic, @gender, @dateHired, @maritalStatus, @salary)";
                    MySqlCommand newEmpCmd = new MySqlCommand(newEmpQry, connection.conn);
                    connection.conn.Open();

                    try
                    {
                        newEmpCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(txtEmployeeID.Text));
                        newEmpCmd.Parameters.AddWithValue("@name", Class.Utilities.encryption(txtName.Text));
                        newEmpCmd.Parameters.AddWithValue("@dob", Class.Utilities.encryption(dateTimePickerDateOfBirth.Value.ToString("yyyy-MM-dd")));
                        newEmpCmd.Parameters.AddWithValue("@position", Class.Utilities.encryption(dropdownPosition.SelectedItem.ToString()));
                        newEmpCmd.Parameters.AddWithValue("@contact", Class.Utilities.encryption(textBoxContact.Text));
                        newEmpCmd.Parameters.AddWithValue("@email", Class.Utilities.encryption(txtEmail.Text));

                        if (radFullTime.Checked)
                        {
                            newEmpCmd.Parameters.AddWithValue("@status", Class.Utilities.encryption("Full time"));
                        }
                        else if (radioPartTime.Checked)
                        {
                            newEmpCmd.Parameters.AddWithValue("@status", Class.Utilities.encryption("Part time"));
                        }
                        newEmpCmd.Parameters.AddWithValue("@bankName", Class.Utilities.encryption(dropdownBank.SelectedItem.ToString()));
                        newEmpCmd.Parameters.AddWithValue("@bankAcc", Class.Utilities.encryption(textBoxBankAcc.Text));
                        newEmpCmd.Parameters.AddWithValue("@address", Class.Utilities.encryption(txtAddress.Text));
                        newEmpCmd.Parameters.AddWithValue("@age", Class.Utilities.encryption(labelAge.Text));
                        newEmpCmd.Parameters.AddWithValue("@emergencyContact", Class.Utilities.encryption(textBoxEContact.Text));
                        newEmpCmd.Parameters.AddWithValue("@ic", Class.Utilities.encryption(maskedTextBoxIC.Text));

                        if (radMale.Checked)
                        {
                            newEmpCmd.Parameters.AddWithValue("@gender", Class.Utilities.encryption("Male"));
                        }
                        else
                        {
                            newEmpCmd.Parameters.AddWithValue("@gender", Class.Utilities.encryption("Female"));
                        }
                        newEmpCmd.Parameters.AddWithValue("@dateHired", Class.Utilities.encryption(dateTimePickerDateHired.Value.ToString("yyyy-MM-dd")));
                        newEmpCmd.Parameters.AddWithValue("@maritalStatus", Class.Utilities.encryption(dropDownMarriage.SelectedItem.ToString()));

                        double salary_rate = double.Parse(textBoxSalary.Text);
                        string _salary_rate = salary_rate.ToString("0.00");

                        newEmpCmd.Parameters.AddWithValue("@salary", Class.Utilities.encryption(_salary_rate));
                        newEmpCmd.ExecuteNonQuery();

                        MessageBox.Show(txtName.Text + " has been added." + Environment.NewLine + "ID : " + txtEmployeeID.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Class.Utilities.resetControl(this);
                        previous.refreshGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error occured." + Environment.NewLine + "Please try again.", "Error Handling", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.conn.Close();
                        updateEmpID();
                    }
                }
            }
        }

        private Boolean validation()
        {
            StringBuilder error = new StringBuilder();
            Control ctrl = null;
            err.Clear();

            if (txtName.Text == "")
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = txtName;

                err.SetError(txtName, "Please enter employee's name");
            }
            if (textBoxContact.Text == "")
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = textBoxContact;

                err.SetError(textBoxContact, "Please enter employee's contact");
            }
            if (txtAddress.Text == "")
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = txtAddress;

                err.SetError(txtAddress, "Please enter employee's address");
            }

            if (textBoxSalary.Text == "")
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = txtAddress;

                err.SetError(txtAddress, "Please enter employee's salary");
            }

            if (txtEmail.Text == "")
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = txtEmail;

                err.SetError(txtEmail, "Please enter employee's email address");
            }
            else
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(txtEmail.Text);
                }
                catch
                {
                    error.Clear();
                    error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                    if (ctrl == null) ctrl = txtEmail;

                    err.SetError(txtEmail, "Invalid email format");
                }
            }
            if (textBoxEContact.Text == "")
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = textBoxEContact;

                err.SetError(textBoxEContact, "Please enter employee's emergency contact");
            }

            if (maskedTextBoxIC.Text == "")
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = maskedTextBoxIC;

                err.SetError(maskedTextBoxIC, "Please enter employee's identity card no.");
            }
            else
            {
                string dateOnIC = maskedTextBoxIC.Text.ToString();
                dateOnIC = dateOnIC.Substring(0, 6);

                string dateOnDTP = dateTimePickerDateOfBirth.Value.ToString("yyMMdd");

                if (dateOnIC != dateOnDTP)
                {
                    error.Clear();
                    error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                    if (ctrl == null) ctrl = dateTimePickerDateOfBirth;

                    err.SetError(dateTimePickerDateOfBirth, "Different date input on identity card no. and date of birth. Please validate correct input");
                }
            }

            if (radFemale.Checked == false && radMale.Checked == false)
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = radMale;

                err.SetError(radFemale, "Please enter employee's gender");
            }
            if (radFullTime.Checked == false && radioPartTime.Checked == false)
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = radFullTime;

                err.SetError(radFullTime, "Please select the employee's employement status");
            }
            if (dropdownBank.SelectedIndex < 0)
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = radFullTime;

                err.SetError(dropdownBank, "Please select the employee's merchant bank");
            }
            if (textBoxBankAcc.Text == "")
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = textBoxBankAcc;

                err.SetError(textBoxBankAcc, "Please enter employee's bank account no.");
            }
            if (dropdownPosition.SelectedIndex < 0)
            {
                error.Clear();
                error.AppendLine("Invalid input. Please make sure to fill up all the required field with correct format");
                if (ctrl == null) ctrl = dropdownPosition;

                err.SetError(dropdownPosition, "Please select the employee's designation");
            }

            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrl.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void textBoxBankAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtbDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dateTimePickerDateOfBirth.Value.Year;
            labelAge.Text = age.ToString();
        }

        private void maskedTextBoxIC_Leave(object sender, EventArgs e)
        {
            string dateOnIC = maskedTextBoxIC.Text.ToString();
            dateOnIC = dateOnIC.Substring(0, 6);

            try
            {
                dateTimePickerDateOfBirth.Value = DateTime.ParseExact(dateOnIC, "yyMMdd", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Applicant's age does not reach 16 years old or above !", "Under Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButtonEdit_Click(object sender, EventArgs e)
        {
            Boolean isAdmin = false;

            string checkIfAdmQry = "select * from admin where employeeID = @id";
            MySqlCommand checkIfAdmCmd = new MySqlCommand(checkIfAdmQry, connection.conn);
            checkIfAdmCmd.Parameters.AddWithValue("id", Class.Utilities.encryption(txtEmployeeID.Text));
            connection.conn.Open();
            MySqlDataReader checkIfAdmRdr = checkIfAdmCmd.ExecuteReader();

            if (checkIfAdmRdr.Read() && dropdownPosition.SelectedItem.ToString() != "Manager")
            {
                isAdmin = true;
            }

            checkIfAdmRdr.Close();
            if(isAdmin == true)
            {
                DialogResult ds = MessageBox.Show("This employee has added as admin." + Environment.NewLine + "Admin record will together be deleted if proceed", "Admin record found", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (ds == DialogResult.OK)
                {
                    string deleteAdmQry = "delete from admin where employeeID = @id";
                    MySqlCommand deleteAdmCmd = new MySqlCommand(deleteAdmQry, connection.conn);
                    deleteAdmCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(txtEmployeeID.Text));
                    deleteAdmCmd.ExecuteNonQuery();
                }
            }

            connection.conn.Close();
            if (validation() == true)
            {
                string updateEmpProfilQry = "update employees set employeeName = @name, " +
                    "dateOfBirth = @dob, " +
                    "position = @position, " +
                    "contactNo = @contact, " +
                    "email = @email, " +
                    "employmentStatus = @status, " +
                    "bankName = @bankName, " +
                    "bankAccountNo = @bankAcc, " +
                    "address = @address, " +
                    "age = @age, " +
                    "emergencyContact = @emergencyContact, " +
                    "identityNo = @ic, " +
                    "gender = @gender, " +
                    "dateHired = @dateHired, " +
                    "maritalStatus = @maritalStatus, " +
                    "salary_rate = @salary " +
                    "where employeeID = @id";

                MySqlCommand updateEmpProfileCmd = new MySqlCommand(updateEmpProfilQry, connection.conn);
                connection.conn.Open();

                try
                {
                    updateEmpProfileCmd.Parameters.AddWithValue("@name", Class.Utilities.encryption(txtName.Text));
                    updateEmpProfileCmd.Parameters.AddWithValue("@dob", Class.Utilities.encryption(dateTimePickerDateOfBirth.Value.ToString("yyyy-MM-dd")));
                    updateEmpProfileCmd.Parameters.AddWithValue("@position", Class.Utilities.encryption(dropdownPosition.SelectedItem.ToString()));
                    updateEmpProfileCmd.Parameters.AddWithValue("@contact", Class.Utilities.encryption(textBoxContact.Text));
                    updateEmpProfileCmd.Parameters.AddWithValue("@email", Class.Utilities.encryption(txtEmail.Text));

                    if (radFullTime.Checked)
                    {
                        updateEmpProfileCmd.Parameters.AddWithValue("@status", Class.Utilities.encryption("Full time"));
                    }
                    else if (radioPartTime.Checked)
                    {
                        updateEmpProfileCmd.Parameters.AddWithValue("@status", Class.Utilities.encryption("Part time"));
                    }
                    updateEmpProfileCmd.Parameters.AddWithValue("@bankName", Class.Utilities.encryption(dropdownBank.SelectedItem.ToString()));
                    updateEmpProfileCmd.Parameters.AddWithValue("@bankAcc", Class.Utilities.encryption(textBoxBankAcc.Text));
                    updateEmpProfileCmd.Parameters.AddWithValue("@address", Class.Utilities.encryption(txtAddress.Text));
                    updateEmpProfileCmd.Parameters.AddWithValue("@age", Class.Utilities.encryption(labelAge.Text));
                    updateEmpProfileCmd.Parameters.AddWithValue("@emergencyContact", Class.Utilities.encryption(textBoxEContact.Text));
                    updateEmpProfileCmd.Parameters.AddWithValue("@ic", Class.Utilities.encryption(maskedTextBoxIC.Text));

                    if (radMale.Checked)
                    {
                        updateEmpProfileCmd.Parameters.AddWithValue("@gender", Class.Utilities.encryption("Male"));
                    }
                    else
                    {
                        updateEmpProfileCmd.Parameters.AddWithValue("@gender", Class.Utilities.encryption("Female"));
                    }
                    updateEmpProfileCmd.Parameters.AddWithValue("@dateHired", Class.Utilities.encryption(dateTimePickerDateHired.Value.ToString("yyyy-MM-dd")));
                    updateEmpProfileCmd.Parameters.AddWithValue("@maritalStatus", Class.Utilities.encryption(dropDownMarriage.SelectedItem.ToString()));

                    double salary_rate = double.Parse(textBoxSalary.Text);
                    string _salary_rate = salary_rate.ToString("0.00");

                    updateEmpProfileCmd.Parameters.AddWithValue("@salary", Class.Utilities.encryption(_salary_rate));
                    updateEmpProfileCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(txtEmployeeID.Text));

                    updateEmpProfileCmd.ExecuteNonQuery();

                    MessageBox.Show("Profile updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error occured." + Environment.NewLine + "Please try again.", "Error Handling", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.conn.Close();
                    previous.refreshGridView();
                }
            }
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            Boolean isAdmin;

            DialogResult ds = MessageBox.Show("Confirm delete " + txtName.Text + "'s profile?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ds == DialogResult.Yes)
            {
                string deleteEmpQry = "delete from employees where employeeID = @id";
                MySqlCommand deleteEmpCmd = new MySqlCommand(deleteEmpQry, connection.conn);
                deleteEmpCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(txtEmployeeID.Text));
                connection.conn.Open();
                try
                {
                    deleteEmpCmd.ExecuteNonQuery();

                    MessageBox.Show(txtName.Text + "'s profile has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dropdownPosition.SelectedItem.ToString().ToUpper() == "Manager")
                    {
                        string checkIfAdmQry = "select * from admin where employeeID = @id";
                        MySqlCommand checkIfAdmCmd = new MySqlCommand(checkIfAdmQry, connection.conn);
                        checkIfAdmCmd.Parameters.AddWithValue("id", Class.Utilities.encryption(txtEmployeeID.Text));
                        MySqlDataReader checkIfAdmRdr = checkIfAdmCmd.ExecuteReader();

                        if (checkIfAdmRdr.Read())
                        {
                            isAdmin = true;
                        }
                        else isAdmin = false;

                        checkIfAdmRdr.Close();

                        if (isAdmin == true)
                        {
                            string deleteAdmQry = "delete from admin where employeeID = @id";
                            MySqlCommand deleteAdmCmd = new MySqlCommand(deleteAdmQry, connection.conn);
                            deleteAdmCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(txtEmployeeID.Text));
                            deleteAdmCmd.ExecuteNonQuery();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected error occured." + Environment.NewLine + "Please try again.", "Error Handling", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.conn.Close();
                    previous.refreshGridView();
                    this.Close();
                }
            }
        }

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = textBoxSalary.Text;
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

        private void textBoxContact_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            err.Clear();

            if (txtEmail.Text != "")
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(txtEmail.Text);
                }
                catch
                {
                    err.SetError(txtEmail, "Invalid email format");
                }
            }
        }
    }
}
