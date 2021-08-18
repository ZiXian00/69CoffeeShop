using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Admins
{
    public partial class FormOverallAdmin : Form
    {
        public FormOverallAdmin()
        {
            InitializeComponent();
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            Form addAdm = new FormAddAdmin();
            addAdm.ShowDialog();
        }
    }
}
