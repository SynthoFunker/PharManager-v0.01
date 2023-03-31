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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineTab));
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.minbtn = new System.Windows.Forms.PictureBox();
            this.StorageTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageTable)).BeginInit();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closebtn.Location = new System.Drawing.Point(1835, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(33, 33);
            this.closebtn.TabIndex = 3;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // minbtn
            // 
            this.minbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minbtn.BackColor = System.Drawing.Color.Transparent;
            this.minbtn.Image = ((System.Drawing.Image)(resources.GetObject("minbtn.Image")));
            this.minbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minbtn.Location = new System.Drawing.Point(1803, 0);
            this.minbtn.Margin = new System.Windows.Forms.Padding(0);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(32, 32);
            this.minbtn.TabIndex = 4;
            this.minbtn.TabStop = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
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
            this.StorageTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StorageTable.ColumnHeadersHeight = 29;
            this.StorageTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StorageTable.Location = new System.Drawing.Point(0, 36);
            this.StorageTable.Name = "StorageTable";
            this.StorageTable.RowHeadersVisible = false;
            this.StorageTable.RowHeadersWidth = 51;
            this.StorageTable.RowTemplate.Height = 26;
            this.StorageTable.Size = new System.Drawing.Size(1868, 1011);
            this.StorageTable.TabIndex = 5;
            this.StorageTable.VirtualMode = true;
            // 
            // MedicineTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StorageTable);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.minbtn);
            this.DoubleBuffered = true;
            this.Name = "MedicineTab";
            this.Size = new System.Drawing.Size(1868, 1047);
            this.Load += new System.EventHandler(this.MedicineTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.PictureBox minbtn;
        private System.Windows.Forms.DataGridView StorageTable;
    }
}
