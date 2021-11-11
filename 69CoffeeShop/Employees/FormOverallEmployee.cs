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

namespace _69CoffeeShop.Employees
{
    public partial class FormOverallEmployee : Form
    {
        Class.Connection connection = new Class.Connection();
        //Class.Product product;
        public List<Class.Employee> employeeList { get; set; } = new List<Class.Employee>();

        public FormOverallEmployee()
        {
            InitializeComponent();
        }

        private void FormOverallEmployee_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        public void refreshGridView()
        {
            dataGridViewEmployeeList.Rows.Clear();

            string loadEmployeeQry = "select * from employees ORDER BY employeeCount";

            MySqlCommand loadEmployeeCmd = new MySqlCommand(loadEmployeeQry, connection.conn);
            connection.conn.Open();
            MySqlDataReader loadEmployeeReader = loadEmployeeCmd.ExecuteReader();

            while (loadEmployeeReader.Read())
            {
                dataGridViewEmployeeList.Rows.Add(Class.Utilities.decryption(loadEmployeeReader["employeeName"].ToString()), Class.Utilities.decryption(loadEmployeeReader["employeeID"].ToString()), Class.Utilities.decryption(loadEmployeeReader["position"].ToString()), Class.Utilities.decryption(loadEmployeeReader["lastCheckedIn"].ToString()), Class.Utilities.decryption(loadEmployeeReader["lastCheckedOut"].ToString()));
            }

            loadEmployeeReader.Close();
            connection.conn.Close();
            textBoxSearch.Text = "";
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            Form addEmp = new FormEmployeeProfile("add", null, this);
            addEmp.ShowDialog();
        }

        private void iconButtonProfile_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployeeList.SelectedRows.Count == 0 && dataGridViewEmployeeList.SelectedCells.Count == 0)
            {
                dataGridViewEmployeeList.Rows[0].Selected = true;
            }

            int rowIndex = dataGridViewEmployeeList.SelectedCells[0].RowIndex;

            Form viewEmp = new FormEmployeeProfile("view", dataGridViewEmployeeList.Rows[rowIndex].Cells["employeeID"].Value.ToString(), this);
            viewEmp.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != string.Empty)
            {
                foreach (DataGridViewRow row in dataGridViewEmployeeList.Rows)
                {
                    if (row.Cells["employeeName"].Value.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                        row.Visible = false;
                }
            }
            else
            {
                refreshGridView();
            }
        }

        //string loadEmployeeQry = "select * from employee_duty_record r1 " +
        //                   "JOIN (select MAX(checkIn) AS checkIn, employeeID from employee_duty_record GROUP BY employeeID) r2 " +
        //                   "ON r1.employeeID = r2.employeeID AND r1.checkIn = r2.checkIn ";

    }
}