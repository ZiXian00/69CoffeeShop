using MySql.Data.MySqlClient;
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

namespace _69CoffeeShop.Products
{
    public partial class FormAddProducts : Form
    {
        Class.Connection connection = new Class.Connection();

        public FormAddProducts()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*",
                Title = "Select Image"
            };

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK) {

                string fileName = openFileDialog.FileName;
                try
                {
                    //Bitmap bm = new Bitmap(fileName);
                    //Bitmap resizeImg = new Bitmap(bm, new Size(129, 129));
                    //pictureBoxProdImg.Image = resizeImg;
                    pictureBoxProdImg.Image = Image.FromFile(fileName);
                    pictureBoxProdImg.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string productID = createProductID();
            MemoryStream ms = new MemoryStream();
            pictureBoxProdImg.Image.Save(ms, pictureBoxProdImg.Image.RawFormat);
            byte[] img = ms.ToArray();

            string newProdQry = "insert into products values (@productID, @productName, @unitPrice, @unitCost, @img)";
            MySqlCommand newProdCmd = new MySqlCommand(newProdQry, connection.conn);
            connection.conn.Open();

            newProdCmd.Parameters.AddWithValue("@productID", productID);
            newProdCmd.Parameters.AddWithValue("@productName", textBoxProdName.Text.ToString());
            newProdCmd.Parameters.AddWithValue("@unitPrice", textBoxProdPrice.Text.ToString());
            newProdCmd.Parameters.AddWithValue("@unitCost", textBoxProdCost.Text.ToString());
            newProdCmd.Parameters.AddWithValue("@img", img);

            newProdCmd.ExecuteNonQuery();

            connection.conn.Close();
        }

        private string createProductID()
        {
            string productID = "";
            connection.conn.Open();
            string productIDQuery = "select productID from products ORDER BY productID DESC LIMIT 1";
            MySqlCommand productIDCmd = new MySqlCommand(productIDQuery, connection.conn);
            MySqlDataReader productIDRdr = productIDCmd.ExecuteReader();

            if (productIDRdr.Read())
            {
                string lastID = productIDRdr.GetString(0);
                lastID = lastID.Substring(1);
                int idIncrement = int.Parse(lastID);
                idIncrement++;

                productID = "C" + String.Format("{0:0000}", idIncrement);
            }
            else {
                productID = "C0001";
            }
            productIDRdr.Close();
            connection.conn.Close();
            return productID;
        }
    }
}
