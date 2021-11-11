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
using System.Configuration;
using System.Text.RegularExpressions;

namespace _69CoffeeShop.Suppliers
{
    public partial class newSupplier : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public newSupplier()
        {
            InitializeComponent();
        }

        private void newSupplier_Load(object sender, EventArgs e)
        {
            LoadID();
        }

    

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtContactName.Text == "" || txtContactNo.Text == "" || txtCompanyName.Text == "" || txtAddress.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please make sure all details is filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regex.Match(txtContactNo.Text, "^(01)[0-46-9]*[0-9]{7,8}$").Success == false)
            {
                MessageBox.Show("Please enter a valid contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Regex.Match(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success == false)
            {
                if (MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtEmail.Clear();
                }

            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string query = "Insert into supplier (supplierID, companyName, contactNo, address, contactName, email, supCount) values (@supplierID, @companyName, @contactNo, @address, @contactName, @email, @supCount)";
                MySqlCommand insertCmd = new MySqlCommand(query, conn);
                insertCmd.Parameters.AddWithValue("@supplierId", Class.Utilities.encryption(lblSupplierID.Text));
                insertCmd.Parameters.AddWithValue("@companyName", Class.Utilities.encryption(txtCompanyName.Text));
                insertCmd.Parameters.AddWithValue("@contactNo", Class.Utilities.encryption(txtContactNo.Text));
                insertCmd.Parameters.AddWithValue("@address", Class.Utilities.encryption(txtAddress.Text));
                insertCmd.Parameters.AddWithValue("@contactName", Class.Utilities.encryption(txtContactName.Text));
                insertCmd.Parameters.AddWithValue("@email", Class.Utilities.encryption(txtEmail.Text));
                insertCmd.Parameters.AddWithValue("@supCount", lblCount.Text.Trim());
                try
                {
                     insertCmd.ExecuteNonQuery();
                    if(MessageBox.Show("Supplier saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)== DialogResult.OK)
                    {
                        txtContactName.Text = "";
                        txtContactNo.Text = "";
                        txtCompanyName.Text = "";
                        txtAddress.Text = "";
                        txtEmail.Text = "";
                        LoadID();
                    }
                    

                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Supplier not save. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            
            
            
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        public void LoadID()
        {
            
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();
            //string query = "SELECT MAX(supCount) FROM supplier";
            string query = "select supCount from supplier ORDER BY supCount DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int currentCount = Convert.ToInt32(dr.GetValue(0));
                currentCount++;
                string supID = "SP" + String.Format("{0:000}", currentCount);
                lblSupplierID.Text = supID;
                lblCount.Text = currentCount.ToString();


            }
            else
            {
                
                lblSupplierID.Text = "SP001";
                lblCount.Text = "1";
            }
            conn.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContactName.Text = "";
            txtContactNo.Text = "";
            txtCompanyName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
        }

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
    }
}
