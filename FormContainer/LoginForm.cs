using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace PharManager_v0._01
{
    public partial class LoginForm : Form
    {
        public string userName { get; private set; }
        private OleDbConnection con = new OleDbConnection();
        public LoginForm()
        {
            InitializeComponent();
            con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Why are you clicking here....??");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You ain't gonna be getting any passwords by clicking here...");
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm f = new RegisterForm();
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            con.Open();
            OleDbCommand command = new OleDbCommand("Select * from Users where Username = @username or Email = @email and Password = @password", con);
            command.Connection = con;
            command.Parameters.AddWithValue("@username", EorUBox.Text);
            command.Parameters.AddWithValue("@Email", EorUBox.Text);
            command.Parameters.AddWithValue("@password", passBox.Text);
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;

            while (reader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                userName = EorUBox.Text;
                con.Close();
                con.Dispose();
                this.Hide();
                Main_Window_Form f2 = new Main_Window_Form(this);
                f2.ShowDialog();
            }
            else if (count > 1)
            { MessageBox.Show("Duplicate Username & Password"); }
            else
            { MessageBox.Show("Username & Password is invalid " + count); }

            con.Close();
        }

        private void fpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot_Password_Form f = new Forgot_Password_Form();
            f.ShowDialog();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
