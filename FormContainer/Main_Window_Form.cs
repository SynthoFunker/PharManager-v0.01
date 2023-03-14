using PharManager_v0._01.FormContainer;
using PharManager_v0._01.TabContainer;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace PharManager_v0._01
{
    public partial class Main_Window_Form : Form
    {
        private readonly OleDbConnection con = new OleDbConnection();
        private readonly LoginForm _f1;
        private readonly RegisterForm _f2;
        private readonly ChangePassword_Form _f3;

        #region Constructors

        public Main_Window_Form()
        {
            InitializeComponent();
            HomeTab op = new HomeTab();
            AddUserControl(op);
        }

        public Main_Window_Form(LoginForm f1_)
        {
            InitializeComponent();
            this._f1 = f1_;
            con.ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;";
            HomeTab op = new HomeTab();
            AddUserControl(op);
        }

        public Main_Window_Form(RegisterForm f2_)
        {
            InitializeComponent();
            this._f2 = f2_;
            con.ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;";
        }

        public Main_Window_Form(ChangePassword_Form f3_)
        {
            InitializeComponent();
            this._f3 = f3_;
            con.ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;";
        }

        #endregion Constructors

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Tabcon.Controls.Clear();
            Tabcon.Controls.Add(userControl);
            userControl.BringToFront();
        }

        #region Variables

        private bool IsCollapsed = false;

        #endregion Variables

        #region ButtonMethods

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minbtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Iconbtn_Click(object sender, EventArgs e)
        {
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            HomeTab op = new HomeTab();
            AddUserControl(op);
        }

        private void Medicinebtn_Click(object sender, EventArgs e)
        {
            MedicineTab op = new MedicineTab();
            AddUserControl(op);
        }

        private void Salesbtn_Click(object sender, EventArgs e)
        {
            SalesTab op = new SalesTab();

            AddUserControl(op);
        }

        private void Backupbtn_Click(object sender, EventArgs e)
        {
            BackupTab op = new BackupTab();
            AddUserControl(op);
        }

        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            SettingsTab op = new SettingsTab();
            AddUserControl(op);
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.ShowDialog();
        }

        #endregion ButtonMethods

        #region Events

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Main_Window_Form_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion Events

        private void Med_Name_Enter(object sender, EventArgs e)
        {
            if (Med_Name.Text == "Name")
            {
                Med_Name.Text = "";
                Med_Name.ForeColor = Color.Black;
            }
        }

        private void Med_Name_Leave(object sender, EventArgs e)
        {
            if (Med_Name.Text == "")
            {
                Med_Name.Text = "Name";
                Med_Name.ForeColor = Color.Silver;
            }
        }

        private void Med_Barcode_Enter(object sender, EventArgs e)
        {
            if (Med_Barcode.Text == "Barcode")
            {
                Med_Barcode.Text = "";
                Med_Barcode.ForeColor = Color.Black;
            }
        }

        private void Med_Barcode_Leave(object sender, EventArgs e)
        {
            if (Med_Barcode.Text == "")
            {
                Med_Barcode.Text = "Barcode";
                Med_Barcode.ForeColor = Color.Silver;
            }
        }


        private void Collapsing_MouseLeave(object sender, EventArgs e)
        {
            Point mpos = sidebar.PointToClient(Control.MousePosition);
            if (!sidebar.ClientRectangle.Contains(mpos))
            {
                sidebar.Width = 52;
                IsCollapsed = true;
                sidebar.Refresh();
            }
        }

        private void Buttons_Expanding_MouseHover(object sender, EventArgs e)
        {
            IsCollapsed = false;
            if (!IsCollapsed)
            {
                sidebar.Width = 130;                
                sidebar.Refresh();
            }
        }

        private void Expanding_MouseHover(object sender, EventArgs e)
        {
            sidebar.Width = 130;
            IsCollapsed = false;
            Buttons_Expanding_MouseHover(sender, e);
        }
    }
}