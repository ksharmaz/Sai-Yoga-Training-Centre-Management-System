namespace SaiYogaTraining.View
{
    partial class FeePayForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.balancetxt = new System.Windows.Forms.TextBox();
            this.amttxt = new System.Windows.Forms.TextBox();
            this.remarkstxt = new System.Windows.Forms.RichTextBox();
            this.datetxt = new System.Windows.Forms.DateTimePicker();
            this.typetxt = new System.Windows.Forms.ComboBox();
            this.receiptbtn = new System.Windows.Forms.Button();
            this.paybtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.paybtn);
            this.panel2.Controls.Add(this.receiptbtn);
            this.panel2.Controls.Add(this.typetxt);
            this.panel2.Controls.Add(this.datetxt);
            this.panel2.Controls.Add(this.remarkstxt);
            this.panel2.Controls.Add(this.amttxt);
            this.panel2.Controls.Add(this.balancetxt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fee Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance Remaining";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Remarks";
            // 
            // balancetxt
            // 
            this.balancetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balancetxt.Enabled = false;
            this.balancetxt.Location = new System.Drawing.Point(218, 72);
            this.balancetxt.Name = "balancetxt";
            this.balancetxt.Size = new System.Drawing.Size(274, 20);
            this.balancetxt.TabIndex = 6;
            // 
            // amttxt
            // 
            this.amttxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amttxt.Location = new System.Drawing.Point(218, 117);
            this.amttxt.Name = "amttxt";
            this.amttxt.Size = new System.Drawing.Size(274, 20);
            this.amttxt.TabIndex = 7;
            // 
            // remarkstxt
            // 
            this.remarkstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remarkstxt.Location = new System.Drawing.Point(218, 252);
            this.remarkstxt.Name = "remarkstxt";
            this.remarkstxt.Size = new System.Drawing.Size(274, 59);
            this.remarkstxt.TabIndex = 8;
            this.remarkstxt.Text = "";
            // 
            // datetxt
            // 
            this.datetxt.Location = new System.Drawing.Point(218, 160);
            this.datetxt.MaxDate = new System.DateTime(2016, 3, 21, 0, 0, 0, 0);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(274, 27);
            this.datetxt.TabIndex = 9;
            this.datetxt.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // typetxt
            // 
            this.typetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typetxt.FormattingEnabled = true;
            this.typetxt.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Demand Draft",
            "Others"});
            this.typetxt.Location = new System.Drawing.Point(218, 209);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(274, 28);
            this.typetxt.TabIndex = 10;
            // 
            // receiptbtn
            // 
            this.receiptbtn.Enabled = false;
            this.receiptbtn.Location = new System.Drawing.Point(68, 366);
            this.receiptbtn.Name = "receiptbtn";
            this.receiptbtn.Size = new System.Drawing.Size(145, 32);
            this.receiptbtn.TabIndex = 11;
            this.receiptbtn.Text = "Generate Receipt";
            this.receiptbtn.UseVisualStyleBackColor = true;
            this.receiptbtn.Click += new System.EventHandler(this.receiptbtn_Click);
            // 
            // paybtn
            // 
            this.paybtn.Location = new System.Drawing.Point(374, 366);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(118, 32);
            this.paybtn.TabIndex = 12;
            this.paybtn.Text = "Pay Fee";
            this.paybtn.UseVisualStyleBackColor = true;
            this.paybtn.Click += new System.EventHandler(this.paybtn_Click);
            // 
            // FeePayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 466);
            this.Name = "FeePayForm";
            this.Text = "FeePayForm";
            this.Load += new System.EventHandler(this.FeePayForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typetxt;
        private System.Windows.Forms.DateTimePicker datetxt;
        private System.Windows.Forms.RichTextBox remarkstxt;
        private System.Windows.Forms.TextBox amttxt;
        private System.Windows.Forms.TextBox balancetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button paybtn;
        private System.Windows.Forms.Button receiptbtn;
    }
}