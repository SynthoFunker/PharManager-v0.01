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
            this.button2 = new System.Windows.Forms.Button();
            this.Med_Barcode = new System.Windows.Forms.TextBox();
            this.Med_Name = new System.Windows.Forms.TextBox();
            this.Tabcon = new System.Windows.Forms.Panel();
            this.MainIcons = new System.Windows.Forms.ImageList(this.components);
            this.backupbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.side_animation_open = new System.Windows.Forms.Timer(this.components);
            this.Tabcon.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // backupbtn
            // 
            resources.ApplyResources(this.backupbtn, "backupbtn");
            this.backupbtn.Image = global::PharManager_v0._01.Properties.Resources.icons8_data_backup_40;
            this.backupbtn.Name = "backupbtn";
            this.backupbtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 35);
            this.backupbtn.Click += new System.EventHandler(this.Backupbtn_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardbtn,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.backupbtn,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.MouseLeave += new System.EventHandler(this.menuStrip1_MouseLeave);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // dashboardbtn
            // 
            resources.ApplyResources(this.dashboardbtn, "dashboardbtn");
            this.dashboardbtn.Image = global::PharManager_v0._01.Properties.Resources.icons8_home_page_40;
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 35);
            this.dashboardbtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem2.Image = global::PharManager_v0._01.Properties.Resources.icons8_supplement_bottle_40;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 35);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Medicinebtn_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Image = global::PharManager_v0._01.Properties.Resources.icons8_estimate_40;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 35);
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Salesbtn_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Image = global::PharManager_v0._01.Properties.Resources.icons8_checkout_40;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 35);
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Image = global::PharManager_v0._01.Properties.Resources.icons8_services_40;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 35);
            this.toolStripMenuItem5.Click += new System.EventHandler(this.Settingsbtn_Click);
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Image = global::PharManager_v0._01.Properties.Resources.icons8_logout_40;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 35);
            this.toolStripMenuItem6.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // side_animation_open
            // 
            this.side_animation_open.Interval = 20;
            this.side_animation_open.Tick += new System.EventHandler(this.side_animation_Tick);
            // 
            // Main_Window_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.Tabcon);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Window_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Tabcon.ResumeLayout(false);
            this.Tabcon.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Tabcon;
        private System.Windows.Forms.TextBox Med_Name;
        private System.Windows.Forms.TextBox Med_Barcode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList MainIcons;
        private System.Windows.Forms.ToolStripMenuItem backupbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardbtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Timer side_animation_open;
    }
}