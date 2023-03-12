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
        private int row = 0;
        private void LoadData(string keyword)
        {
            Crud.sql = "select * from Drug_Storage";

            string strkeyword = string.Format("%{0}%", Crud.con);

            Crud.cmd = new OleDbCommand(Crud.sql, Crud.con);

            Crud.cmd.Parameters.Clear();
            Crud.cmd.Parameters.AddWithValue("Keyword1", strkeyword);
            Crud.cmd.Parameters.AddWithValue("Keyword2", keyword);

            DataTable dt = Crud.CRUDoperation(Crud.cmd);

            if (dt.Rows.Count > 0)
            {
                row = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                row = 0;
            }
        }
        private void execute(string mysql, string param)
        {
            Crud.cmd = new OleDbCommand(mysql, Crud.con);
            AddParameters(param);
            Crud.CRUDoperation(Crud.cmd);
        }
        private void AddParameters(string str)
        {
            Crud.cmd.Parameters.Clear();
            if (str == "Delete")
            {

            }
        }


        private void HomeTab_Load(object sender, EventArgs e)
        {
            Crud.sql = "SELECT Drug_name, Drug_Barcode, Drug_Expiry_Date FROM Drug_Storage WHERE (((Drug_Expiry_Date)>=Date()-365 And (Drug_Expiry_Date)<=Date()+7)) ORDER BY Drug_Expiry_Date ASC;";
            Crud.cmd = new OleDbCommand(Crud.sql,Crud.con);   
            dataGridView1.DataSource = Crud.CRUDoperation(Crud.cmd);
            dataGridView1.BackgroundColor = Color.White;

            Crud.sql = "SELECT * FROM Drug_Storage order by Drug_Quantity desc";
            Crud.cmd = new OleDbCommand(Crud.sql, Crud.con);
            Crud.con.Open();
            OleDbDataReader re = Crud.cmd.ExecuteReader();
            while (re.Read())
            {
                QuantityChart.Series["Quantity"].Points.AddXY(re["Drug_name"].ToString(), re["Drug_Quantity"].ToString());
                if ((int)re["Drug_Quantity"] < 5)
                {
                    QuantityChart.Series["Quantity"].Points[0].Color = Color.Red;
                }
                else
                {
                    QuantityChart.Series["Quantity"].Points[0].Color = Color.Black;
                }
            }
            Crud.con.Close();
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
                    DateTime expd = new DateTime();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        expd = Convert.ToDateTime(row.Cells["Drug_Expiry_Date"].Value);
                        if (expd < DateTime.Today) { row.DefaultCellStyle.BackColor = Color.Red; }
                        else if (expd < DateTime.Today.AddDays(3)) { row.DefaultCellStyle.BackColor = Color.Orange; }
                        else if (expd < DateTime.Today.AddDays(7)) { row.DefaultCellStyle.BackColor = Color.Yellow; }
                        else { row.DefaultCellStyle.BackColor = Color.Green; }
                    }
                }
            }
        }
    }
}


