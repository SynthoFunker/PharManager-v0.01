namespace PharManager_v0._01
{
    partial class RegisterForm
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
            this.FBox = new System.Windows.Forms.TextBox();
            this.regbtn = new System.Windows.Forms.Button();
            this.FLabel = new System.Windows.Forms.Label();
            this.LLabel = new System.Windows.Forms.Label();
            this.LBox = new System.Windows.Forms.TextBox();
            this.ELabel = new System.Windows.Forms.Label();
            this.EBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.Ulabel = new System.Windows.Forms.Label();
            this.Ubox = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CPasslabel = new System.Windows.Forms.Label();
            this.CPassBox = new System.Windows.Forms.TextBox();
            this.in_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FBox
            // 
            this.FBox.Location = new System.Drawing.Point(144, 39);
            this.FBox.Name = "FBox";
            this.FBox.Size = new System.Drawing.Size(100, 22);
            this.FBox.TabIndex = 0;
            // 
            // regbtn
            // 
            this.regbtn.Location = new System.Drawing.Point(140, 262);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(78, 55);
            this.regbtn.TabIndex = 6;
            this.regbtn.Text = "Register";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // FLabel
            // 
            this.FLabel.AutoSize = true;
            this.FLabel.Location = new System.Drawing.Point(18, 39);
            this.FLabel.Name = "FLabel";
            this.FLabel.Size = new System.Drawing.Size(72, 16);
            this.FLabel.TabIndex = 0;
            this.FLabel.Text = "First Name";
            // 
            // LLabel
            // 
            this.LLabel.AutoSize = true;
            this.LLabel.Location = new System.Drawing.Point(18, 72);
            this.LLabel.Name = "LLabel";
            this.LLabel.Size = new System.Drawing.Size(72, 16);
            this.LLabel.TabIndex = 0;
            this.LLabel.Text = "Last Name";
            // 
            // LBox
            // 
            this.LBox.Location = new System.Drawing.Point(144, 71);
            this.LBox.Name = "LBox";
            this.LBox.Size = new System.Drawing.Size(100, 22);
            this.LBox.TabIndex = 1;
            // 
            // ELabel
            // 
            this.ELabel.AutoSize = true;
            this.ELabel.Location = new System.Drawing.Point(18, 138);
            this.ELabel.Name = "ELabel";
            this.ELabel.Size = new System.Drawing.Size(41, 16);
            this.ELabel.TabIndex = 0;
            this.ELabel.Text = "Email";
            // 
            // EBox
            // 
            this.EBox.Location = new System.Drawing.Point(144, 135);
            this.EBox.Name = "EBox";
            this.EBox.Size = new System.Drawing.Size(100, 22);
            this.EBox.TabIndex = 3;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(18, 171);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(67, 16);
            this.PassLabel.TabIndex = 0;
            this.PassLabel.Text = "Password";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(144, 167);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(100, 22);
            this.PassBox.TabIndex = 4;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // Ulabel
            // 
            this.Ulabel.AutoSize = true;
            this.Ulabel.Location = new System.Drawing.Point(18, 105);
            this.Ulabel.Name = "Ulabel";
            this.Ulabel.Size = new System.Drawing.Size(70, 16);
            this.Ulabel.TabIndex = 0;
            this.Ulabel.Text = "Username";
            // 
            // Ubox
            // 
            this.Ubox.Location = new System.Drawing.Point(144, 103);
            this.Ubox.Name = "Ubox";
            this.Ubox.Size = new System.Drawing.Size(100, 22);
            this.Ubox.TabIndex = 2;
            // 
            // backbtn
            // 
            this.backbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backbtn.Location = new System.Drawing.Point(35, 262);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 55);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CPasslabel);
            this.groupBox1.Controls.Add(this.CPassBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registeration";
            // 
            // CPasslabel
            // 
            this.CPasslabel.AutoSize = true;
            this.CPasslabel.Location = new System.Drawing.Point(8, 194);
            this.CPasslabel.Name = "CPasslabel";
            this.CPasslabel.Size = new System.Drawing.Size(115, 16);
            this.CPasslabel.TabIndex = 0;
            this.CPasslabel.Text = "Confirm Password";
            // 
            // CPassBox
            // 
            this.CPassBox.Location = new System.Drawing.Point(134, 191);
            this.CPassBox.Name = "CPassBox";
            this.CPassBox.Size = new System.Drawing.Size(100, 22);
            this.CPassBox.TabIndex = 5;
            this.CPassBox.UseSystemPasswordChar = true;
            // 
            // in_timer
            // 
            this.in_timer.Enabled = true;
            this.in_timer.Tick += new System.EventHandler(this.in_timer_Tick);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.regbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backbtn;
            this.ClientSize = new System.Drawing.Size(270, 342);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Ulabel);
            this.Controls.Add(this.Ubox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.ELabel);
            this.Controls.Add(this.EBox);
            this.Controls.Add(this.FBox);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.FLabel);
            this.Controls.Add(this.LLabel);
            this.Controls.Add(this.LBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FBox;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Label FLabel;
        private System.Windows.Forms.Label LLabel;
        private System.Windows.Forms.TextBox LBox;
        private System.Windows.Forms.Label ELabel;
        private System.Windows.Forms.TextBox EBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label Ulabel;
        private System.Windows.Forms.TextBox Ubox;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CPasslabel;
        private System.Windows.Forms.TextBox CPassBox;
        private System.Windows.Forms.Timer in_timer;
    }
}