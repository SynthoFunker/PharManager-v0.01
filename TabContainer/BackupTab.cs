using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharManager_v0._01.TabContainer
{
    public partial class BackupTab : UserControl
    {
        public BackupTab()
        {
            InitializeComponent();
        }

        private void Bkbtn_Click(object sender, EventArgs e)
        {
            using (OleDbConnection Con = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\Pharmacy Database.accdb;Persist Security Info=True;"))
            {
                try
                {
                    string sourcePath = @"C:\Users\Han\Desktop\EPU files\Research\Program resource code\PharManager v0.01\bin\Debug\Pharmacy Database.accdb";
                    string backupPath = @"D:\Program Files\Backup\Pharmacy Database.accdb";

                    File.Copy(sourcePath, backupPath, true);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error {ex}");
                }
            }
        }

        private void Rsbtn_Click(object sender, EventArgs e)
        {
            try
            {
            string backupPath = @"D:\Program Files\Backup\Pharmacy Database.accdb";
            string restorePath = @"C:\Users\Han\Desktop\EPU files\Research\Program resource code\PharManager v0.01\bin\Debug\Pharmacy Database.accdb";
            File.Copy(backupPath, restorePath, true);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error{ex}");
            }
        }
    }
}
