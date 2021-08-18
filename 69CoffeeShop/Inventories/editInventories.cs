using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Inventories
{
    public partial class editInventories : Form
    {
        public editInventories()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = true;
            label1.Visible = false;
            label8.Visible = false;
            btnSearch.Visible = false;
            btnCancel.Visible = false;
            txtInventoryID.Visible = false;
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            label1.Visible = true;
            label8.Visible = true;
            btnSearch.Visible = true;
            btnCancel.Visible = true;
            txtInventoryID.Visible = true;
        }
    }
}
