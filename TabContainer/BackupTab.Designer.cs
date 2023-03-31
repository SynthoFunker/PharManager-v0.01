namespace PharManager_v0._01.TabContainer
{
    partial class BackupTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupTab));
            this.Bkbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rsbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.minbtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // Bkbtn
            // 
            this.Bkbtn.Location = new System.Drawing.Point(550, 157);
            this.Bkbtn.Name = "Bkbtn";
            this.Bkbtn.Size = new System.Drawing.Size(80, 33);
            this.Bkbtn.TabIndex = 0;
            this.Bkbtn.Text = "Backup";
            this.Bkbtn.UseVisualStyleBackColor = true;
            this.Bkbtn.Click += new System.EventHandler(this.Bkbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(328, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "backup Database File (Export)";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(322, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Restore Database File (Import)";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // rsbtn
            // 
            this.rsbtn.Location = new System.Drawing.Point(550, 313);
            this.rsbtn.Name = "rsbtn";
            this.rsbtn.Size = new System.Drawing.Size(80, 46);
            this.rsbtn.TabIndex = 2;
            this.rsbtn.Text = "Restore Recent";
            this.rsbtn.UseVisualStyleBackColor = true;
            this.rsbtn.Click += new System.EventHandler(this.Rsbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closebtn.Location = new System.Drawing.Point(1835, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(33, 33);
            this.closebtn.TabIndex = 5;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // minbtn
            // 
            this.minbtn.BackColor = System.Drawing.Color.Transparent;
            this.minbtn.Image = ((System.Drawing.Image)(resources.GetObject("minbtn.Image")));
            this.minbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minbtn.Location = new System.Drawing.Point(1803, 0);
            this.minbtn.Margin = new System.Windows.Forms.Padding(0);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(32, 32);
            this.minbtn.TabIndex = 6;
            this.minbtn.TabStop = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // BackupTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.minbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rsbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bkbtn);
            this.Name = "BackupTab";
            this.Size = new System.Drawing.Size(1868, 1047);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bkbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rsbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.PictureBox minbtn;
    }
}
