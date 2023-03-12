namespace PharManager_v0._01
{
    partial class Forgot_Password_Form
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
            this.sendbtn = new System.Windows.Forms.Button();
            this.infolabel = new System.Windows.Forms.Label();
            this.EBox = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.VBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Vbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(103, 155);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 27);
            this.sendbtn.TabIndex = 3;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(62, 30);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(160, 17);
            this.infolabel.TabIndex = 0;
            this.infolabel.Text = "Enter Your Email address";
            // 
            // EBox
            // 
            this.EBox.Location = new System.Drawing.Point(63, 53);
            this.EBox.Name = "EBox";
            this.EBox.Size = new System.Drawing.Size(156, 24);
            this.EBox.TabIndex = 0;
            // 
            // backbtn
            // 
            this.backbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backbtn.Location = new System.Drawing.Point(20, 155);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 27);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // VBox
            // 
            this.VBox.Location = new System.Drawing.Point(61, 107);
            this.VBox.Name = "VBox";
            this.VBox.Size = new System.Drawing.Size(156, 24);
            this.VBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Verification Code";
            // 
            // Vbtn
            // 
            this.Vbtn.Location = new System.Drawing.Point(184, 155);
            this.Vbtn.Name = "Vbtn";
            this.Vbtn.Size = new System.Drawing.Size(75, 27);
            this.Vbtn.TabIndex = 4;
            this.Vbtn.Text = "Verify";
            this.Vbtn.UseVisualStyleBackColor = true;
            this.Vbtn.Click += new System.EventHandler(this.Vbtn_Click);
            // 
            // Forgot_Password_Form
            // 
            this.AcceptButton = this.sendbtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.backbtn;
            this.ClientSize = new System.Drawing.Size(279, 212);
            this.Controls.Add(this.Vbtn);
            this.Controls.Add(this.VBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.EBox);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.sendbtn);
            this.Name = "Forgot_Password_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.Forgot_Password_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.TextBox EBox;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox VBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Vbtn;
    }
}