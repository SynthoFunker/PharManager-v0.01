using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PharManager_v0._01.FormContainer
{
    public partial class ChangePassword_Form : Form
    {
        readonly string Email = Forgot_Password_Form.to;
        public string EmailT { get; private set; }

        public ChangePassword_Form(string Email)
        {
            InitializeComponent();
                EmailT = Email;
        }

        private void Cobtn_Click(object sender, EventArgs e)
        {
            if(PassBox.Text == CPassBox.Text )
            {
                OleDbConnection con = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;");
                OleDbCommand cmd = new OleDbCommand("Update Users set [Password]=@Password where [Email] = @Email", con);
                cmd.Parameters.AddWithValue("@Password",CPassBox.Text);
                cmd.Parameters.AddWithValue("@Email", EmailT);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Have Been Resetted");
                this.Hide();
                Main_Window_Form m = new Main_Window_Form(this);
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }

        private void ChangePassword_Form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
