namespace PharManager_v0._01.TabContainer
{
    partial class MedicineTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StorageTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StorageTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StorageTable
            // 
            this.StorageTable.AllowUserToAddRows = false;
            this.StorageTable.AllowUserToDeleteRows = false;
            this.StorageTable.AllowUserToResizeColumns = false;
            this.StorageTable.AllowUserToResizeRows = false;
            this.StorageTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StorageTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StorageTable.BackgroundColor = System.Drawing.Color.Aqua;
            this.StorageTable.ColumnHeadersHeight = 29;
            this.StorageTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageTable.Location = new System.Drawing.Point(0, 0);
            this.StorageTable.Name = "StorageTable";
            this.StorageTable.RowHeadersVisible = false;
            this.StorageTable.RowHeadersWidth = 51;
            this.StorageTable.RowTemplate.Height = 26;
            this.StorageTable.Size = new System.Drawing.Size(888, 501);
            this.StorageTable.TabIndex = 0;
            this.StorageTable.VirtualMode = true;
            this.StorageTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageTable_CellContentClick);
            // 
            // MedicineTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StorageTable);
            this.DoubleBuffered = true;
            this.Name = "MedicineTab";
            this.Size = new System.Drawing.Size(888, 501);
            this.Load += new System.EventHandler(this.MedicineTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StorageTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StorageTable;
    }
}
