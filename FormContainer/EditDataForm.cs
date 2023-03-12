using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PharManager_v0._01.FormContainer
{
    public partial class EditDataForm : Form
    {
        int idd;
        string dname;
        public EditDataForm(int id, string name)
        {
            InitializeComponent();
            this.idd = id;
            this.dname = name;
            nbox.Text = name;
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;"))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("Update Drug_Storage Set Drug_name = @name ,Drug_Selling_Price = @price ,Drug_Barcode = @bcode ,Drug_Purchase_Date = @pdate ,Drug_Expiry_Date = @edate where Drug_ID = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", idd);
                    cmd.Parameters.AddWithValue("@name", nbox.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(sellbox.Text));
                    cmd.Parameters.AddWithValue("@bcode", Convert.ToInt32(bbox.Text));
                    cmd.Parameters.AddWithValue("@pdate", purchasedate.Value);
                    cmd.Parameters.AddWithValue("@edate", expirydate.Value);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }
            }
        }
    }
}
