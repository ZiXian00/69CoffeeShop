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

namespace _69CoffeeShop.Employees
{
    public partial class FormAddEmployee : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        MySqlConnection conn;
        public FormAddEmployee()
        {
            InitializeComponent();
             conn = new MySqlConnection(connStr);
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            //testing
            conn.Open();
            string addQuery = "insert into employees values (@id, @name, @dob, @position, @contact, @email, @fp, @bankName, @bankAcc)";
            MySqlCommand addComm = new MySqlCommand(addQuery, conn);
            addComm.Parameters.AddWithValue("@id", "E1003");
            addComm.Parameters.AddWithValue("@name", "sam");
            addComm.Parameters.AddWithValue("@dob", DateTime.Now.ToString("dd-MM-yyyy"));
            addComm.Parameters.AddWithValue("@position", "manager");
            addComm.Parameters.AddWithValue("@contact", "0162673411");
            addComm.Parameters.AddWithValue("@email", "samch-pm18@student.tarc.edu.my");
            addComm.Parameters.AddWithValue("@fp", "full");
            addComm.Parameters.AddWithValue("@bankName", "Public Bank Berhad");
            addComm.Parameters.AddWithValue("@bankAcc", "1234123412341234");
            addComm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
