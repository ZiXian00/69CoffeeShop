using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows;
using NuGet.Protocol.Plugins;
using MessageBox = System.Windows.MessageBox;
using System.IO;

namespace _69CoffeeShop.Forms
{
    public partial class FormSales : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        MySqlConnection conn;
        Button btn;
        double subPrice = 0;
        List<Class.Product> orderList = new List<Class.Product>();
        Class.Product prod;
        private MainPage mainPage;

        public FormSales()
        {
            InitializeComponent();
        }
        public FormSales(MainPage mainPage) 
        { 
            InitializeComponent();
            conn = new MySqlConnection(connStr);
            this.mainPage = mainPage;
       
            string prodName;
            double prodPrice;

            conn.Open();
            string loadQuery = "select * from products ORDER BY productCount";
            MySqlCommand loadComm = new MySqlCommand(loadQuery, conn);
            MySqlDataReader loadReader = loadComm.ExecuteReader();
            while (loadReader.Read())
            {
                byte[] img = (byte[])loadReader["productImage"];
                MemoryStream ms = new MemoryStream(img);

                prodName = Class.Utilities.decryption(loadReader["productName"].ToString());
                prodPrice = double.Parse(Class.Utilities.decryption(loadReader["unitPrice"].ToString()));
                btn = new Button { BackgroundImage = Image.FromStream(ms), Text = prodName, TextImageRelation = TextImageRelation.ImageAboveText, Height = 180, Width = 180, BackgroundImageLayout = ImageLayout.Stretch, TextAlign = ContentAlignment.BottomCenter, Margin = new Padding(12) };
                btn.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);

                tableLayoutPanelMenu.Controls.Add(btn);
                btn.Click += new EventHandler(btn_Click);
            }
            loadReader.Close();
            conn.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string prodName = btn.Text;
            addOrderList(prodName);

            for(int i = 0; i < orderList.Count; i++)
            {
                if(orderList[i].productName == prodName)
                {
                    if (dataGridViewOrder.RowCount > 0)
                    {
                        int checkOrderGVreturn = checkOrderGV(prodName);
                        if (checkOrderGVreturn >= 0)
                        {
                            // MessageBox.Show("yes");
                            int qty = int.Parse(dataGridViewOrder.Rows[checkOrderGVreturn].Cells["Qty"].Value.ToString());
                            qty++;
                            dataGridViewOrder.Rows[checkOrderGVreturn].Cells["Qty"].Value = qty.ToString();
                        }
                        else
                        {
                            // MessageBox.Show("no");
                            double price = double.Parse(orderList[i].unitPrice); 
                            this.dataGridViewOrder.Rows.Add(prodName, "1", "+", "-", price.ToString("0.00"));
                        }
                    }
                    else
                    {
                        // MessageBox.Show("no");
                        double price = double.Parse(orderList[i].unitPrice);
                        this.dataGridViewOrder.Rows.Add(prodName, "1", "+", "-", price.ToString("0.00"));
                    }
                }
            }
        }

        private int checkOrderGV(string prodName)
        {
            string productName;
            foreach (DataGridViewRow rows in dataGridViewOrder.Rows)
            {
                if (rows.Cells["Product"].Value != null)
                {
                    productName = rows.Cells["Product"].Value.ToString();
                    if (productName.Equals(prodName))
                    {
                        return rows.Index;
                    }
                }
            }
            return -1;
        }

        private void calculateSubTotal()
        {
            foreach (DataGridViewRow rows in dataGridViewOrder.Rows)
            {
                if (rows.Cells["Price"].Value != null)
                {
                    subPrice += double.Parse(rows.Cells["Price"].Value.ToString());
                }
            }
            labelSPrice.Text = subPrice.ToString("RM 0.00");
            subPrice = 0;
        }

        private void dataGridViewOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrder.RowCount > 0 )
            {
                if (e.ColumnIndex == 1)
                {
                    int cellIndex = e.RowIndex;
                    int qty = int.Parse(dataGridViewOrder.Rows[cellIndex].Cells["Qty"].Value.ToString());
                    double getPrice = 0;

                    for(int i=0;i<orderList.Count; i++)
                    {
                        if(orderList[i].productName == dataGridViewOrder.Rows[cellIndex].Cells["Product"].Value.ToString())
                        {
                            getPrice = double.Parse(orderList[i].unitPrice);
                        }
                    }

                    if (getPrice != 0)
                    {
                        dataGridViewOrder.Rows[cellIndex].Cells["Price"].Value = (getPrice * qty).ToString("0.00");
                    }

                    calculateSubTotal();
                }
            }
        }

        private void dataGridViewOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calculateSubTotal();
            iconButtonCheckout.Enabled = true;
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

            if(e.ColumnIndex == 3)
            {
                qty--;

                if (qty < 1)
                {
                    dataGridViewOrder.Rows.RemoveAt(e.RowIndex);
                    orderList.RemoveAt(e.RowIndex);
                }
                else
                {
                    dataGridViewOrder.Rows[cellIndex].Cells["Qty"].Value = qty.ToString();
                }
            }
            calculateSubTotal();
        }

        //Qry = Query;
        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            FormCheckout checkout = new FormCheckout(orderList, dataGridViewOrder, mainPage);
            mainPage.OpenChildForm(checkout);

            //checkout.TopLevel = false;
            //checkout.Parent = this.Parent;
            //checkout.FormBorderStyle = FormBorderStyle.None;
            //checkout.Dock = DockStyle.Fill;
            //checkout.BringToFront();
            //checkout.Show();
        }

        private void addOrderList(string prodName)
        {
            int checkOrderGVReturn = checkOrderGV(prodName);

            if (checkOrderGVReturn < 0)
            {
                string getProdDetQry = "select * from products where productName = @prodName";
                conn.Open();
                MySqlCommand getProdDetCmd = new MySqlCommand(getProdDetQry, conn);
                getProdDetCmd.Parameters.AddWithValue("@prodName", Class.Utilities.encryption(prodName));
                MySqlDataReader getProdDetRdr = getProdDetCmd.ExecuteReader();

                while (getProdDetRdr.Read())
                {
                    byte[] prodImg = (byte[])getProdDetRdr["productImage"];
                    prod = new Class.Product(Class.Utilities.decryption(getProdDetRdr.GetString(0)), prodName, Class.Utilities.decryption(getProdDetRdr.GetString(2)), Class.Utilities.decryption(getProdDetRdr.GetString(3)), prodImg);
                    orderList.Add(prod);
                }
                conn.Close();
            }
        }

        private void dataGridViewOrder_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridViewOrder.RowCount < 1)
            {
                iconButtonCheckout.Enabled = false;
            }
        }


        //BACKUP CODE
        //private string getUnitPrice(string name)
        //{
        //    string orderListQuery = "select ROUND(unitPrice, 2) from products where productName = @prodName";
        //    MySqlCommand orderListComm = new MySqlCommand(orderListQuery, conn);
        //    conn.Open();
        //    orderListComm.Parameters.AddWithValue("@prodname", name);
        //    MySqlDataReader orderListReader = orderListComm.ExecuteReader();

        //    if (orderListReader.Read())
        //    {
        //        double price = double.Parse(orderListReader.GetString(0).ToString());
        //        conn.Close();
        //        return price.ToString("0.00");
        //    }
        //    orderListReader.Close();
        //    conn.Close();

        //    return null;
        //}

    }
}
