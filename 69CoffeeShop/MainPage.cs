using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace _69CoffeeShop
{
    public partial class MainPage : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        Class.Connection connection = new Class.Connection();
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        //constructor
        public MainPage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 49);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //struct
        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(169, 103, 78);
        }

        //method 
        public void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(169, 103, 78);
                currentBtn.ForeColor = Color.FromArgb(250, 240, 210);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(250, 240, 210);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Color.FromArgb(0, 0, 0);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon current form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(250, 240, 210);
                currentBtn.ForeColor = Color.FromArgb(169, 103, 78);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(169, 103, 78);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open new close previous
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            if(Class.Cashier.cashierLogin == true)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new Forms.FormSales(this));
            }
            else
            {
                MessageBox.Show("Please login before continue. ", "No login action detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Employees.FormEmployeeLogin empLogin = new Employees.FormEmployeeLogin();
                empLogin.ShowDialog(this);
            }
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            if (Class.Cashier.cashierLogin == true)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new Forms.FormMembership());
            }
            else
            {
                MessageBox.Show("Please login before continue. ", "No login action detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Employees.FormEmployeeLogin empLogin = new Employees.FormEmployeeLogin();
                empLogin.ShowDialog(this);
            }
        }

        private void btnInventories_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormInventories());
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormSuppliers());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormEmployees());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormReports());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form admLogin = new Forms.FormAdminLogin();
            
            var results = admLogin.ShowDialog();
            if (results == DialogResult.OK)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new Forms.FormAdmin());
            }            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            lblTitleChildForm.Text = "Home";
        }

        //for drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(Class.Cashier.cashierLogin == true)
            {
                DialogResult ds = MessageBox.Show("Confirm check out?", "Check out confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ds == DialogResult.Yes)
                {
                    MessageBox.Show("Goodbye, " + Class.Cashier.cashierName);

                    string checkDutyRecordQry = "select * from employees where employeeID = @id";
                    DateTime checkInDT = new DateTime();
                    MySqlCommand checkDutyRecordCmd = new MySqlCommand(checkDutyRecordQry, connection.conn);
                    checkDutyRecordCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(Class.Cashier.cashierID));
                    connection.conn.Open();
                    MySqlDataReader checkDutyRecordRdr = checkDutyRecordCmd.ExecuteReader();
                    try
                    {
                        if (checkDutyRecordRdr.Read())
                        {
                            checkInDT = DateTime.ParseExact(Class.Utilities.decryption(checkDutyRecordRdr.GetString(16)), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    finally
                    {
                        checkDutyRecordRdr.Close();
                        connection.conn.Close();

                        updateDutyRecord(checkInDT, Class.Cashier.cashierID);

                        Class.Cashier.cashierID = null;
                        Class.Cashier.cashierName = null;
                        Class.Cashier.cashierLogin = false;

                        Class.Utilities.backup();
                        iconButtonClockInOut.Text = "Check In";

                        Application.Exit();
                    }
                }
            }
            else
            {
                Class.Utilities.backup();
                Application.Exit();
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            string getPayroll_IDQry = "select payroll_id, date from payroll_record where status = @status";
            MySqlCommand getPayroll_IDCmd = new MySqlCommand(getPayroll_IDQry, connection.conn);
            connection.conn.Open();
            getPayroll_IDCmd.Parameters.AddWithValue("@status", Class.Utilities.encryption("Pending"));
            MySqlDataReader getPayroll_IDRdr = getPayroll_IDCmd.ExecuteReader();
            List<string> payroll_id = new List<string>();
            List<string> payroll_date = new List<string>();
            if (getPayroll_IDRdr.HasRows)
            {
               

                while (getPayroll_IDRdr.Read())
                {
                    payroll_id.Add(getPayroll_IDRdr.GetInt32(0).ToString());
                    payroll_date.Add(Class.Utilities.decryption(getPayroll_IDRdr.GetString(1)));
                }
            }

            getPayroll_IDRdr.Close();
            connection.conn.Close();

            for(int i = 0; i < payroll_date.Count; i++)
            {
                int workingDaysCount = 0;
                DateTime _payrollDate = DateTime.ParseExact(payroll_date[i], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DateTime today = DateTime.Now.AddDays(-1);

                while(_payrollDate <= today)
                {
                    if(!(_payrollDate.DayOfWeek == DayOfWeek.Sunday || _payrollDate.DayOfWeek == DayOfWeek.Saturday))
                    {
                        workingDaysCount++;
                    }
                    _payrollDate = _payrollDate.AddDays(1);
                }

                if (workingDaysCount > 3)
                {
                    string updatePayrollStatusQry = "update payroll_record set status = @status where payroll_id = @id";
                    MySqlCommand updatePayrollStatusCmd = new MySqlCommand(updatePayrollStatusQry, connection.conn);
                    connection.conn.Open();
                    updatePayrollStatusCmd.Parameters.AddWithValue("@status", Class.Utilities.encryption("Complete"));
                    updatePayrollStatusCmd.Parameters.AddWithValue("@id", payroll_id[i]);
                    updatePayrollStatusCmd.ExecuteNonQuery();
                    connection.conn.Close();
                }
            }

            /*  load existing Inventory  */
            LoadExistingInventory();

            
        }

        private void LoadExistingInventory()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            List<string> inventory = new List<string>();
            string inventoryQuery = "Select * FROM inventory";
            MySqlCommand cmdInventory = new MySqlCommand(inventoryQuery, conn);
            MySqlDataReader dr = cmdInventory.ExecuteReader();


            while (dr.Read())
            {

                if(Convert.ToInt32(Class.Utilities.decryption(dr["quantity"].ToString())) <= 10)
                {
                    inventory.Add(Class.Utilities.decryption(dr["inventoryID"].ToString()) + " left only " + Class.Utilities.decryption(dr["quantity"].ToString()));
                }
                
            }

            string toDisplay = string.Join("\n", inventory);
            if(inventory.Count != 0)
            {
                MessageBox.Show(toDisplay, "Inventory Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void iconButtonClockInOut_Click(object sender, EventArgs e)
        {
            if (iconButtonClockInOut.Text.ToUpper() == "CHECK IN")
            {
                Employees.FormEmployeeLogin empLogin = new Employees.FormEmployeeLogin();
                empLogin.ShowDialog(this);
            }
            else if(iconButtonClockInOut.Text.ToUpper() == "CHECK OUT")
            {
                DialogResult ds = MessageBox.Show("Confirm check out?", "Check out confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ds == DialogResult.Yes)
                {
                    MessageBox.Show("Goodbye, " + Class.Cashier.cashierName);

                    string checkDutyRecordQry = "select * from employees where employeeID = @id";
                    DateTime checkInDT = new DateTime();
                    MySqlCommand checkDutyRecordCmd = new MySqlCommand(checkDutyRecordQry, connection.conn);
                    checkDutyRecordCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(Class.Cashier.cashierID));
                    connection.conn.Open();
                    MySqlDataReader checkDutyRecordRdr = checkDutyRecordCmd.ExecuteReader();
                    try 
                    {
                        if (checkDutyRecordRdr.Read())
                        {
                            checkInDT = DateTime.ParseExact(Class.Utilities.decryption(checkDutyRecordRdr.GetString(16)), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);                                                                               
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    finally
                    {
                        checkDutyRecordRdr.Close();
                        connection.conn.Close();

                        updateDutyRecord(checkInDT, Class.Cashier.cashierID);

                        Class.Cashier.cashierID = null;
                        Class.Cashier.cashierName = null;
                        Class.Cashier.cashierLogin = false;

                        if (currentChildForm != null)
                        {
                            currentChildForm.Close();
                        }

                        iconButtonClockInOut.Text = "Check In";
                    }
                }
            }
        }

        private void updateDutyRecord(DateTime checkIn, string id)
        {
            DateTime checkOut =  DateTime.Now;

            TimeSpan span = checkOut.Subtract(checkIn);

            double workingHours = span.TotalHours;

            try
            {
                string checkOutQry = "update employees set lastCheckedOut = @checkOut where employeeID = @id";
                MySqlCommand checkOutCmd = new MySqlCommand(checkOutQry, connection.conn);
                checkOutCmd.Parameters.AddWithValue("@checkOut", Class.Utilities.encryption(checkOut.ToString("yyyy-MM-dd HH:mm:ss")));
                checkOutCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(id));
                connection.conn.Open();
                checkOutCmd.ExecuteNonQuery();

                string updateDutyRecordQry = "insert into employee_duty_record (month, year, employeeID, workingHours) values (@month, @year, @id, @hours)";
                MySqlCommand updateDutyRecordCmd = new MySqlCommand(updateDutyRecordQry, connection.conn);
                updateDutyRecordCmd.Parameters.AddWithValue("@month", Class.Utilities.encryption(DateTime.Now.ToString("MMM")));
                updateDutyRecordCmd.Parameters.AddWithValue("@year", Class.Utilities.encryption(DateTime.Now.ToString("yyyy")));                
                updateDutyRecordCmd.Parameters.AddWithValue("@id", Class.Utilities.encryption(id));
                updateDutyRecordCmd.Parameters.AddWithValue("@hours", Class.Utilities.encryption(workingHours.ToString("0")));
                updateDutyRecordCmd.ExecuteNonQuery(); 
                
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

        public void changeClockStatus()
        {
            if (this.iconButtonClockInOut.Text.ToUpper() == "CHECK IN")
            {
                this.iconButtonClockInOut.Text = "Check Out";
            }
            else if(this.iconButtonClockInOut.Text.ToUpper() == "CHECK OUT")
            {
                this.iconButtonClockInOut.Text = "Check In";
            }
        }
    }
}
