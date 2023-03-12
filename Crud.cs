using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PharManager_v0._01
{
    internal class Crud
    {
        private static string GetConnectionString()
        {
            string cons = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;";
            return cons;
        }

        public static OleDbConnection con = new OleDbConnection(GetConnectionString());
        public static OleDbCommand cmd = default(OleDbCommand);
        public static string sql = string.Empty;

        public static DataTable CRUDoperation(OleDbCommand cmd)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                da.SelectCommand= cmd;
                da.Fill(dt);
                return dt;
            }
            catch (System.Exception ex)
            {

                MessageBox.Show($"Error {ex}");
                dt = null;
            }
            return dt;
        }
    }
}
