using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _69CoffeeShop.Forms;
using MySql.Data.MySqlClient;

namespace _69CoffeeShop.Admins
{
    public partial class FormAdminChangePassword : Form
    {
        Class.Connection connection = new Class.Connection();
        private FormAdmin formAdmin;

        public FormAdminChangePassword()
        {
            InitializeComponent();
        }

        public FormAdminChangePassword(FormAdmin formAdmin)
        {
            InitializeComponent();
            this.formAdmin = formAdmin;
        }

        private Boolean validation()
        {
            Boolean validate = true;
            ErrorProvider error = new ErrorProvider();

            if(textBoxOldPw.Text == "")
            {
                error.SetError(textBoxOldPw, "Please enter your old password");
                textBoxOldPw.Select();
                validate = false;
            }

            if(textBoxNewPw.Text == "")
            {
                error.SetError(textBoxNewPw, "Please enter your old password");
                textBoxNewPw.Select();
                validate = false;
            }

            if (textBoxConfirm.Text == "")
            {
                error.SetError(textBoxConfirm, "Please confirm your new password");
                textBoxConfirm.Select();
                validate = false;
            }

            if (textBoxNewPw.Text != textBoxConfirm.Text)
            {
                error.SetError(textBoxConfirm, "Password doesn't match");
                error.SetError(textBoxNewPw, "Password doesn't match");
                validate = false;
            }

            string oldPassword = "";

            string getAdmPassQry = "select password from admin where employeeID = @id";
            MySqlCommand getAdmPassCmd = new MySqlCommand(getAdmPassQry, connection.conn);
            getAdmPassCmd.Parameters.AddWithValue("@id", Class.Admin.adminID);
            connection.conn.Open();
            MySqlDataReader getAdmPassRdr = getAdmPassCmd.ExecuteReader();

            if (getAdmPassRdr.Read())
            {
                oldPassword = Class.Utilities.decryption(getAdmPassRdr.GetString(0));
            }

            getAdmPassRdr.Close();
            connection.conn.Close();

            if(textBoxOldPw.Text != oldPassword)
            {
                error.SetError(textBoxOldPw, "Old Password doesn't match");
                validate = false;
            }

            return validate;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if(validation() == true)
            {
                string admChangePwQry = "update admin set password = @pass where employeeID = @id";
                MySqlCommand admChangePwCmd = new MySqlCommand(admChangePwQry, connection.conn);
                connection.conn.Open();

                admChangePwCmd.Parameters.AddWithValue("@pass", Class.Utilities.encryption(textBoxConfirm.Text));
                admChangePwCmd.Parameters.AddWithValue("@id", Class.Admin.adminID);

                admChangePwCmd.ExecuteNonQuery();

                connection.conn.Close();

                DialogResult rs = MessageBox.Show("Password updated. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(rs == DialogResult.OK)
                {
                    formAdmin.Close();
                    this.Close();
                }
            }
        }
    }
}
