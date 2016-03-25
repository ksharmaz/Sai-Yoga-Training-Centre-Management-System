namespace SaiYogaTraining.View
{
    partial class CourseAddForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.courseFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.courseBenefits = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.courseType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel1);
            // 
            // banner
            // 
            this.banner.Size = new System.Drawing.Size(360, 72);
            this.banner.Text = "Add Course";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(118)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(116, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 465);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.courseFee);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.courseBenefits);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.courseType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.courseDuration);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.courseName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.submitbtn);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(22, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 426);
            this.panel2.TabIndex = 1;
            // 
            // courseFee
            // 
            this.courseFee.Location = new System.Drawing.Point(279, 274);
            this.courseFee.Name = "courseFee";
            this.courseFee.Size = new System.Drawing.Size(231, 27);
            this.courseFee.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Course Fee";
            // 
            // courseBenefits
            // 
            this.courseBenefits.Location = new System.Drawing.Point(279, 209);
            this.courseBenefits.Name = "courseBenefits";
            this.courseBenefits.Size = new System.Drawing.Size(231, 47);
            this.courseBenefits.TabIndex = 8;
            this.courseBenefits.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Benefits";
            // 
            // courseType
            // 
            this.courseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseType.FormattingEnabled = true;
            this.courseType.Items.AddRange(new object[] {
            "Meditation",
            "Spiritual",
            "Restoration",
            "Physical Practice",
            "Hybrid"});
            this.courseType.Location = new System.Drawing.Point(279, 153);
            this.courseType.Name = "courseType";
            this.courseType.Size = new System.Drawing.Size(231, 28);
            this.courseType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course Type";
            // 
            // courseDuration
            // 
            this.courseDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseDuration.FormattingEnabled = true;
            this.courseDuration.Items.AddRange(new object[] {
            "1 Month",
            "2 Months",
            "3 Months",
            "6 Months",
            "9 Months",
            "12 Months",
            "18 Months",
            "2 Years",
            "3 Years"});
            this.courseDuration.Location = new System.Drawing.Point(279, 96);
            this.courseDuration.Name = "courseDuration";
            this.courseDuration.Size = new System.Drawing.Size(231, 28);
            this.courseDuration.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Duration";
            // 
            // courseName
            // 
            this.courseName.Location = new System.Drawing.Point(279, 41);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(231, 27);
            this.courseName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name";
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(291, 365);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(101, 32);
            this.submitbtn.TabIndex = 0;
            this.submitbtn.Text = "Add Course";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaiYogaTraining.Properties.Resources.layers_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(731, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CourseAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 640);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CourseAddForm";
            this.Text = "Sai Yoga Training - Add Course";
            this.Load += new System.EventHandler(this.CourseAddForm_Load);
            this.Controls.SetChildIndex(this.banner, 0);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox courseDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox courseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox courseBenefits;
        private System.Windows.Forms.TextBox courseFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}