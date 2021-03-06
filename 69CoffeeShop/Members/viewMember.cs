using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Members
{
    public partial class viewMember : Form
    {

        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        editMember edtMem;
        newEmailMarketing sEmail;

        public viewMember()
        {
            InitializeComponent();
            edtMem = new editMember();
            sEmail = new newEmailMarketing();
        }

        public void PrintGridView()
        {
            dataGridViewMember.Rows.Clear();

            string memQuery = "SELECT * FROM member ORDER BY memCount ";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(memQuery, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                dataGridViewMember.Rows.Add(Class.Utilities.decryption(dr["memberID"].ToString()), Class.Utilities.decryption(dr["memberName"].ToString()), Class.Utilities.decryption(dr["contactNo"].ToString()), Class.Utilities.decryption(dr["dateOfBirth"].ToString()), Class.Utilities.decryption(dr["email"].ToString()), Class.Utilities.decryption(dr["rewardsPoint"].ToString()));
            }


            
            conn.Close();
        }

        private void viewMember_Load(object sender, EventArgs e)
        {
            PrintGridView();
        }
        
        

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                foreach (DataGridViewRow row in dataGridViewMember.Rows)
                {
                    if (row.Cells["memberID"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["memberName"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["contactNo"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else if (row.Cells["email"].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                PrintGridView();
            }

        }

        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                edtMem.memID = dataGridViewMember.Rows[e.RowIndex].Cells[0].Value.ToString();
                edtMem.memberName = dataGridViewMember.Rows[e.RowIndex].Cells[1].Value.ToString();
                edtMem.contactNo = dataGridViewMember.Rows[e.RowIndex].Cells[2].Value.ToString();
                edtMem.dob = dataGridViewMember.Rows[e.RowIndex].Cells[3].Value.ToString();
                edtMem.email = dataGridViewMember.Rows[e.RowIndex].Cells[4].Value.ToString();
                edtMem.point = dataGridViewMember.Rows[e.RowIndex].Cells[5].Value.ToString();
                edtMem.UpdateMember();
                edtMem.ShowDialog();
                PrintGridView();
                return;
            }
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DeleteMember(dataGridViewMember.Rows[e.RowIndex].Cells[0].Value.ToString());
                    PrintGridView();
                }

                return;
            }
            if (e.ColumnIndex == 8)
            {
                sEmail.memID = dataGridViewMember.Rows[e.RowIndex].Cells[0].Value.ToString();
                sEmail.memName = dataGridViewMember.Rows[e.RowIndex].Cells[1].Value.ToString();
                sEmail.dob = dataGridViewMember.Rows[e.RowIndex].Cells[3].Value.ToString();
                sEmail.email = dataGridViewMember.Rows[e.RowIndex].Cells[4].Value.ToString();
                sEmail.InputDetails();
                sEmail.ShowDialog();
                return;
            }
        }

        public static void DeleteMember(string id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            string sql = "DELETE FROM member WHERE memberID = @memberID";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@memberID", MySqlDbType.VarChar).Value = Class.Utilities.encryption(id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Member not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }


}
