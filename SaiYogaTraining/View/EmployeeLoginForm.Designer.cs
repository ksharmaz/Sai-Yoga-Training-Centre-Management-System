namespace SaiYogaTraining.View
{
    partial class EmployeeLoginForm
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
            this.admissionbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.courseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 23);
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(200, 23);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(129, 23);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.SetChildIndex(this.label1, 0);
            this.mainPanel.Controls.SetChildIndex(this.panel2, 0);
            this.mainPanel.Controls.SetChildIndex(this.panel1, 0);
            this.mainPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            this.mainPanel.Controls.SetChildIndex(this.button1, 0);
            this.mainPanel.Controls.SetChildIndex(this.uname, 0);
            // 
            // banner
            // 
            this.banner.Size = new System.Drawing.Size(490, 72);
            this.banner.Text = "Employees Page";
            // 
            // admissionbtn
            // 
            this.admissionbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionbtn.Location = new System.Drawing.Point(47, 41);
            this.admissionbtn.Name = "admissionbtn";
            this.admissionbtn.Size = new System.Drawing.Size(320, 46);
            this.admissionbtn.TabIndex = 3;
            this.admissionbtn.Text = "Admission Page";
            this.admissionbtn.UseVisualStyleBackColor = true;
            this.admissionbtn.Click += new System.EventHandler(this.admissionbtn_Click);
            this.admissionbtn.MouseLeave += new System.EventHandler(this.admissionbtn_MouseLeave);
            this.admissionbtn.MouseHover += new System.EventHandler(this.admissionbtn_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaiYogaTraining.Properties.Resources.yoga;
            this.pictureBox1.Location = new System.Drawing.Point(543, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(532, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 344);
            this.panel1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(11, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 33);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "\"Yoga is the fountain of youth. You\'re only as young as your spine is flexible.\"";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(118)))), ((int)(((byte)(77)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.courseBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.admissionbtn);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(84, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 344);
            this.panel2.TabIndex = 7;
            // 
            // courseBtn
            // 
            this.courseBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBtn.Location = new System.Drawing.Point(48, 103);
            this.courseBtn.Name = "courseBtn";
            this.courseBtn.Size = new System.Drawing.Size(320, 46);
            this.courseBtn.TabIndex = 5;
            this.courseBtn.Text = "Course Page";
            this.courseBtn.UseVisualStyleBackColor = true;
            this.courseBtn.Click += new System.EventHandler(this.courseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "GO TO";
            // 
            // EmployeeLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 640);
            this.Name = "EmployeeLoginForm";
            this.Text = "Sai Yoga Training - Employees Page";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button admissionbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button courseBtn;
    }
}