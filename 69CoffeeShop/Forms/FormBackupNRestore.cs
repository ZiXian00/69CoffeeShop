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
using System.IO;

namespace _69CoffeeShop.Forms
{
    public partial class FormBackupNRestore : Form
    {
        Class.Connection connection = new Class.Connection();

        public FormBackupNRestore()
        {
            InitializeComponent();
        }

        private void iconButtonBackup_Click(object sender, EventArgs e)
        {
            Class.Utilities.backup(labelLatestBackup);
        }

        private void iconButtonRestore_Click(object sender, EventArgs e)
        {
            Class.Utilities.restore();
        }

        private void FormBackupNRestore_Load(object sender, EventArgs e)
        {
            refreshDate();
        }

        public void refreshDate()
        {
            string getLastBackupQry = "select * from backup_record ORDER BY backup_id DESC LIMIT 1";
            MySqlCommand getLastBackupCmd = new MySqlCommand(getLastBackupQry, connection.conn);
            connection.conn.Open();
            MySqlDataReader getLastBackupRdr = getLastBackupCmd.ExecuteReader();

            if (getLastBackupRdr.Read())
            {
                string backupString = getLastBackupRdr.GetString(0);

                DateTime lastBackup = DateTime.Parse(backupString);

                string _lastBackup = lastBackup.ToString("dd MMM yyyy HH:mm");

                labelLatestBackup.Text = "Last Backup : " + _lastBackup;
            }
        }
    }
}
