namespace PharManager_v0._01.TabContainer
{
    partial class SettingsTab
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsTab));
            this.cngbtn = new System.Windows.Forms.Button();
            this.crtbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.minbtn = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // cngbtn
            // 
            resources.ApplyResources(this.cngbtn, "cngbtn");
            this.cngbtn.Name = "cngbtn";
            this.cngbtn.UseVisualStyleBackColor = true;
            // 
            // crtbtn
            // 
            resources.ApplyResources(this.crtbtn, "crtbtn");
            this.crtbtn.Name = "crtbtn";
            this.crtbtn.UseVisualStyleBackColor = true;
            this.crtbtn.Click += new System.EventHandler(this.crtbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.closebtn, "closebtn");
            this.closebtn.Name = "closebtn";
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // minbtn
            // 
            this.minbtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.minbtn, "minbtn");
            this.minbtn.Name = "minbtn";
            this.minbtn.TabStop = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SettingsTab
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.minbtn);
            this.Controls.Add(this.crtbtn);
            this.Controls.Add(this.cngbtn);
            this.Name = "SettingsTab";
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cngbtn;
        private System.Windows.Forms.Button crtbtn;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.PictureBox minbtn;
        private System.Windows.Forms.Button button1;      
    }
}
