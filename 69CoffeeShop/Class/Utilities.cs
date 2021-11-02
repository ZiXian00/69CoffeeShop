using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Security.AccessControl;
using System.Security.Cryptography;

namespace _69CoffeeShop.Class
{   
    public class Utilities
    {
        static Connection connection = new Connection();

        public static string encryption (string plainText)
        {
            string shannieKey = "28a18a5bc96caeeb414ab393542111e3";

            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(shannieKey);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string decryption (string cipherText)
        {
            string shannieKey = "28a18a5bc96caeeb414ab393542111e3";

            if (cipherText != null)
            {
                byte[] iv = new byte[16];
                byte[] buffer = Convert.FromBase64String(cipherText);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(shannieKey);
                    aes.IV = iv;
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream(buffer))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                            {
                                return streamReader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            else
            {
                return cipherText;
            }
        }

        public static void backup(Label label)
        {            
            string backupDirectory = @"C:\ProgramData\69coffeeshopBackup";

            if (!Directory.Exists(backupDirectory))
            {
                Directory.CreateDirectory(backupDirectory);
            }

            DateTime backupDateTime = DateTime.Now;

            string updateBackupRecordQry = "insert into backup_record (backup_datetime) values (@backup)";
            MySqlCommand updateBackupRecordCmd = new MySqlCommand(updateBackupRecordQry, connection.conn);
            connection.conn.Open();
            updateBackupRecordCmd.Parameters.AddWithValue("@backup", encryption(backupDateTime.ToString()));
            updateBackupRecordCmd.ExecuteNonQuery();
            connection.conn.Close();

            string backupPath = backupDirectory+ "\\69coffeeshop.sql";

            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(backupPath);
                        conn.Close();
                    }
                }
            }

            label.Text = "Last Backup : " + backupDateTime.ToString("dd MMM yyyy HH:mm");
            MessageBox.Show("Backup complete.", "Data and Information Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void restore()
        {
            string backupDirectory = @"C:\ProgramData\69coffeeshopBackup";

            string backupPath = backupDirectory + "\\69coffeeshop.sql";
           
            using (MySqlConnection conn = new MySqlConnection(Connection.connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(backupPath);
                        conn.Close();
                    }
                }
            }

            DateTime restoreDateTime = DateTime.Now;
            
            string updateBackupRecordQry = "update backup_record set restore_datetime = @restore ORDER BY backup_id DESC LIMIT 1";
            MySqlCommand updateBackupRecordCmd = new MySqlCommand(updateBackupRecordQry, connection.conn);
            connection.conn.Open();
            updateBackupRecordCmd.Parameters.AddWithValue("@restore", encryption(restoreDateTime.ToString()));
            updateBackupRecordCmd.ExecuteNonQuery();
            connection.conn.Close();

            MessageBox.Show("Restored all data and information from latest backup", "Data and Information Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void resetControl(Control form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Text = null;
                }

                if (ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = -1;
                }

                if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    checkBox.Checked = false;
                }

                if (ctrl is ListBox)
                {
                    ListBox listBox = (ListBox)ctrl;
                    listBox.ClearSelected();
                }

                if(ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctrl;
                    radioButton.Checked = false;
                }

                if(ctrl is RichTextBox)
                {
                    RichTextBox richTextBox = (RichTextBox)ctrl;
                    richTextBox.Text = null;
                }

                if(ctrl is MaskedTextBox)
                {
                    MaskedTextBox maskedTextBox = (MaskedTextBox)ctrl;
                    maskedTextBox.Text = "";
                }

                if(ctrl is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)ctrl;
                    foreach(Control ctrls in groupBox.Controls)
                    {
                        if (ctrls is TextBox)
                        {
                            TextBox textBox = (TextBox)ctrls;
                            textBox.Text = null;
                        }

                        if (ctrls is ComboBox)
                        {
                            ComboBox comboBox = (ComboBox)ctrls;
                            if (comboBox.Items.Count > 0)
                                comboBox.SelectedIndex = -1;
                        }

                        if (ctrls is CheckBox)
                        {
                            CheckBox checkBox = (CheckBox)ctrls;
                            checkBox.Checked = false;
                        }

                        if (ctrls is ListBox)
                        {
                            ListBox listBox = (ListBox)ctrls;
                            listBox.ClearSelected();
                        }

                        if (ctrls is RadioButton)
                        {
                            RadioButton radioButton = (RadioButton)ctrls;
                            radioButton.Checked = false;
                        }

                        if (ctrls is RichTextBox)
                        {
                            RichTextBox richTextBox = (RichTextBox)ctrls;
                            richTextBox.Text = null;
                        }

                        if (ctrls is MaskedTextBox)
                        {
                            MaskedTextBox maskedTextBox = (MaskedTextBox)ctrls;
                            maskedTextBox.Text = "";
                        }
                    }
                }
            }
        }

        public static void resetControlWithoutDropdown(Control form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Text = null;
                }

                if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    checkBox.Checked = false;
                }

                if (ctrl is ListBox)
                {
                    ListBox listBox = (ListBox)ctrl;
                    listBox.ClearSelected();
                }

                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctrl;
                    radioButton.Checked = false;
                }

                if (ctrl is RichTextBox)
                {
                    RichTextBox richTextBox = (RichTextBox)ctrl;
                    richTextBox.Text = null;
                }

                if (ctrl is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)ctrl;
                    foreach (Control ctrls in groupBox.Controls)
                    {
                        if (ctrls is TextBox)
                        {
                            TextBox textBox = (TextBox)ctrls;
                            textBox.Text = null;
                        }

                        if (ctrls is CheckBox)
                        {
                            CheckBox checkBox = (CheckBox)ctrls;
                            checkBox.Checked = false;
                        }

                        if (ctrls is ListBox)
                        {
                            ListBox listBox = (ListBox)ctrls;
                            listBox.ClearSelected();
                        }

                        if (ctrls is RadioButton)
                        {
                            RadioButton radioButton = (RadioButton)ctrls;
                            radioButton.Checked = false;
                        }

                        if (ctrls is RichTextBox)
                        {
                            RichTextBox richTextBox = (RichTextBox)ctrls;
                            richTextBox.Text = null;
                        }
                    }
                }
            }
        }
    }
}
