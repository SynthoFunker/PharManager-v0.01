using PharManager_v0._01.FormContainer;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PharManager_v0._01.TabContainer
{
    public partial class MedicineTab : UserControl
    {
        private readonly OleDbConnection con = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;");
        public MedicineTab()
        {
            InitializeComponent();
        }

        private void MedicineTab_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                using (OleDbDataAdapter da = new OleDbDataAdapter("SELECT Drug_ID ,Drug_name, Drug_Barcode, Drug_Selling_Price, Drug_Purchase_Date, Drug_Expiry_Date, Drug_Quantity, Drug_Purchase_Price FROM Drug_Storage", con))
                {
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    StorageTable.DataSource = dt;
                    LoadTablebtns();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }

        }

        private void LoadTablebtns()
        {
            DataGridViewButtonColumn deletebtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();

            deletebtn.Name = "Delete";
            deletebtn.Text = "Delete";
            editbtn.Name = "Edit";
            editbtn.Text = "Edit";
            deletebtn.UseColumnTextForButtonValue = true;
            editbtn.UseColumnTextForButtonValue = true;

            StorageTable.Columns.Add(editbtn);
            StorageTable.Columns.Add(deletebtn);
            editbtn.HeaderText = "Actions";

        }






        private void StorageTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0 && StorageTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string btnname = StorageTable.Columns[e.ColumnIndex].Name;


                if (btnname == "Delete")
                {
                    if (MessageBox.Show("ئایا تۆ دڵنیایت؟", "دڵنیاکردنەوە", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                      
                        using (OleDbConnection con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;"))
                        {
                            using (OleDbCommand cmd = new OleDbCommand("delete from Drug_storage where Drug_id = @id", con))
                            {
                                DataGridViewRow row = StorageTable.Rows[e.RowIndex];
                                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(row.Cells[3].Value));
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                else if (btnname == "Edit")
                {
                    DataGridViewRow row = StorageTable.Rows[e.RowIndex];
                    int Medicine_ID = Convert.ToInt32(row.Cells[2].Value);
                    string Medicine_Name = row.Cells[3].Value.ToString();
                    int Quantity = Convert.ToInt32(row.Cells[8].Value);
                    int Barcode = Convert.ToInt32(row.Cells[4].Value);
                    DateTime Purchase_Date = Convert.ToDateTime(row.Cells[6].Value);
                    DateTime Expiry_Date = Convert.ToDateTime(row.Cells[7].Value);
                    int Selling_Price = Convert.ToInt32(row.Cells[5].Value);
                    int Purchase_Price = Convert.ToInt32(row.Cells[9].Value);

                    EditDataForm f = new EditDataForm(Medicine_ID, Medicine_Name, Barcode, Quantity, Selling_Price, Purchase_Price, Purchase_Date, Expiry_Date);
                    f.Show();
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
