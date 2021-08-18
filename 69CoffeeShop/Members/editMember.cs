using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Members
{
    public partial class editMember : Form
    {
        public editMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            label1.Visible = false;
            btnSearch.Visible = false;
            btnCancel.Visible = false;
            txtMemberID.Visible = false;
            panelEdit.Visible = true;

        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label1.Visible = true;
            btnSearch.Visible = true;
            btnCancel.Visible = true;
            txtMemberID.Visible = true;
            panelEdit.Visible = false;

        }
    }
}
