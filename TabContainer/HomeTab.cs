using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace PharManager_v0._01.TabContainer
{
    public partial class HomeTab : UserControl
    {
        public HomeTab()
        {
            InitializeComponent();
        }

        private string id = string.Empty;



        private void HomeTab_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;"))
            {
                using (OleDbDataAdapter sda = new OleDbDataAdapter("SELECT Drug_name, Drug_Barcode, Drug_Expiry_Date FROM Drug_Storage WHERE (((Drug_Expiry_Date)>=Date()-365 And (Drug_Expiry_Date)<Date()+7)) ORDER BY Drug_Expiry_Date ASC;", con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Update();
                        dataGridView1.Refresh();
                        dataGridView1.BackgroundColor = Color.White;
                    }
                }
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Drug_Storage order by Drug_Quantity desc", con))
                {
                    con.Open();
                    OleDbDataReader re = cmd.ExecuteReader();
                    while (re.Read())
                    {
                        QuantityChart.Series["Quantity"].Points.AddXY(re["Drug_name"].ToString(), re["Drug_Quantity"].ToString());
                    }
                    con.Close();
                }
                using (OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Drug_Storage order by Drug_Quantity desc", con))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    for (int i = 0; i < QuantityChart.Series["Quantity"].Points.Count; i++)
                    {
                        int quantity = (int)dt.Rows[i]["Drug_Quantity"];
                        Color color = Color.Green;
                        if (quantity <= 3)
                        {
                            color = Color.Red;
                        }
                        else if (quantity <= 5)
                        {
                            color = Color.Orange;
                        }
                        else if (quantity <= 10)
                        {
                            color = Color.Yellow;
                        }
                        QuantityChart.Series["Quantity"].Points[i].Color = color;
                    }
            con.Close();
                }
            }
        }
        private void CheckMedicineAmounts(DataTable dt)
        {

            foreach (DataRow row in dt.Rows)
            {
                int amount = (int)row["Drug_Quantity"];
                if (amount < 25)
                {
                    string message = $"{row["Drug_name"]} has a low amount of {amount} units.";
                    MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            using (OleDbConnection Con = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;"))
            {
                using (OleDbCommand cmd = new OleDbCommand("Select Drug_name, Drug_Barcode, Drug_Expiry_Date from Drug_Storage"))
                using (OleDbDataAdapter ad = new OleDbDataAdapter(cmd))
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        DateTime expd = Convert.ToDateTime(row.Cells["Drug_Expiry_Date"].Value);
                        if (expd <= DateTime.Today) { row.DefaultCellStyle.BackColor = Color.Red; }
                        else if (expd <= DateTime.Today.AddDays(3)) { row.DefaultCellStyle.BackColor = Color.Orange; }
                        else if (expd <= DateTime.Today.AddDays(7)) { row.DefaultCellStyle.BackColor = Color.Yellow; }
                        else { row.DefaultCellStyle.BackColor = Color.Green; }
                    }
                }
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


    }
}


