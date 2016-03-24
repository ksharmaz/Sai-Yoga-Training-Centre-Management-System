namespace SaiYogaTraining.View
{
    partial class SalaryPayForm
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
            this.teacherSelect = new System.Windows.Forms.ComboBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.totalhrstxt = new System.Windows.Forms.TextBox();
            this.chrgtxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.paybtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelbtn);
            this.panel2.Controls.Add(this.paybtn);
            this.panel2.Controls.Add(this.totaltxt);
            this.panel2.Controls.Add(this.chrgtxt);
            this.panel2.Controls.Add(this.totalhrstxt);
            this.panel2.Controls.Add(this.idtxt);
            this.panel2.Controls.Add(this.teacherSelect);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary Pay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total No. of Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Charges Per Hour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Pay Amount";
            // 
            // teacherSelect
            // 
            this.teacherSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.teacherSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teacherSelect.FormattingEnabled = true;
            this.teacherSelect.Location = new System.Drawing.Point(200, 80);
            this.teacherSelect.Name = "teacherSelect";
            this.teacherSelect.Size = new System.Drawing.Size(202, 28);
            this.teacherSelect.TabIndex = 6;
            this.teacherSelect.SelectedIndexChanged += new System.EventHandler(this.teacherSelect_SelectedIndexChanged);
            // 
            // idtxt
            // 
            this.idtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idtxt.Enabled = false;
            this.idtxt.Location = new System.Drawing.Point(510, 80);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 27);
            this.idtxt.TabIndex = 7;
            // 
            // totalhrstxt
            // 
            this.totalhrstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalhrstxt.Enabled = false;
            this.totalhrstxt.Location = new System.Drawing.Point(200, 136);
            this.totalhrstxt.Name = "totalhrstxt";
            this.totalhrstxt.Size = new System.Drawing.Size(202, 27);
            this.totalhrstxt.TabIndex = 8;
            // 
            // chrgtxt
            // 
            this.chrgtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chrgtxt.Location = new System.Drawing.Point(200, 197);
            this.chrgtxt.Name = "chrgtxt";
            this.chrgtxt.Size = new System.Drawing.Size(202, 27);
            this.chrgtxt.TabIndex = 9;
            this.chrgtxt.TextChanged += new System.EventHandler(this.chrgtxt_TextChanged);
            // 
            // totaltxt
            // 
            this.totaltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totaltxt.Enabled = false;
            this.totaltxt.Location = new System.Drawing.Point(200, 250);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(202, 27);
            this.totaltxt.TabIndex = 10;
            // 
            // paybtn
            // 
            this.paybtn.Enabled = false;
            this.paybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paybtn.Location = new System.Drawing.Point(480, 340);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(100, 36);
            this.paybtn.TabIndex = 11;
            this.paybtn.Text = "Pay Salary";
            this.paybtn.UseVisualStyleBackColor = true;
            this.paybtn.Click += new System.EventHandler(this.paybtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(200, 340);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(100, 36);
            this.cancelbtn.TabIndex = 12;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // SalaryPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 422);
            this.Name = "SalaryPayForm";
            this.Text = "Sai Yoga Training - Salary Pay";
            this.Load += new System.EventHandler(this.SalaryPayForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.ComboBox teacherSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.TextBox chrgtxt;
        private System.Windows.Forms.TextBox totalhrstxt;
        private System.Windows.Forms.Button paybtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}