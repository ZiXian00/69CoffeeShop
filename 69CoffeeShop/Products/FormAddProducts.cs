using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69CoffeeShop.Products
{
    public partial class FormAddProducts : Form
    {
        Class.Connection connection = new Class.Connection();
        private FormProducts Products;
        private int rowIndex;

        public FormAddProducts(FormProducts formProducts, int rowIndex)
        {
            InitializeComponent();
            this.Products = formProducts;
            this.rowIndex = rowIndex;

            if (rowIndex >= 0)
            {
                DataGridView productGV = Products.GetDataGridView();

                MemoryStream ms = new MemoryStream(Products.productList[rowIndex].imageURL);

                pictureBoxProdImg.Image = Image.FromStream(ms);

                pictureBoxProdImg.SizeMode = PictureBoxSizeMode.StretchImage;

                textBoxProdName.Text = productGV.Rows[rowIndex].Cells["prodName"].Value.ToString();
                textBoxProdCost.Text = productGV.Rows[rowIndex].Cells["prodCost"].Value.ToString();
                textBoxProdPrice.Text = productGV.Rows[rowIndex].Cells["prodPrice"].Value.ToString();

                buttonSave.Text = "Update";
            }
            else
            {
                buttonSave.Text = "Save";
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",                
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*",
                Title = "Select Image",
                RestoreDirectory = true
            };

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK) {

                string fileName = openFileDialog.FileName;
                try
                {
                    pictureBoxProdImg.Image = Image.FromFile(fileName);
                    pictureBoxProdImg.SizeMode = PictureBoxSizeMode.StretchImage;
                    textBoxProdName.Select();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(priceValidation()))
                {
                    DialogResult ds = MessageBox.Show("Input price is not more than cost, proceed to continue? ", "Price Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (ds == DialogResult.OK)
                    {
                        updateTable();
                    }
                }
                else
                {
                    updateTable();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please input all required fields before continue !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Products.refreshProductList();
            }

        }

        private void updateTable() 
        {
            string productID = createProductID();
            MemoryStream ms = new MemoryStream();
            pictureBoxProdImg.Image.Save(ms, pictureBoxProdImg.Image.RawFormat);
            byte[] img = ms.ToArray();

            try
            {
                if(buttonSave.Text == "Save")
                {
                    string newProdQry = "insert into products (productID, productName, unitPrice, unitCost, productImage) values (@productID, @productName, @unitPrice, @unitCost, @img)";
                    MySqlCommand newProdCmd = new MySqlCommand(newProdQry, connection.conn);
                    connection.conn.Open();

                    newProdCmd.Parameters.AddWithValue("@productID", Class.Utilities.encryption(productID));
                    newProdCmd.Parameters.AddWithValue("@productName", Class.Utilities.encryption(textBoxProdName.Text.ToString()));
                    newProdCmd.Parameters.AddWithValue("@unitPrice", Class.Utilities.encryption(textBoxProdPrice.Text.ToString()));
                    newProdCmd.Parameters.AddWithValue("@unitCost", Class.Utilities.encryption(textBoxProdCost.Text.ToString()));
                    newProdCmd.Parameters.AddWithValue("@img", img);

                    newProdCmd.ExecuteNonQuery();

                    MessageBox.Show(textBoxProdName.Text.ToString() + " has added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pictureBoxProdImg.Image = null;
                    textBoxProdCost.Text = "";
                    textBoxProdName.Text = "";
                    textBoxProdPrice.Text = "";
                }
                else if(buttonSave.Text == "Update")
                {
                    string updateProdQry = "update products set productName = @prodName, unitPrice = @unitPrice, unitCost = @unitCost, productImage = @img where productID = @id";
                    MySqlCommand updateProdCmd = new MySqlCommand(updateProdQry, connection.conn);
                    connection.conn.Open();

                    updateProdCmd.Parameters.AddWithValue("@prodName", Class.Utilities.encryption(textBoxProdName.Text));
                    updateProdCmd.Parameters.AddWithValue("@unitPrice", Class.Utilities.encryption(textBoxProdPrice.Text));
                    updateProdCmd.Parameters.AddWithValue("@unitCost", Class.Utilities.encryption(textBoxProdCost.Text));
                    updateProdCmd.Parameters.AddWithValue("@img", img);
                    updateProdCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(Products.productList[rowIndex].productID));
                    updateProdCmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.conn.Close();
            }
           
        }

        private bool priceValidation()
        {
            double price = Double.Parse(textBoxProdPrice.Text.ToString());
            double cost = Double.Parse(textBoxProdCost.Text.ToString());

            if (price - cost > 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string createProductID()
        {
            string productID = "";
            connection.conn.Open();
            string productIDQuery = "select productID from products ORDER BY productCount DESC LIMIT 1";
            MySqlCommand productIDCmd = new MySqlCommand(productIDQuery, connection.conn);
            MySqlDataReader productIDRdr = productIDCmd.ExecuteReader();

            if (productIDRdr.Read())
            {
                string lastID = Class.Utilities.decryption(productIDRdr.GetString(0));
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

        private void textBoxProdCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string str = textBox.Text;

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

        private void textBoxProdCost_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text != "")
            {
                double _text = double.Parse(textBox.Text);
                textBox.Text = _text.ToString("0.00");
            }
        }

        private void FormAddProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
