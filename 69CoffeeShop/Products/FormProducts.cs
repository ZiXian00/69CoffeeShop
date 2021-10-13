using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _69CoffeeShop.Products
{
    public partial class FormProducts : Form
    {
        Class.Connection connection = new Class.Connection();

        public FormProducts()
        {
            InitializeComponent();
        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            FormAddProducts frmAdd = new FormAddProducts(this);
            frmAdd.ShowDialog();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            refreshProductList();
        }

        public void refreshProductList()
        {
            this.dataGridViewProduct.Rows.Clear();

            string displayProdQry = "select * from products";
            MySqlCommand displayProdCmd = new MySqlCommand(displayProdQry, connection.conn);
            connection.conn.Open();
            MySqlDataReader displayProdRdr = displayProdCmd.ExecuteReader();

            while (displayProdRdr.Read())
            {
                byte[] prodImg = (byte[])displayProdRdr["productImage"];
                //MemoryStream ms = new MemoryStream(prodImg);

                using (MemoryStream ms = new MemoryStream(prodImg, 0, prodImg.Length))
                {
                    using (Image img = Image.FromStream(ms))
                    {
                        int height = 60;
                        int width = 60;

                        using (Bitmap bm = new Bitmap(img, new Size(width, height)))
                        {
                            using (MemoryStream ms2 = new MemoryStream())
                            {
                                bm.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
                                prodImg = ms2.ToArray();
                            }
                        }
                    }
                }

                MemoryStream risizedImage = new MemoryStream(prodImg);

                string prodCost = String.Format("{0:0.00}", displayProdRdr.GetDouble(3));
                string prodPrice = String.Format("{0:0.00}", displayProdRdr.GetDouble(2));

                this.dataGridViewProduct.Rows.Add(Image.FromStream(risizedImage), displayProdRdr["productName"].ToString(), prodCost, prodPrice, "View Details");
            }
            displayProdRdr.Close();
            connection.conn.Close();
        }
    }
}
