using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PharManager_v0._01.TabContainer
{
    public partial class SalesTab : UserControl
    {
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
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }

        private void refresher_Tick(object sender, EventArgs e)
        {

        }
    }
}
