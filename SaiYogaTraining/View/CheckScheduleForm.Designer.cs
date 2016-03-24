namespace SaiYogaTraining.View
{
    partial class CheckScheduleForm
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.Teacher = new System.Windows.Forms.RadioButton();
            this.Course = new System.Windows.Forms.RadioButton();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.radioGroup.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.searchPanel);
            this.mainPanel.Controls.Add(this.radioGroup);
            this.mainPanel.Controls.Add(this.searchBtn);
            this.mainPanel.Controls.Add(this.searchBox);
            // 
            // banner
            // 
            this.banner.Location = new System.Drawing.Point(178, 33);
            this.banner.Size = new System.Drawing.Size(473, 72);
            this.banner.Text = "Check Schedule";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(217, 18);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(461, 33);
            this.searchBox.TabIndex = 0;
            this.searchBox.Text = "Search by Course Name or Teacher Name";
            // 
            // searchBtn
            // 
            this.searchBtn.BackgroundImage = global::SaiYogaTraining.Properties.Resources.search_icon;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.Location = new System.Drawing.Point(693, 15);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(42, 42);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // radioGroup
            // 
            this.radioGroup.Controls.Add(this.Teacher);
            this.radioGroup.Controls.Add(this.Course);
            this.radioGroup.Location = new System.Drawing.Point(217, 58);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(461, 43);
            this.radioGroup.TabIndex = 2;
            this.radioGroup.TabStop = false;
            // 
            // Teacher
            // 
            this.Teacher.AutoSize = true;
            this.Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher.Location = new System.Drawing.Point(270, 19);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(65, 17);
            this.Teacher.TabIndex = 1;
            this.Teacher.Text = "Teacher";
            this.Teacher.UseVisualStyleBackColor = true;
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.Checked = true;
            this.Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.Location = new System.Drawing.Point(104, 19);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(58, 17);
            this.Course.TabIndex = 0;
            this.Course.TabStop = true;
            this.Course.Text = "Course";
            this.Course.UseVisualStyleBackColor = true;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(118)))), ((int)(((byte)(77)))));
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.panel2);
            this.searchPanel.Location = new System.Drawing.Point(97, 107);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(742, 386);
            this.searchPanel.TabIndex = 3;
            this.searchPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Result";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultView);
            this.panel2.Location = new System.Drawing.Point(28, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 342);
            this.panel2.TabIndex = 0;
            // 
            // resultView
            // 
            this.resultView.AllowUserToAddRows = false;
            this.resultView.AllowUserToDeleteRows = false;
            this.resultView.BackgroundColor = System.Drawing.Color.White;
            this.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultView.Location = new System.Drawing.Point(0, 0);
            this.resultView.Name = "resultView";
            this.resultView.ReadOnly = true;
            this.resultView.Size = new System.Drawing.Size(684, 342);
            this.resultView.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaiYogaTraining.Properties.Resources.clock_icon;
            this.pictureBox1.Location = new System.Drawing.Point(735, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CheckScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 640);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CheckScheduleForm";
            this.Text = "Sai Yoga Training - Check Schedule";
            this.Controls.SetChildIndex(this.banner, 0);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.RadioButton Teacher;
        private System.Windows.Forms.RadioButton Course;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView resultView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}