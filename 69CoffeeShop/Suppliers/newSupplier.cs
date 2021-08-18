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

namespace _69CoffeeShop.Suppliers
{
    public partial class newSupplier : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;

        public newSupplier()
        {
            InitializeComponent();
        }

        private void newSupplier_Load(object sender, EventArgs e)
        {

        }

    

        private void btnSave_Click(object sender, EventArgs e)
        {
            //testing
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            conn.Open();
            string query = "Insert into suppliers (supplierID, companyName, contactName, contactNo, address) values (@supplierId,@comName, @contactName, @contact, @address)";
            MySqlCommand insertCmd = new MySqlCommand(query, conn);
            insertCmd.Parameters.AddWithValue("@supplierId", lblSupplierID.Text.Trim());
            insertCmd.Parameters.AddWithValue("@comName", txtCompanyName.Text.Trim());
            insertCmd.Parameters.AddWithValue("@contactName", txtContactName.Text.Trim());
            insertCmd.Parameters.AddWithValue("@contact", txtContactNo.Text.Trim());
            insertCmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
            insertCmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
