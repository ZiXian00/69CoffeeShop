using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Members
{
    public partial class newEmailMarketing : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public string memID, memName, dob, email, desc;
        public newEmailMarketing()
        {
            InitializeComponent();
        }

        private void rbNewProduct_CheckedChanged(object sender, EventArgs e)
        {
            txtSubject.Text = "New Product";
            txtMsg.Text = "Good Day " + memName + ", \r\n\nIntroduce to you our new product : \r\nTry it now! \r\n\n69CoffeeShop";
        }
        private void rbBirthday_CheckedChanged(object sender, EventArgs e)
        {
            txtSubject.Text = "Birthday month promotion for you!";
            txtMsg.Text = "Hi " + memName + ", \r\n\nHappy Birthday to you! \r\nEnjoy 10% discount with any purchase of two products in our shop when you show this email while checkout in this month. \r\nTerms and conditions applied. \r\n\n69CoffeeShop";
        }

        private void rbBlank_CheckedChanged(object sender, EventArgs e)
        {
            txtSubject.Text = "";
            txtMsg.Text = "";
            txtSubject.Enabled = true;
            txtMsg.Enabled = true;
        }

        private void newEmailMarketing_Load(object sender, EventArgs e)
        {
            LoadId();
            int month = DateTime.Now.Month;
            string[] getMonth = dob.Split('-');

            if(month != Convert.ToInt32(getMonth[1]))
            {
                rbBirthday.Enabled = false;
            }
            else
            {
                rbBirthday.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text == "")
            {
                MessageBox.Show("Please enter the Subject to continue..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if(txtMsg.Text == "")
            {
                MessageBox.Show("Please enter the Message to continue..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (rbBirthday.Checked == true)
                {
                    desc = "birthday";
                }
                else if(rbNewProduct.Checked == true)
                {
                    desc = "product";
                }
                else if(rbBlank.Checked == true)
                {
                    desc = "general";
                }
                try
                {
                    string from = "69coffeeshop.my@gmail.com";
                    string pw = "Coffeeshop@69.my";

                    MailMessage msg = new MailMessage();
                    msg.Subject = txtSubject.Text;
                    msg.From = new MailAddress(from);
                    msg.Body = txtMsg.Text;
                    msg.To.Add(new MailAddress(txtEmailTo.Text));

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;

                    NetworkCredential nc = new NetworkCredential(from, pw);
                    smtp.Credentials = nc;
                    smtp.Send(msg);

                    if ((MessageBox.Show("Email sent.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK))
                    {

                        string todayDate = DateTime.Today.ToShortDateString();
                        string[] temDate = todayDate.Split('/');
                        string tdyDate = temDate[2] + "-" + temDate[0] + "-" + temDate[1];

                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();
                        string query = "Insert into email_promotion (promotionID, memberID, description, date, promoCount) values (@promotionID, @memberID, @description, @date, @promoCount)";
                        MySqlCommand insertCmd = new MySqlCommand(query, conn);
                        insertCmd.Parameters.AddWithValue("@promotionID", Class.Utilities.encryption(lblPromotionID.Text));
                        insertCmd.Parameters.AddWithValue("@memberID", Class.Utilities.encryption(memID));
                        insertCmd.Parameters.AddWithValue("@description", Class.Utilities.encryption(desc));
                        insertCmd.Parameters.AddWithValue("@date", Class.Utilities.encryption(tdyDate));
                        insertCmd.Parameters.AddWithValue("@promoCount", lblCount.Text.Trim());
                        insertCmd.ExecuteNonQuery();
                        conn.Close();

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void LoadId()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "select promoCount from email_promotion ORDER BY promoCount DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int currentCount = Convert.ToInt32(dr.GetValue(0));
                currentCount++;
                string invenId = "PM" + String.Format("{0:0000}", currentCount);
                lblPromotionID.Text = invenId;
                lblCount.Text = currentCount.ToString();


            }
            else
            {
                lblPromotionID.Text = "PM0001";
                lblCount.Text = "1";
            }
        }

        public void InputDetails()
        {
            txtEmailTo.Text = email;
            txtMemName.Text = memName;
        }
    }
}
