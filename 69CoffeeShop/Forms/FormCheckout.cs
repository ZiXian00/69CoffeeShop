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

namespace _69CoffeeShop.Forms
{
    public partial class FormCheckout : Form
    {
        List<Class.Product> orderList;
        Class.Employee emp = new Class.Employee();
        Class.Connection connection = new Class.Connection();

        private string orderID;
        private string salesID;

        public FormCheckout(List<Class.Product> orderList, DataGridView dgv)
        {
            InitializeComponent();
            this.orderList = orderList;

            for (int i = 0; i < orderList.Count; i++)
            {
                dataGridViewOrder.Rows.Add(dgv.Rows[i].Cells[0].Value.ToString(), dgv.Rows[i].Cells[1].Value.ToString(), dgv.Rows[i].Cells[2].Value.ToString(), dgv.Rows[i].Cells[3].Value.ToString(), dgv.Rows[i].Cells[4].Value.ToString());
            }
            labelDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            labelTime.Text = DateTime.Now.ToString("hh:mm");
            labelEmpID.Text = emp.employeeID;
            labelEmpName.Text = emp.employeeName;
            calculatePriceDetails();
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        FormSales sales = new FormSales();
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

        private void calculatePriceDetails()
        {
            double subPrice = 0;
            foreach (DataGridViewRow rows in dataGridViewOrder.Rows)
            {
                if (rows.Cells["Price"].Value != null)
                {
                    subPrice += double.Parse(rows.Cells["Price"].Value.ToString());
                }
            }

            labelSubTotal.Text = subPrice.ToString("RM 0.00");
            double tax = subPrice * 0.06;
            labelTax.Text = tax.ToString("RM 0.00");
            labelGrandTotal.Text = (subPrice + tax).ToString("RM 0.00");
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

            TabControl tab = tabControlPayment as TabControl;
            updateSqlTable(tab.TabPages["tabPageCash"].Tag.ToString()); 
        }

        private void createSalesID()
        {
            string salesIDQry = "select salesID from sales order by salesID DESC LIMIT 1";
            connection.conn.Open();
            MySqlCommand salesIDCmd = new MySqlCommand(salesIDQry, connection.conn);
            MySqlDataReader salesIDRdr = salesIDCmd.ExecuteReader();
            string previousID;
            int idIncrement = 1;

            if (salesIDRdr.Read())
            {
                string checkDate = salesIDRdr.GetString(0);
                checkDate = checkDate.Substring(0, 8);
                previousID = salesIDRdr.GetString(0);

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
            string orderIDQuery = "select orderID from orders ORDER BY orderID DESC LIMIT 1";
            MySqlCommand orderIDCmd = new MySqlCommand(orderIDQuery, connection.conn);
            MySqlDataReader orderIDRdr = orderIDCmd.ExecuteReader();

            if (orderIDRdr.Read())
            {
                string lastID = orderIDRdr.GetString(0);
                string checkDate = orderIDRdr.GetString(0);
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
            else if(method == "e-Wallet")
            {
                custPaid = labelGrandTotal.Text.ToString();
                custPaid = custPaid.Substring(3);
            }

            Class.Employee emp = new Class.Employee();
            emp.employeeID = "E1001";

            try
            {
                string insertOrderQry = "insert into orders value (@id, @mID, @eID)";
                MySqlCommand insertOrderCmd = new MySqlCommand(insertOrderQry, connection.conn);
                connection.conn.Open();
                insertOrderCmd.Parameters.AddWithValue("@id", orderID);
                insertOrderCmd.Parameters.AddWithValue("@mID", "M0001");
                insertOrderCmd.Parameters.AddWithValue("@eID", emp.employeeID);
                insertOrderCmd.ExecuteNonQuery();

                for (int i = 0; i < orderList.Count; i++)
                {
                    string orderProdQry = "insert into product_order value (@oID, @pID, @qty)";
                    MySqlCommand orderProdCmd = new MySqlCommand(orderProdQry, connection.conn);
                    orderProdCmd.Parameters.AddWithValue("@oid", orderID);
                    orderProdCmd.Parameters.AddWithValue("@pid", orderList[i].productID);
                    orderProdCmd.Parameters.AddWithValue("@qty", dataGridViewOrder.Rows[i].Cells["Qty"].Value);
                    orderProdCmd.ExecuteNonQuery();
                }

                string salesTableQry = "insert into sales values(@sID, @amount, @method, @orderID, @date, @custPaid)";
                MySqlCommand salesTableCmd = new MySqlCommand(salesTableQry, connection.conn);
                salesTableCmd.Parameters.AddWithValue("@sID", salesID);
                salesTableCmd.Parameters.AddWithValue("@amount", labelGrandTotal.Text.ToString().Substring(3));
                salesTableCmd.Parameters.AddWithValue("@method", method);
                salesTableCmd.Parameters.AddWithValue("@orderID", orderID);
                salesTableCmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                salesTableCmd.Parameters.AddWithValue("@custPaid", custPaid);
                salesTableCmd.ExecuteNonQuery();

                DialogResult ds = MessageBox.Show("Payment success. Proceed to product menu", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(ds == DialogResult.OK)
                {
                    FormSales sales = new FormSales();
                    sales.TopLevel = false;
                    sales.Parent = this.Parent;
                    sales.FormBorderStyle = FormBorderStyle.None;
                    sales.Dock = DockStyle.Fill;
                    sales.BringToFront();
                    sales.Show();
                    this.Close();
                }
            }
            catch(Exception ex)
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
            if(tabControlPayment.SelectedTab == tabControlPayment.TabPages["tabPageQR"])
            {
                filterIC = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach(FilterInfo filter in filterIC)
                {
                    comboBoxCamera.Items.Add(filter.Name);
                }
                comboBoxCamera.SelectedIndex = 0;
            }
            else
            {
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxQR.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBoxQR.Image);

                if (result != null)
                {
                    textBox1.Text = "Payment " + labelGrandTotal.Text.ToString() + " has received";
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
