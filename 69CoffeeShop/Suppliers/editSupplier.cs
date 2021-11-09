using Devart.Data.MySql;
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

namespace _69CoffeeShop.Suppliers
{
    public partial class editSupplier : Form
    {
        public string supID, companyName, contactNo, address, contactName, email;

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToLower(e.KeyChar);
        }

        private void txtContactName_KeyPress(object sender, KeyPressEventArgs e)
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

            if (txtAddress.Text == "" || txtCompanyName.Text == "" || txtContactName.Text == "" || txtContactNo.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please make sure all details is filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regex.Match(txtContactNo.Text, "^(01)[0-46-9]*[0-9]{7,8}$").Success == false)
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
                string sql = "UPDATE supplier SET companyName = @CompanyName, contactNo = @ContactNumber, address = @Address, contactName = @ContactName, email = @email WHERE supplierID = @SupplierID";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SupplierID", lblSupplierID.Text.Trim());
                cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactName", txtContactName.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", txtContactNo.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
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
                    MessageBox.Show("Supplier not update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();

            }
        }

        public editSupplier()
        {
            InitializeComponent();

        }

        public void UpdateSupplier()
        {
            lblSupplierID.Text = supID;
            txtCompanyName.Text = companyName;
            txtContactNo.Text = contactNo;
            txtContactName.Text = contactName;
            txtAddress.Text = address;
            txtEmail.Text = email;
        }
    }
}

