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
                using (OleDbDataAdapter da = new OleDbDataAdapter("SELECT Drug_ID ,Drug_name, Drug_Barcode, Drug_Selling_Price, Drug_Purchase_Date, Drug_Expiry_Date, Drug_Quantity FROM Drug_Storage", con))
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
            DataGridViewButtonColumn amountbtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn deletebtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn editbtn = new DataGridViewButtonColumn();

            deletebtn.Name = "Delete";
            deletebtn.Text = "Delete";
            amountbtn.Name = "amount";
            amountbtn.Text = "Amount";
            editbtn.Name = "Edit";
            editbtn.Text = "Edit";
            deletebtn.UseColumnTextForButtonValue = true;
            editbtn.UseColumnTextForButtonValue = true;
            amountbtn.UseColumnTextForButtonValue = true;

            StorageTable.Columns.Add(amountbtn);
            StorageTable.Columns.Add(editbtn);
            StorageTable.Columns.Add(deletebtn);
            editbtn.HeaderText = "Actions";

        }
        public Medicine Lookup(int ID, string name, int qn, int Barcode)
        {
            using (OleDbCommand cmd = new OleDbCommand("Select * from Drug_Storage where Drug_Barcode = @Barcode", con))
            {
                cmd.Parameters.AddWithValue("@Barcode", StorageTable.CurrentRow.Cells[0]);
                con.Open();
                OleDbDataReader r = cmd.ExecuteReader();
                Medicine med = null;
                if (r.Read())
                {
                    med = new Medicine();

                    med.Medicine_ID = r.GetInt32(0);
                    med.Medicine_Name = r.GetString(1);
                    med.Quantity = r.GetInt32(6);
                    med.Barcode = r.GetInt32(4);

                }
                r.Close();
                con.Close();
                return med;
            }

        }

        private void Refresh_Tick(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                using (OleDbDataAdapter da = new OleDbDataAdapter( "SELECT Drug_ID ,Drug_name, Drug_Barcode, Drug_Selling_Price, Drug_Purchase_Date, Drug_Expiry_Date, Drug_Quantity FROM Drug_Storage", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    StorageTable.DataSource = dt;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }


        private void StorageTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Medicine med = new Medicine();

            if (e.ColumnIndex >= 0 && StorageTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string btnname = StorageTable.Columns[e.ColumnIndex].Name;


                if (btnname == "Delete")
                {
                    if (MessageBox.Show("ئایا تۆ دڵنیایت؟", "دڵنیاکردنەوە", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        DataGridViewRow row = StorageTable.Rows[e.RowIndex];

                        med.Medicine_ID = Convert.ToInt32(row.Cells[3].Value);
                        med.Medicine_Name = row.Cells[4].Value.ToString();
                        med.Quantity = Convert.ToInt32(row.Cells[6].Value);
                        med.Barcode = Convert.ToInt32(row.Cells[5].Value);

                        Crud.sql = "delete from Drug_storage where Drug_id = @id";
                        Crud.cmd = new OleDbCommand(Crud.sql, Crud.con);
                        Crud.cmd.Parameters.AddWithValue("@id", med.Medicine_ID);
                        Crud.CRUDoperation(Crud.cmd);
                        Refresh_Tick(sender, e);
                    }
                }
                else if (btnname == "Edit")
                {
                   DataGridViewRow row = StorageTable.Rows[e.RowIndex];
                   med.Medicine_ID = Convert.ToInt32(row.Cells[3].Value);
                   med.Medicine_Name = row.Cells[4].Value.ToString();
                   EditDataForm f = new EditDataForm(med.Medicine_ID, med.Medicine_Name);
                   f.Show();
                }
            }
        }
    }
}
