using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PharManager_v0._01.TabContainer
{
    public partial class SalesTab : UserControl
    {
        public static int user_ID { get; set; } = 15;
        static int drug_ID { get; set; }
        public SalesTab()
        {
            InitializeComponent();
            refreshReg();

        }
        public void refreshReg()
        {
            OleDbConnection con = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;");
            try
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Drug_Storage", con);
                OleDbDataAdapter da2 = new OleDbDataAdapter("select * from Order_history", con);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();

                da.Fill(dt);
                dataGridView1.DataSource = dt;

                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            Main_Window_Form m = new Main_Window_Form();
            if (m.WindowState == FormWindowState.Maximized)
            {
                m.WindowState = FormWindowState.Minimized;
            }
            else if (m.WindowState == FormWindowState.Minimized)
            {
                m.WindowState = FormWindowState.Maximized;
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;"))
            {
                using (OleDbCommand cmd = new OleDbCommand("select Drug_Quantity from Drug_Storage where Drug_ID = @Drug", con))
                {
                    cmd.Parameters.AddWithValue("@drugid", drug_ID);
                    con.Open();
                    int quantity = (int)cmd.ExecuteScalar();

                    if (quantity == 0)
                    {
                        MessageBox.Show("ئەم دەرمانە تەواو بووە لە کۆگاکە");
                    }
                    else
                    {
                        using (OleDbCommand cmd2 = new OleDbCommand("Insert into Order_history (User_ID,Drug_ID,Order_Date) Values (@userid,@drugid,@date)", con))
                        {

                            cmd2.Parameters.AddWithValue("@userid", user_ID);
                            cmd2.Parameters.AddWithValue("@drugid", drug_ID);
                            cmd2.Parameters.AddWithValue("@date", DateTime.Now.Date);
                            con.Open();


                            cmd2.ExecuteNonQuery();
                            con.Close();
                        }
                        using (OleDbCommand cmd3 = new OleDbCommand("Update Drug_Storage Set Drug_Quantity = Drug_Quantity - 1 where Drug_ID = @did ", con))
                        {
                            cmd3.Parameters.AddWithValue("@did", drug_ID);
                            con.Open();
                            cmd3.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    dataGridView1.Refresh();
                    dataGridView2.Refresh();

                }
            }

        }

        private void barbox_TextChanged(object sender, EventArgs e)
        {

            using (OleDbConnection con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;"))
            {
                using (OleDbCommand cmd = new OleDbCommand("Select Drug_ID,Drug_name,Drug_Barcode,Drug_Selling_Price From Drug_Storage", con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    int bcodeholder;
                    while (reader.Read())
                    {
                        if (barbox.Text == string.Empty)
                        {
                            nbox.Text = string.Empty;
                            barbox.Text = string.Empty;
                            pbox.Text = string.Empty;
                        }
                        else if (barbox.Text == reader["Drug_Barcode"].ToString())
                        {
                            bcodeholder = (int)reader["Drug_Barcode"];
                            nbox.Text = reader["Drug_name"].ToString();
                            pbox.Text = reader["Drug_Selling_Price"].ToString();
                            int drug_id = (int)reader["Drug_ID"];
                            drug_ID = drug_id;
                            sbtn_Click(sender, e);
                        }
                    }



                }
            }

        }
    }
}
