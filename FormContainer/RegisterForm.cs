using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PharManager_v0._01
{
    public partial class RegisterForm : Form
    {
        public string UName { get; private set; }

        private OleDbConnection con = new OleDbConnection();
        public RegisterForm()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Han\Desktop\EPU files\Research\Pharmacy Database.accdb;Persist Security Info=False;";
        }



        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.ShowDialog();
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            if (Ubox.Text == "" && PassBox.Text == "" && CPassBox.Text == "")
            {
                MessageBox.Show("Please type a username & password");
            }

            else if (PassBox.Text != CPassBox.Text)
            {
                MessageBox.Show("Passwords Doesn't Match");
            }
            else if (PassBox.Text == CPassBox.Text)
            {
                try
                {

                    con.Open();
                    OleDbCommand command = new OleDbCommand("insert into Users ([FirstName],[LastName],[Username],[Email],[Password]) values (@FirstName,@LastName,@Username,@Email,@Password)", con);
                    command.Parameters.AddWithValue("@FirstName", FBox.Text);
                    command.Parameters.AddWithValue("@LastName", LBox.Text);
                    command.Parameters.AddWithValue("@Username", Ubox.Text);
                    command.Parameters.AddWithValue("@Email", EBox.Text);
                    command.Parameters.AddWithValue("@Password", PassBox.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("You Have Been Registered");
                    UName = Ubox.Text;
                    con.Close();
                    con.Dispose();
                    this.Hide();
                    Main_Window_Form f2_ = new Main_Window_Form(this);
                    f2_.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }


        }

        private void in_timer_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
            if (Opacity == 1)
            {
                in_timer.Stop();
            }
        }
    }
}
