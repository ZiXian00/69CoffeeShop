using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Members
{
    public partial class editMember : Form
    {
        public editMember()
        {
            InitializeComponent();
        }

        public string memID, memberName, contactNo, dob, email, point;

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToLower(e.KeyChar);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == ((char)39)))
            {
                e.Handled = true;
            }
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtCustName.Text == "" || txtContact.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please make sure all details is filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regex.Match(txtContact.Text, "^(01)[0-46-9]*[0-9]{7,8}$").Success == false)
            {
                MessageBox.Show("Please enter a valid contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (Regex.Match(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success == false)
            {
                if (MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtEmail.Clear();
                }
            }
            else
            {

                string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                string sql = "UPDATE member SET memberName = @memberName, contactNo = @contactNo, dateOfBirth= @dateOfBirth, email = @email WHERE memberID = @memberID";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@memberID", Class.Utilities.encryption(lblMemID.Text));
                cmd.Parameters.AddWithValue("@memberName", Class.Utilities.encryption(txtCustName.Text));
                cmd.Parameters.AddWithValue("@ContactNo", Class.Utilities.encryption(txtContact.Text));
                cmd.Parameters.AddWithValue("@dateOfBirth", Class.Utilities.encryption(dtpDOB.Text));
                cmd.Parameters.AddWithValue("@email", Class.Utilities.encryption(txtEmail.Text));
                try
                {
                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("Update Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();


                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Member not update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();

            }
        }

        

        public void UpdateMember()
        {

            lblMemID.Text = memID;
            txtCustName.Text = memberName;
            txtContact.Text = contactNo;
            dtpDOB.Text = dob;
            txtEmail.Text = email;
            lblPoint.Text = point;
        }


    }
}
