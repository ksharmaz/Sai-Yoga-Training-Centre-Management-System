namespace SaiYogaTraining.View
{
    partial class TeacherAddForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.qualificationList = new System.Windows.Forms.ComboBox();
            this.addTeacher = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(70, 24);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addTeacher);
            this.panel2.Controls.Add(this.qualificationList);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.nametxt, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.label4, 0);
            this.panel2.Controls.SetChildIndex(this.label5, 0);
            this.panel2.Controls.SetChildIndex(this.contacttxt, 0);
            this.panel2.Controls.SetChildIndex(this.editbtn, 0);
            this.panel2.Controls.SetChildIndex(this.delbtn, 0);
            this.panel2.Controls.SetChildIndex(this.addresstxt, 0);
            this.panel2.Controls.SetChildIndex(this.label7, 0);
            this.panel2.Controls.SetChildIndex(this.qualificationList, 0);
            this.panel2.Controls.SetChildIndex(this.addTeacher, 0);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(770, 420);
            this.delbtn.Size = new System.Drawing.Size(10, 10);
            this.delbtn.Visible = false;
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(0, 420);
            this.editbtn.Size = new System.Drawing.Size(10, 10);
            this.editbtn.Visible = false;
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(219, 131);
            this.contacttxt.Size = new System.Drawing.Size(426, 27);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(142, 134);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(142, 187);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(328, 9);
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.Text = "Fill Teacher Details";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(219, 78);
            this.nametxt.Size = new System.Drawing.Size(426, 27);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(142, 81);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(219, 184);
            this.addresstxt.Size = new System.Drawing.Size(426, 67);
            // 
            // banner
            // 
            this.banner.Location = new System.Drawing.Point(174, 34);
            this.banner.Size = new System.Drawing.Size(388, 72);
            this.banner.Text = "Add Teacher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Qualification";
            // 
            // qualificationList
            // 
            this.qualificationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualificationList.FormattingEnabled = true;
            this.qualificationList.Items.AddRange(new object[] {
            "Sc. Yoga",
            "PhD Yoga",
            "Sc. Yoga Education",
            "Sc. Yoga Management",
            "PGD in Yoga Therapy",
            "Yoga Instructor Course",
            "Sc. Yoga & Consciousness",
            "D. Yoga & Rehabilitation",
            "Yoga Teachers Training Course",
            "PGD in Yoga Therapy for Doctors",
            "Phil Counselling & Yoga Therapy",
            "A. Yoga, Journalism & Mass Communication",
            "Yoga Therapy Orientation Training For Doctors"});
            this.qualificationList.Location = new System.Drawing.Point(244, 273);
            this.qualificationList.Name = "qualificationList";
            this.qualificationList.Size = new System.Drawing.Size(401, 28);
            this.qualificationList.TabIndex = 14;
            // 
            // addTeacher
            // 
            this.addTeacher.Location = new System.Drawing.Point(332, 376);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(104, 30);
            this.addTeacher.TabIndex = 15;
            this.addTeacher.Text = "Add Teacher";
            this.addTeacher.UseVisualStyleBackColor = true;
            this.addTeacher.Click += new System.EventHandler(this.addTeacher_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaiYogaTraining.Properties.Resources.user_female_alt_icon;
            this.pictureBox1.Location = new System.Drawing.Point(764, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TeacherAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 661);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TeacherAddForm";
            this.Text = "Sai Yoga Training - Add Teacher";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.Controls.SetChildIndex(this.banner, 0);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addTeacher;
        private System.Windows.Forms.ComboBox qualificationList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}