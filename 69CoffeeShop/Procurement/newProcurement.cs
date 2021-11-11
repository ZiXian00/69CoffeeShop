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

namespace _69CoffeeShop.Procurement
{
    public partial class newProcurement : Form
    {
        public string InvenID, InvenName, Description, unitPrice, SupID, contactPerson;
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public newProcurement()
        {
            InitializeComponent();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            MakeOrder();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "" || txtQuantity.Text == "0" || txtQuantity.Text == "00" || txtQuantity.Text == "000" || txtQuantity.Text == "0000")
            {
                MessageBox.Show("Please enter the Order Quantity to continue..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Focus();
            }
            else
            {
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
                        string query = "Insert into procurement (procurementID, orderedProduct, unitPrice, quantity, procurementDate, supplierID, proCount) values (@procurementID, @orderedProduct, @unitPrice, @quantity, @procurementDate, @supplierID, @proCount)";
                        MySqlCommand insertCmd = new MySqlCommand(query, conn);
                        insertCmd.Parameters.AddWithValue("@procurementID", Class.Utilities.encryption(lblProcurementID.Text));
                        insertCmd.Parameters.AddWithValue("@orderedProduct", Class.Utilities.encryption(InvenName));
                        insertCmd.Parameters.AddWithValue("@unitPrice", Class.Utilities.encryption(unitPrice));
                        insertCmd.Parameters.AddWithValue("@quantity", Class.Utilities.encryption(txtQuantity.Text));
                        insertCmd.Parameters.AddWithValue("@procurementDate", Class.Utilities.encryption(tdyDate));
                        insertCmd.Parameters.AddWithValue("@supplierID", Class.Utilities.encryption(SupID));
                        insertCmd.Parameters.AddWithValue("@proCount", lblCount.Text.Trim());
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


        private void newProcurement_Load(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT companyName, contactName, email FROM supplier WHERE supplierID = @supplierID", conn);
            cmd.Parameters.AddWithValue("supplierID", Class.Utilities.encryption(SupID));
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtEmailTo.Text = Class.Utilities.decryption(dr["email"].ToString());
                txtCompanyName.Text = Class.Utilities.decryption(dr["companyName"].ToString());
                contactPerson = Class.Utilities.decryption(dr["contactName"].ToString());
            }
            else
            {
                MessageBox.Show("No data found.");
            }

            conn.Close();
            LoadId();
            MakeOrder();
        }

        private void MakeOrder()
        {
            txtSubject.Text = "Make order for item " + InvenName + " " + Description;
            txtMsg.Text = "Good Day " + contactPerson + "\n" + "Our shop wish to make an order for item " + InvenName + " " + Description + " with a quantity of " + txtQuantity.Text + ".\nHope to get reply soon. Thank You. \n\n69CofeeShop";
        }

        private void LoadId()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "select proCount from procurement ORDER BY proCount DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int currentCount = Convert.ToInt32(dr.GetValue(0));
                currentCount++;
                string invenId = "P" + String.Format("{0:0000}", currentCount);
                lblProcurementID.Text = invenId;
                lblCount.Text = currentCount.ToString();


            }
            else
            {
                lblProcurementID.Text = "P0001";
                lblCount.Text = "1";
            }
        }

    }
}
