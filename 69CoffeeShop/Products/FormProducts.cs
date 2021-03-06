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
        Class.Product product;
        public List<Class.Product> productList { get; set; } = new List<Class.Product>();
    
        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            refreshProductList();
        }

        public void refreshProductList()
        {
            this.dataGridViewProduct.Rows.Clear();
            productList.Clear();

            string displayProdQry = "select * from products";
            MySqlCommand displayProdCmd = new MySqlCommand(displayProdQry, connection.conn);
            connection.conn.Open();
            MySqlDataReader displayProdRdr = displayProdCmd.ExecuteReader();

            while (displayProdRdr.Read())
            {
                byte[] prodImg = (byte[])displayProdRdr["productImage"];

                product = new Class.Product(Class.Utilities.decryption(displayProdRdr.GetString(0)), Class.Utilities.decryption(displayProdRdr.GetString(1)), Class.Utilities.decryption(displayProdRdr.GetString(2)), Class.Utilities.decryption(displayProdRdr.GetString(3)), prodImg);
                productList.Add(product);

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

                //string prodCost = String.Format("{0:0.00}", displayProdRdr.GetDouble(3));
                //string prodPrice = String.Format("{0:0.00}", displayProdRdr.GetDouble(2));

                double prodCost = double.Parse(Class.Utilities.decryption(displayProdRdr.GetString(3)));
                double prodPrice = double.Parse(Class.Utilities.decryption(displayProdRdr.GetString(2)));

                this.dataGridViewProduct.Rows.Add(Image.FromStream(risizedImage), Class.Utilities.decryption(displayProdRdr["productName"].ToString()), prodCost.ToString("0.00"), prodPrice.ToString("0.00"), "Edit Details");
            }
            displayProdRdr.Close();
            connection.conn.Close();

            textBoxSearch.Text = "";
            // dataGridViewProduct.Rows[0].Cells[0].Selected = false;
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) {
                FormAddProducts formAddProducts = new FormAddProducts(this, e.RowIndex);
                formAddProducts.ShowDialog();
            }
        }

        public DataGridView GetDataGridView()
        {
            return dataGridViewProduct;
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count == 0 && dataGridViewProduct.SelectedCells.Count == 0)
            {
                dataGridViewProduct.Rows[0].Selected = true;
            }

            int rowIndex = dataGridViewProduct.SelectedCells[0].RowIndex;
            DialogResult ds = MessageBox.Show("Delete " + dataGridViewProduct.Rows[rowIndex].Cells[1].Value + "?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (ds == DialogResult.OK)
            {
                try
                {
                    string deleteProdQry = "delete from products where productID = @id";

                    MySqlCommand deleteProdCmd = new MySqlCommand(deleteProdQry, connection.conn);

                    deleteProdCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(productList[rowIndex].productID));

                    connection.conn.Open();

                    deleteProdCmd.ExecuteNonQuery();
                    productList.RemoveAt(rowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.conn.Close();
                    refreshProductList();
                }
            }
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddProducts frmAdd = new FormAddProducts(this, -1);
            frmAdd.ShowDialog();
        }

        private void dataGridViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            iconButtonDelete.Enabled = true;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != string.Empty)
            {
                foreach (DataGridViewRow row in dataGridViewProduct.Rows)
                {
                    if (row.Cells["prodName"].Value.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                        row.Visible = false;
                }
            }
            else
            {
                refreshProductList();
            }
        }

        private void dataGridViewProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAddProducts formAddProducts = new FormAddProducts(this, e.RowIndex);
            formAddProducts.ShowDialog();
        }
    }
}
