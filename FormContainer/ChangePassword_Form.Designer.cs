namespace PharManager_v0._01.FormContainer
{
    partial class ChangePassword_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CPassLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.CPassBox = new System.Windows.Forms.TextBox();
            this.Cobtn = new System.Windows.Forms.Button();
            this.Cabtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CPassLabel);
            this.groupBox1.Controls.Add(this.PassLabel);
            this.groupBox1.Controls.Add(this.PassBox);
            this.groupBox1.Controls.Add(this.CPassBox);
            this.groupBox1.Controls.Add(this.Cobtn);
            this.groupBox1.Controls.Add(this.Cabtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verifiaction Completed";
            // 
            // CPassLabel
            // 
            this.CPassLabel.AutoSize = true;
            this.CPassLabel.Location = new System.Drawing.Point(53, 95);
            this.CPassLabel.Name = "CPassLabel";
            this.CPassLabel.Size = new System.Drawing.Size(115, 16);
            this.CPassLabel.TabIndex = 0;
            this.CPassLabel.Text = "Confirm Password";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(44, 56);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(132, 16);
            this.PassLabel.TabIndex = 0;
            this.PassLabel.Text = "Enter Your Password";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(207, 56);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(100, 22);
            this.PassBox.TabIndex = 0;
            // 
            // CPassBox
            // 
            this.CPassBox.Location = new System.Drawing.Point(207, 95);
            this.CPassBox.Name = "CPassBox";
            this.CPassBox.Size = new System.Drawing.Size(100, 22);
            this.CPassBox.TabIndex = 1;
            // 
            // Cobtn
            // 
            this.Cobtn.Location = new System.Drawing.Point(193, 148);
            this.Cobtn.Name = "Cobtn";
            this.Cobtn.Size = new System.Drawing.Size(75, 23);
            this.Cobtn.TabIndex = 2;
            this.Cobtn.Text = "Confirm";
            this.Cobtn.UseVisualStyleBackColor = true;
            this.Cobtn.Click += new System.EventHandler(this.Cobtn_Click);
            // 
            // Cabtn
            // 
            this.Cabtn.Location = new System.Drawing.Point(82, 148);
            this.Cabtn.Name = "Cabtn";
            this.Cabtn.Size = new System.Drawing.Size(75, 23);
            this.Cabtn.TabIndex = 3;
            this.Cabtn.Text = "Cancel";
            this.Cabtn.UseVisualStyleBackColor = true;
            // 
            // ChangePassword_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 249);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChangePassword_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewPassword";
            this.Load += new System.EventHandler(this.ChangePassword_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CPassLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox CPassBox;
        private System.Windows.Forms.Button Cobtn;
        private System.Windows.Forms.Button Cabtn;
    }
}