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
        Class.Connection connection = new Class.Connection();
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void lblFrgtPw_Click(object sender, EventArgs e)
        {
            Form forgotPass = new Admins.FormFrgtPw();
            this.Hide();
            forgotPass.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            string admLoginQry = "select * from admin where employeeID = @empID";
            MySqlCommand admLoginCmd = new MySqlCommand(admLoginQry, connection.conn);
            admLoginCmd.Parameters.AddWithValue("empID", textBoxID.Text.ToString());
            connection.conn.Open();
            MySqlDataReader admLoginRdr = admLoginCmd.ExecuteReader();

            if (admLoginRdr.Read()) {
                string admPass = admLoginRdr.GetString(5);

                if (admPass.Equals(textBoxPassword.Text.ToString())) {
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

            admLoginRdr.Close();
            connection.conn.Close();
        }
    }
}
