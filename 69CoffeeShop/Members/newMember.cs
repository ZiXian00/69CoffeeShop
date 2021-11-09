using Devart.Data.MySql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Members
{
    public partial class newMember : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public newMember()
        {
            InitializeComponent();
            
        }

        private void txtMemContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
        private void newMember_Load(object sender, EventArgs e)
        {
            dtpDOB.MinDate = DateTime.Now.AddYears(-100);
            dtpDOB.MaxDate = DateTime.Now.AddYears(-18);
            LoadID();
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMemName.Text == "" || txtEmail.Text == "" || txtMemContact.Text == "" )
            {
                MessageBox.Show("Please enter all the details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Regex.Match(txtMemContact.Text, "^(01)[0-46-9]*[0-9]{7,8}$").Success == false)
            {
                if(MessageBox.Show("Please enter a valid contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtMemContact.Clear();
                }
            }
            else if (Regex.Match(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success == false)
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
                string query = "Insert into member (memberID, memberName, contactNo, dateOfBirth, email, rewardsPoint, memCount) values (@memberID, @memberName, @contactNo, @dateOfBirth, @email, @rewardsPoint, @memCount)";
                MySqlCommand insertCmd = new MySqlCommand(query, conn);
                insertCmd.Parameters.AddWithValue("@memberID", Class.Utilities.encryption(lblMemID.Text));
                insertCmd.Parameters.AddWithValue("@memberName", Class.Utilities.encryption(txtMemName.Text));
                insertCmd.Parameters.AddWithValue("@contactNo", Class.Utilities.encryption(txtMemContact.Text));
                insertCmd.Parameters.AddWithValue("@dateOfBirth", Class.Utilities.encryption(dtpDOB.Text));
                insertCmd.Parameters.AddWithValue("@email", Class.Utilities.encryption(txtEmail.Text));
                insertCmd.Parameters.AddWithValue("@rewardsPoint", Class.Utilities.encryption("0"));
                insertCmd.Parameters.AddWithValue("@memCount",lblCount.Text.Trim());
                try
                {
                    insertCmd.ExecuteNonQuery();
                    if (MessageBox.Show("Member saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        txtMemContact.Text = "";
                        txtMemName.Text = "";
                        txtEmail.Text = "";
                        LoadID();
                    }


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Member not save. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        private void LoadID()
        {
           
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "SELECT MAX(memCount) FROM member";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int currentCount = Convert.ToInt32(dr.GetValue(0));
                currentCount++;
                string memID = "M" + String.Format("{0:0000}", currentCount);
                lblMemID.Text = memID;
                lblCount.Text = currentCount.ToString();


            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        
        

        

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToLower(e.KeyChar);
        }

        private void txtMemName_KeyPress(object sender, KeyPressEventArgs e)
        {

           
            if(!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == ((char)39)))
            {
                e.Handled = true;
            }
        }

        
        }
    }
