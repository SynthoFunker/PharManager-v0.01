namespace PharManager_v0._01.FormContainer
{
    partial class EditDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDataForm));
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nbox = new System.Windows.Forms.TextBox();
            this.sellbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expirydate = new System.Windows.Forms.DateTimePicker();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.purchasedate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(121, 345);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(80, 34);
            this.submit.TabIndex = 5;
            this.submit.Text = "گۆڕین";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ناو";
            // 
            // nbox
            // 
            this.nbox.Location = new System.Drawing.Point(41, 74);
            this.nbox.Name = "nbox";
            this.nbox.Size = new System.Drawing.Size(111, 24);
            this.nbox.TabIndex = 0;
            // 
            // sellbox
            // 
            this.sellbox.Location = new System.Drawing.Point(41, 115);
            this.sellbox.Name = "sellbox";
            this.sellbox.Size = new System.Drawing.Size(111, 24);
            this.sellbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "نرخی فرۆشتن";
            // 
            // qbox
            // 
            this.qbox.Location = new System.Drawing.Point(41, 156);
            this.qbox.Name = "qbox";
            this.qbox.Size = new System.Drawing.Size(111, 24);
            this.qbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ڕێژە";
            // 
            // bbox
            // 
            this.bbox.Location = new System.Drawing.Point(41, 197);
            this.bbox.Name = "bbox";
            this.bbox.Size = new System.Drawing.Size(111, 24);
            this.bbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "باڕکۆد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "بەرواری بەسەرچوون";
            // 
            // expirydate
            // 
            this.expirydate.CustomFormat = "d-M-yyyy";
            this.expirydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expirydate.Location = new System.Drawing.Point(41, 279);
            this.expirydate.Name = "expirydate";
            this.expirydate.Size = new System.Drawing.Size(111, 24);
            this.expirydate.TabIndex = 10;
            this.expirydate.Value = new System.DateTime(2023, 3, 6, 0, 0, 0, 0);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closebtn.Location = new System.Drawing.Point(291, -1);
            this.closebtn.Margin = new System.Windows.Forms.Padding(0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(33, 33);
            this.closebtn.TabIndex = 11;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // purchasedate
            // 
            this.purchasedate.CustomFormat = "d-M-yyyy";
            this.purchasedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.purchasedate.Location = new System.Drawing.Point(41, 238);
            this.purchasedate.Name = "purchasedate";
            this.purchasedate.Size = new System.Drawing.Size(111, 24);
            this.purchasedate.TabIndex = 13;
            this.purchasedate.Value = new System.DateTime(2023, 3, 6, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "بەرواری کڕین";
            // 
            // EditDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 439);
            this.Controls.Add(this.purchasedate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.expirydate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nbox;
        private System.Windows.Forms.TextBox sellbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker expirydate;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.DateTimePicker purchasedate;
        private System.Windows.Forms.Label label6;
    }
}