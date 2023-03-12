namespace PharManager_v0._01
{
    partial class Main_Window_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window_Form));
            this.minbtn = new System.Windows.Forms.PictureBox();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Med_Barcode = new System.Windows.Forms.TextBox();
            this.Med_Name = new System.Windows.Forms.TextBox();
            this.Tabcon = new System.Windows.Forms.Panel();
            this.MainIcons = new System.Windows.Forms.ImageList(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.Tabcon.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // minbtn
            // 
            this.minbtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.minbtn, "minbtn");
            this.minbtn.Name = "minbtn";
            this.minbtn.TabStop = false;
            this.minbtn.Click += new System.EventHandler(this.Minbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.closebtn, "closebtn");
            this.closebtn.Name = "closebtn";
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Med_Barcode
            // 
            resources.ApplyResources(this.Med_Barcode, "Med_Barcode");
            this.Med_Barcode.ForeColor = System.Drawing.Color.Silver;
            this.Med_Barcode.Name = "Med_Barcode";
            this.Med_Barcode.Enter += new System.EventHandler(this.Med_Barcode_Enter);
            this.Med_Barcode.Leave += new System.EventHandler(this.Med_Barcode_Leave);
            // 
            // Med_Name
            // 
            resources.ApplyResources(this.Med_Name, "Med_Name");
            this.Med_Name.ForeColor = System.Drawing.Color.Silver;
            this.Med_Name.Name = "Med_Name";
            this.Med_Name.Enter += new System.EventHandler(this.Med_Name_Enter);
            this.Med_Name.Leave += new System.EventHandler(this.Med_Name_Leave);
            // 
            // Tabcon
            // 
            resources.ApplyResources(this.Tabcon, "Tabcon");
            this.Tabcon.Controls.Add(this.minbtn);
            this.Tabcon.Controls.Add(this.button2);
            this.Tabcon.Controls.Add(this.Med_Barcode);
            this.Tabcon.Controls.Add(this.Med_Name);
            this.Tabcon.Name = "Tabcon";
            // 
            // MainIcons
            // 
            this.MainIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainIcons.ImageStream")));
            this.MainIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.MainIcons.Images.SetKeyName(0, "icons8-supplement-bottle-40.png");
            this.MainIcons.Images.SetKeyName(1, "icons8-estimate-40.png");
            this.MainIcons.Images.SetKeyName(2, "icons8-checkout-40.png");
            this.MainIcons.Images.SetKeyName(3, "icons8-data-backup-40.png");
            this.MainIcons.Images.SetKeyName(4, "icons8-services-40.png");
            this.MainIcons.Images.SetKeyName(5, "icons8-logout-40.png");
            this.MainIcons.Images.SetKeyName(6, "icons8-home-page-40.png");
            // 
            // sidebar
            // 
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.button3);
            this.sidebar.Controls.Add(this.button4);
            this.sidebar.Controls.Add(this.button5);
            this.sidebar.Controls.Add(this.button6);
            this.sidebar.Controls.Add(this.button7);
            this.sidebar.Controls.Add(this.button8);
            this.sidebar.Name = "sidebar";
            this.sidebar.MouseLeave += new System.EventHandler(this.sidebar_MouseLeave);
            this.sidebar.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.button1.ImageList = this.MainIcons;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Homebtn_Click);
            this.button1.MouseLeave += new System.EventHandler(this.sidebar_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.button3.ImageList = this.MainIcons;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Medicinebtn_Click);
            this.button3.MouseLeave += new System.EventHandler(this.sidebar_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.button4.ImageList = this.MainIcons;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Salesbtn_Click);
            this.button4.MouseLeave += new System.EventHandler(this.sidebar_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button5, "button5");
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.button5.ImageList = this.MainIcons;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseLeave += new System.EventHandler(this.sidebar_MouseLeave);
            this.button5.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button6, "button6");
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.button6.ImageList = this.MainIcons;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Backupbtn_Click);
            this.button6.MouseLeave += new System.EventHandler(this.sidebar_MouseLeave);
            this.button6.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button7, "button7");
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.button7.ImageList = this.MainIcons;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Settingsbtn_Click);
            this.button7.MouseLeave += new System.EventHandler(this.sidebar_MouseLeave);
            this.button7.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button8, "button8");
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.button8.ImageList = this.MainIcons;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Logoutbtn_Click);
            this.button8.MouseLeave += new System.EventHandler(this.sidebar_MouseLeave);
            this.button8.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // Main_Window_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.Tabcon);
            this.Controls.Add(this.sidebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Window_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Window_Form_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.Tabcon.ResumeLayout(false);
            this.Tabcon.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox minbtn;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.Panel Tabcon;
        private System.Windows.Forms.TextBox Med_Name;
        private System.Windows.Forms.TextBox Med_Barcode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList MainIcons;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}