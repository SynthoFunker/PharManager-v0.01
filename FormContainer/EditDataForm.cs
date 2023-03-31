using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PharManager_v0._01.FormContainer
{
    public partial class EditDataForm : Form
    {
        int idd;
        public EditDataForm(int id, string name, long barcode, int quantity, int sell, int purchase, DateTime purchaset, DateTime expiry)
        {
            InitializeComponent();
            this.idd = id;
            nbox.Text = name;
            sellbox.Text = sell.ToString();
            bbox.Text = barcode.ToString();
            qbox.Text = quantity.ToString();
            buybox.Text = purchase.ToString();

            purchasedate.Value = purchaset;
            expirydate.Value = expiry;
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
                using (OleDbCommand cmd = new OleDbCommand("Update Drug_Storage Set Drug_name = @name ,Drug_Selling_Price = @sprice ,Drug_Purchase_Price = @pprice ,Drug_Quantity = @quantity ,Drug_Barcode = @bcode ,Drug_Purchase_Date = @pdate ,Drug_Expiry_Date = @edate where Drug_ID = @id", con))
                {
                    cmd.Parameters.AddWithValue("@name", nbox.Text);
                    cmd.Parameters.AddWithValue("@sprice", Convert.ToInt32(sellbox.Text));
                    cmd.Parameters.AddWithValue("@pprice", Convert.ToInt32(buybox.Text));
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(qbox.Text));
                    cmd.Parameters.AddWithValue("@bcode", Convert.ToInt32(bbox.Text));
                    cmd.Parameters.AddWithValue("@pdate", purchasedate.Value);
                    cmd.Parameters.AddWithValue("@edate", expirydate.Value);
                    cmd.Parameters.AddWithValue("@id", idd);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }
            }
        }
    }
}
