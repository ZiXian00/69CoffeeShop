using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Configuration;

namespace _69CoffeeShop.Forms
{
    public partial class FormCheckout : Form
    {

        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        List<Class.Product> orderList;
        Class.Employee emp = new Class.Employee();
        Class.Connection connection = new Class.Connection();
        MainPage mainPage;

        public string memID, memName, point = "";
        private string orderID;
        private string salesID;

        public string empID { get; set; }
        public string empName { get; set; }

        public FormCheckout(List<Class.Product> orderList, DataGridView dgv, MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
            this.orderList = orderList;

            for (int i = 0; i < orderList.Count; i++)
            {
                dataGridViewOrder.Rows.Add(dgv.Rows[i].Cells[0].Value.ToString(), dgv.Rows[i].Cells[1].Value.ToString(), dgv.Rows[i].Cells[2].Value.ToString(), dgv.Rows[i].Cells[3].Value.ToString(), dgv.Rows[i].Cells[4].Value.ToString());
            }
            labelDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            labelTime.Text = DateTime.Now.ToString("HH:mm");
            labelEmpID.Text = Class.Cashier.cashierID;
            labelEmpName.Text = Class.Cashier.cashierName;
            calculatePriceDetails();
        }

        public FormCheckout()
        {
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            if(lblMemName.Text == "" || labelMemID.Text == "" || lblTotalPoint.Text == "")
            {
                cbRedeem.Visible = false;
            }
            else
            {
                cbRedeem.Visible = true;
            }
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Cancel order?", "Order Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(ds == DialogResult.Yes)
            {
                FormSales sales = new FormSales(mainPage);

                if (captureDevice != null)
                {
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
                mainPage.OpenChildForm(sales);
                this.Close();
            }
        }

        private void dataGridViewOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrder.RowCount > 0)
            {
                if (e.ColumnIndex == 1)
                {
                    int cellIndex = e.RowIndex;
                    int qty = int.Parse(dataGridViewOrder.Rows[cellIndex].Cells["Qty"].Value.ToString());
                    double getPrice = 0;

                    for (int i = 0; i < orderList.Count; i++)
                    {
                        if (orderList[i].productName == dataGridViewOrder.Rows[cellIndex].Cells["Product"].Value.ToString())
                        {
                            getPrice = double.Parse(orderList[i].unitPrice);
                        }
                    }

                    if (getPrice != 0)
                    {
                        dataGridViewOrder.Rows[cellIndex].Cells["Price"].Value = (getPrice * qty).ToString("0.00");
                    }

                    calculatePriceDetails();
                }
            }
        }

        private void dataGridViewOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calculatePriceDetails();
        }

        private void dataGridViewOrder_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //sales.dataGridViewOrder_RowsRemoved(sender, e);
        }

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellIndex = e.RowIndex;

            if (cellIndex >= 0)
            {
                int qty = int.Parse(dataGridViewOrder.Rows[cellIndex].Cells["Qty"].Value.ToString());
                if (e.ColumnIndex == 2)
                {
                    qty++;
                    dataGridViewOrder.Rows[cellIndex].Cells["Qty"].Value = qty.ToString();
                }
                if (e.ColumnIndex == 3)
                {
                    qty--;

                    if (qty < 1)
                    {
                        dataGridViewOrder.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        dataGridViewOrder.Rows[cellIndex].Cells["Qty"].Value = qty.ToString();
                    }
                }
                calculatePriceDetails();
            }
        }

        private void calculatePriceDetails()
        {
            double subPrice = 0;
            string[] discount = lblDiscount.Text.Split(' ');
            foreach (DataGridViewRow rows in dataGridViewOrder.Rows)
            {
                if (rows.Cells["Price"].Value != null)
                {
                    subPrice += double.Parse(rows.Cells["Price"].Value.ToString());
                }
            }

            labelSubTotal.Text = subPrice.ToString("RM 0.00");
            double subtotal = subPrice - Convert.ToDouble(discount[1]);
            double tax = subtotal * 0.06;
            labelTax.Text = tax.ToString("RM 0.00");
            labelGrandTotal.Text = (subtotal + tax).ToString("RM 0.00");
        }

        private void keyPad(string str)
        {
            if (checkDec == true)
            {
                textBoxCustPaid.Text = textBoxCustPaid.Text + str;
            }
        }

        private void buttonKeyPad_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            keyPad(btn.Text);
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            string str = textBoxCustPaid.Text;
            textBoxCustPaid.Text = str.Remove(str.Length - 1);
        }

        bool checkDec = true;

        private void textBoxCustPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = textBoxCustPaid.Text;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(str, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (str.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxCustPaid_TextChanged(object sender, EventArgs e)
        {
            string str = textBoxCustPaid.Text;

            if (str.Length > 0)
            {
                if (str.Contains("."))
                {
                    if (Regex.IsMatch(str, @"\.\d\d"))
                    {
                        checkDec = false;
                    }
                    else
                    {
                        checkDec = true;
                    }
                }
            }

            if (textBoxCustPaid.Text.Contains("."))
            {
                buttonDot.Enabled = false;
            }
            else
            {
                buttonDot.Enabled = true;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string grandTotal = labelGrandTotal.Text;
            grandTotal = grandTotal.Substring(3);
            double changes = (double.Parse(textBoxCustPaid.Text) - double.Parse(grandTotal));

            if (changes < 0)
            {
                MessageBox.Show("Paid amount should more than Grand-Total.", "Insufficient Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxChanges.Text = "";
            }
            else
            {
                textBoxChanges.Text = changes.ToString("0.00");
                buttonComplete.Enabled = true;
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            createOrderID();
            createSalesID();
            UpdateMemPoint();

            TabControl tab = tabControlPayment as TabControl;
            updateSqlTable(tab.TabPages["tabPageCash"].Tag.ToString());
        }

        private void createSalesID()
        {
            string salesIDQry = "select salesID from sales order by salesCount DESC LIMIT 1";
            connection.conn.Open();
            MySqlCommand salesIDCmd = new MySqlCommand(salesIDQry, connection.conn);
            MySqlDataReader salesIDRdr = salesIDCmd.ExecuteReader();
            string previousID;
            int idIncrement = 1;

            if (salesIDRdr.Read())
            {
                string checkDate = Class.Utilities.decryption(salesIDRdr.GetString(0));
                checkDate = checkDate.Substring(0, 8);
                previousID = Class.Utilities.decryption(salesIDRdr.GetString(0));

                if (checkDate == DateTime.Now.ToString("ddMMyyyy"))
                {
                    idIncrement = int.Parse(previousID.Substring(24));
                    idIncrement++;
                }
            }
            salesIDRdr.Close();
            connection.conn.Close();
            salesID = idIncrement.ToString(DateTime.Now.ToString("ddMMyyyy") + ":" + orderID + "::0000");
        }

        private void createOrderID()
        {
            int idIncrement = 1;
            connection.conn.Open();
            string orderIDQuery = "select orderID from orders ORDER BY orderCount DESC LIMIT 1";
            MySqlCommand orderIDCmd = new MySqlCommand(orderIDQuery, connection.conn);
            MySqlDataReader orderIDRdr = orderIDCmd.ExecuteReader();

            if (orderIDRdr.Read())
            {
                string lastID = Class.Utilities.decryption(orderIDRdr.GetString(0));
                string checkDate = Class.Utilities.decryption(orderIDRdr.GetString(0));
                checkDate = checkDate.Substring(1, 8);

                if (checkDate == DateTime.Now.ToString("ddMMyyyy"))
                {
                    idIncrement = int.Parse(lastID.Substring(9));
                    idIncrement++;
                }
            }
            orderIDRdr.Close();
            connection.conn.Close();
            orderID = idIncrement.ToString("O" + DateTime.Now.ToString("ddMMyyyy") + "0000");
        }

        //insert into sales, order and product_order table
        private void updateSqlTable(string method)
        {
            string custPaid = "";
            if (method == "Cash")
            {
                custPaid = textBoxCustPaid.Text.ToString();
            }
            else if (method == "e-Wallet")
            {
                custPaid = labelGrandTotal.Text.ToString();
                custPaid = custPaid.Substring(3);
            }

            try
            {
                if (member == true)
                {
                    string insertOrderQry = "insert into orders (orderID, memberID, employeeID) value (@id, @mID, @eID)";
                    MySqlCommand insertOrderCmd = new MySqlCommand(insertOrderQry, connection.conn);
                    connection.conn.Open();
                    insertOrderCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(orderID));
                    insertOrderCmd.Parameters.AddWithValue("@mID", Class.Utilities.encryption(labelMemID.Text));
                    insertOrderCmd.Parameters.AddWithValue("@eID", Class.Utilities.encryption(Class.Cashier.cashierID));
                    insertOrderCmd.ExecuteNonQuery();
                }
                else
                {
                    string insertOrderQry = "insert into orders (orderID, employeeID) value (@id, @eID)";
                    MySqlCommand insertOrderCmd = new MySqlCommand(insertOrderQry, connection.conn);
                    connection.conn.Open();
                    insertOrderCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(orderID));
                    insertOrderCmd.Parameters.AddWithValue("@eID", Class.Utilities.encryption(Class.Cashier.cashierID));
                    insertOrderCmd.ExecuteNonQuery();
                }


                for (int i = 0; i < orderList.Count; i++)
                {
                    string orderProdQry = "insert into product_order value (@oID, @pID, @qty)";
                    MySqlCommand orderProdCmd = new MySqlCommand(orderProdQry, connection.conn);
                    orderProdCmd.Parameters.AddWithValue("@oid", Class.Utilities.encryption(orderID));
                    orderProdCmd.Parameters.AddWithValue("@pid", Class.Utilities.encryption(orderList[i].productID));
                    orderProdCmd.Parameters.AddWithValue("@qty", Class.Utilities.encryption(dataGridViewOrder.Rows[i].Cells["Qty"].Value.ToString()));
                    orderProdCmd.ExecuteNonQuery();
                }

                string salesTableQry = "insert into sales (salesID, salesAmount, paymentMethod, orderID, date, custPaid) values(@sID, @amount, @method, @orderID, @date, @custPaid)";
                MySqlCommand salesTableCmd = new MySqlCommand(salesTableQry, connection.conn);
                salesTableCmd.Parameters.AddWithValue("@sID", Class.Utilities.encryption(salesID));
                salesTableCmd.Parameters.AddWithValue("@amount", Class.Utilities.encryption(labelGrandTotal.Text.ToString().Substring(3)));
                salesTableCmd.Parameters.AddWithValue("@method", Class.Utilities.encryption(method));
                salesTableCmd.Parameters.AddWithValue("@orderID", Class.Utilities.encryption(orderID));
                salesTableCmd.Parameters.AddWithValue("@date", Class.Utilities.encryption(DateTime.Now.ToString("yyyy-MM-dd")));
                salesTableCmd.Parameters.AddWithValue("@custPaid", Class.Utilities.encryption(custPaid));
                salesTableCmd.ExecuteNonQuery();

                DialogResult ds = MessageBox.Show("Payment success. Proceed to product menu", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (ds == DialogResult.OK)
                {
                    FormSales sales = new FormSales(mainPage);
                    mainPage.OpenChildForm(sales);
                    this.Close();
                }

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.conn.Close();
            }
        }

        FilterInfoCollection filterIC;
        VideoCaptureDevice captureDevice;

        private void tabControlPayment_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlPayment.SelectedTab == tabControlPayment.TabPages["tabPageQR"])
            {
                filterIC = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filter in filterIC)
                {
                    comboBoxCamera.Items.Add(filter.Name);
                }
                comboBoxCamera.SelectedIndex = 0;
            }
            else
            {
                if (captureDevice != null)
                {
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterIC[comboBoxCamera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void cbRedeem_CheckedChanged(object sender, EventArgs e)
        {
            string[] subt = labelSubTotal.Text.Split(' ');
            if (cbRedeem.Checked == true)
            {
                if (labelMemID.Text == "-" || labelMemID.Text == "")
                {
                    if(MessageBox.Show("Please enter a member to continue..", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        cbRedeem.Checked = false;
                        txtMemID.Focus();
                    }
                }
                else if (Convert.ToInt32(lblTotalPoint.Text) >= 100)
                {
                    int dis = Convert.ToInt32(lblTotalPoint.Text) / 100;
                    if (Convert.ToDouble(subt[1]) >= Convert.ToDouble(dis))
                    {
                        lblDiscount.Text = dis.ToString("RM 0.00");
                        calculatePriceDetails();
                        //exist - discount * 100
                    }
                    else
                    {
                        lblDiscount.Text = labelSubTotal.Text;
                        calculatePriceDetails();
                    }

                }
                else
                {
                    MessageBox.Show("Point is not enough to redeem..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblDiscount.Text = "RM 0.00";
                    cbRedeem.Checked = false;
                }
            }
            else
            {
                lblDiscount.Text = "RM 0.00";
                calculatePriceDetails();
            }
        }

        private void UpdateMemPoint()
        {
            int existPoint = Convert.ToInt32(lblTotalPoint.Text);
            string[] discount = lblDiscount.Text.Split(' ');
            string[] discount1 = discount[1].Split('.');
            int dis = Convert.ToInt32(discount1[0]) * 100;

            string[] gTotal = labelGrandTotal.Text.Split(' ');
            string[] gTotal1 = gTotal[1].Split('.');
            int addPoint = Convert.ToInt32(gTotal1[0]);
            int finalPoint = existPoint - dis + addPoint;

            string sql = "UPDATE member SET rewardsPoint = @rewardsPoint WHERE memberID = @memberID";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@rewardsPoint", Class.Utilities.encryption(finalPoint.ToString()));
            cmd.Parameters.AddWithValue("@memberID", Class.Utilities.encryption(labelMemID.Text));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void textBoxCustPaid_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text != "")
            {
                double text = double.Parse(textBox.Text);
                textBox.Text = text.ToString("0.00");
            }
        }

        Boolean member;

        private void textBoxChanges_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void labelMemID_TextChanged(object sender, EventArgs e)
        {
            if(labelMemID.Text == "-" || labelMemID.Text == " ")
            {
                cbRedeem.Enabled = false;
                cbRedeem.Visible = false;
            }
            else
            {
                cbRedeem.Enabled = true;
                cbRedeem.Visible = true;
            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            string memQuery = "SELECT memberID, memberName, rewardsPoint FROM member WHERE memberID = @memberID OR memberName = @memberName";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(memQuery, conn);
            cmd.Parameters.AddWithValue("@memberID", Class.Utilities.encryption(txtMemID.Text));
            cmd.Parameters.AddWithValue("@memberName", Class.Utilities.encryption(txtMemID.Text));
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtMemID.Text = Class.Utilities.decryption(dr["memberID"].ToString());
                lblMemName.Text = Class.Utilities.decryption(dr["memberName"].ToString());
                lblTotalPoint.Text = Class.Utilities.decryption(dr["rewardsPoint"].ToString());
                labelMemID.Text = Class.Utilities.decryption(dr["memberID"].ToString());
                member = true;
            }
            else
            {
                if (MessageBox.Show("No member found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txtMemID.Text = "";
                    txtMemID.Text = "-";
                    lblMemName.Text = "-";
                    lblTotalPoint.Text = "-";
                    labelMemID.Text = "-";
                    member = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxQR.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBoxQR.Image);

                if (result != null)
                {
                    textBox1.Text = "Payment amount : " + labelGrandTotal.Text.ToString() + " has received";
                    createOrderID();
                    createSalesID();

                    TabControl tab = tabControlPayment as TabControl;
                    updateSqlTable(tab.TabPages["tabPageQR"].Tag.ToString());
                    timer1.Stop();
                    comboBoxCamera.Items.Clear();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }

    }
}
