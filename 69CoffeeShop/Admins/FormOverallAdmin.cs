using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _69CoffeeShop.Forms;
using MySql.Data.MySqlClient;

namespace _69CoffeeShop.Admins
{
    public partial class FormOverallAdmin : Form
    {
        Class.Connection connection = new Class.Connection();
        private FormAdmin formAdmin;

        public FormOverallAdmin()
        {
            InitializeComponent();
        }

        public FormOverallAdmin(FormAdmin formAdmin)
        {
            InitializeComponent();
            this.formAdmin = formAdmin;
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            Form addAdm = new FormAddAdmin(this);
            addAdm.ShowDialog();
        }

        private void FormOverallAdmin_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        private void iconButtonChangePw_Click(object sender, EventArgs e)
        {
            FormAdminChangePassword admChangePw = new FormAdminChangePassword(formAdmin);

            admChangePw.ShowDialog();
            this.Close();
        }

        private void iconButtonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdminList.SelectedRows.Count == 0 && dataGridViewAdminList.SelectedCells.Count == 0)
            {
                dataGridViewAdminList.Rows[0].Selected = true;
            }

            int rowIndex = dataGridViewAdminList.SelectedCells[0].RowIndex;

            DialogResult ds = MessageBox.Show("Remove " + dataGridViewAdminList.Rows[rowIndex].Cells["employeeName"].Value + "?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 

            if(ds == DialogResult.Yes)
            {
                string deleteAdmQry = "delete from admin where employeeID = @id";
                MySqlCommand deleteAdmCmd = new MySqlCommand(deleteAdmQry, connection.conn);
                deleteAdmCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(dataGridViewAdminList.Rows[rowIndex].Cells["employeeID"].Value.ToString()));
                connection.conn.Open();
                deleteAdmCmd.ExecuteNonQuery();

                connection.conn.Close();

                refreshGridView();
            }
        }

        public void refreshGridView()
        {
            dataGridViewAdminList.Rows.Clear();

            string loadAdminQry = "select * from admin a INNER JOIN employees e ON a.employeeID = e.employeeID Order By e.employeeCount";

            MySqlCommand loadAdminCmd = new MySqlCommand(loadAdminQry, connection.conn);
            connection.conn.Open();
            MySqlDataReader loadAdminReader = loadAdminCmd.ExecuteReader();

            
            while (loadAdminReader.Read())
            {
                dataGridViewAdminList.Rows.Add(Class.Utilities.decryption(loadAdminReader["employeeName"].ToString()), Class.Utilities.decryption(loadAdminReader["employeeID"].ToString()), Class.Utilities.decryption(loadAdminReader["position"].ToString()), Class.Utilities.decryption(loadAdminReader["lastCheckedIn"].ToString()), Class.Utilities.decryption(loadAdminReader["lastCheckedOut"].ToString()));
            }
            

            loadAdminReader.Close();
            connection.conn.Close();
        }
    }
}


