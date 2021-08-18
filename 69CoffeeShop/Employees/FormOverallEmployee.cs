using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Employees
{
    public partial class FormOverallEmployee : Form
    {
        public FormOverallEmployee()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form addEmp= new FormAddEmployee();
            addEmp.ShowDialog();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Form viewEmp = new FormEmployeeProfile();
            viewEmp.ShowDialog();
        }
    }
}
