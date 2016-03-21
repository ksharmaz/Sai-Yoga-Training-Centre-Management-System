namespace SaiYogaTraining.View
{
    partial class TeacherForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.teacherIDList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.qualificationList = new System.Windows.Forms.ComboBox();
            this.addTeacher = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
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
            this.panel2.Controls.Add(this.teacherIDList);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.nametxt, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.label4, 0);
            this.panel2.Controls.SetChildIndex(this.label5, 0);
            this.panel2.Controls.SetChildIndex(this.contacttxt, 0);
            this.panel2.Controls.SetChildIndex(this.editbtn, 0);
            this.panel2.Controls.SetChildIndex(this.delbtn, 0);
            this.panel2.Controls.SetChildIndex(this.addresstxt, 0);
            this.panel2.Controls.SetChildIndex(this.label6, 0);
            this.panel2.Controls.SetChildIndex(this.teacherIDList, 0);
            this.panel2.Controls.SetChildIndex(this.label7, 0);
            this.panel2.Controls.SetChildIndex(this.qualificationList, 0);
            this.panel2.Controls.SetChildIndex(this.addTeacher, 0);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(553, 376);
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(142, 376);
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(215, 169);
            this.contacttxt.Size = new System.Drawing.Size(426, 27);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(138, 172);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(138, 225);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(328, 9);
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.Text = "Teacher Details";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(215, 116);
            this.nametxt.Size = new System.Drawing.Size(426, 27);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(138, 119);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(215, 222);
            this.addresstxt.Size = new System.Drawing.Size(426, 67);
            // 
            // banner
            // 
            this.banner.Location = new System.Drawing.Point(174, 34);
            this.banner.Size = new System.Drawing.Size(496, 72);
            this.banner.Text = "Manage Teacher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Teacher ID";
            // 
            // teacherIDList
            // 
            this.teacherIDList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherIDList.FormattingEnabled = true;
            this.teacherIDList.Location = new System.Drawing.Point(225, 62);
            this.teacherIDList.Name = "teacherIDList";
            this.teacherIDList.Size = new System.Drawing.Size(416, 28);
            this.teacherIDList.TabIndex = 12;
            this.teacherIDList.SelectedIndexChanged += new System.EventHandler(this.teacherIDList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 314);
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
            "A. Yoga, Journalism & Mass Communication",
            "Sc. Yoga Management",
            "Sc. Yoga & Consciousness",
            "Sc. Yoga Education",
            "Sc. Yoga",
            "PGD in Yoga Therapy for Doctors",
            "PGD in Yoga Therapy",
            "A. Yoga & Journalism",
            "Sc. Yoga & Management",
            "Sc. Yoga & Consciousness",
            "Sc. Yoga Education",
            "Sc. Yoga",
            "Yoga Therapy Orientation Training For Doctors",
            "Yoga Teachers Training Course",
            "Yoga Instructor Course",
            "PhD Yoga",
            "D. Yoga & Rehabilitation",
            "Phil Counselling & Yoga Therapy"});
            this.qualificationList.Location = new System.Drawing.Point(240, 311);
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
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 661);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teacherIDList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addTeacher;
        private System.Windows.Forms.ComboBox qualificationList;
        private System.Windows.Forms.Label label7;
    }
}