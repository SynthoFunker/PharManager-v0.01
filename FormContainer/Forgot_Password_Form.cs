using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;
using PharManager_v0._01.FormContainer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PharManager_v0._01
{
    public partial class Forgot_Password_Form : Form
    {
        private OleDbConnection con = new OleDbConnection();
        int attempt = 0;
        string OTPcode;
        public static string to;
        DateTime today { get; set; } = DateTime.Now;

        public Forgot_Password_Form()
        {
            InitializeComponent();
            con.ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.ShowDialog();
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
           
            if (EBox.Text != "")
            {
                    con.Open();
                OleDbCommand cmd = new OleDbCommand("select * from Users where Email = @Email",con);
                cmd.Parameters.AddWithValue("@Email",EBox.Text);
                   
                    cmd.Connection = con;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                DateTime lastOpened = today; // Get the last opened date from a variable or file
                DateTime now = DateTime.Now;
                TimeSpan timeSinceLastOpened = now.Subtract(lastOpened);

                while (reader.Read())
                    {
                         count = count + 1;
                    }
                    con.Close();
             
                 if (count == 1)
                 {
                    string from, pass, messagebody;
                    Random rand = new Random();
                    OTPcode = (rand.Next(99999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (EBox.Text).ToString();
                    from = "pharmanager0@gmail.com";
                    pass = "ktblbhtvrtgmwine";

                    messagebody = "Your Reset OTP code is " + OTPcode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messagebody;
                    message.Subject = "OTP Password Reseting Code";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.UseDefaultCredentials = true;
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    attempt += 1;

                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code have been Sent Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                 }
                else if (count > 1)
                { MessageBox.Show("intreresting Error.."); }
                else if (attempt == 3 && timeSinceLastOpened.TotalDays < 1)
                {
                   
                    MessageBox.Show("you've exeeded the limit");
                    LoginForm l = new LoginForm();
                    this.Hide();
                    l.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This Email Isn't Registered" + attempt);
                    attempt += 1;
                }
            }
            
            
            else
            {
                MessageBox.Show("Enter Your Email..");
            }

        }

        private void Vbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (OTPcode == (VBox.Text).ToString())
                {
                    to = EBox.Text;
                    MessageBox.Show("Verification Completed.");
                    this.Hide();

                    ChangePassword_Form cp = new ChangePassword_Form(EBox.Text);
                    cp.ShowDialog();
                }
                else if (VBox.Text == "")
                { MessageBox.Show("You haven't entered anything yet..."); }    
                else if (OTPcode != EBox.Text)
                {
                    MessageBox.Show("The given code is not correct");
                    attempt += 1;
                }
                else
                {
                    MessageBox.Show("something is wrong");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
           
        
        }

        private void Forgot_Password_Form_Load(object sender, EventArgs e)
        {
           
          
        }
    } 
}
