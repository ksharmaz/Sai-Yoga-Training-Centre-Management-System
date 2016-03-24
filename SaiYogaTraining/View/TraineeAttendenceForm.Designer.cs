namespace SaiYogaTraining.View
{
    partial class TraineeAttendenceForm
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
            this.resultView = new System.Windows.Forms.DataGridView();
            this.TakeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.courseSelect = new System.Windows.Forms.Label();
            this.courseTrainee = new System.Windows.Forms.ComboBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.selectBtn);
            this.mainPanel.Controls.Add(this.courseTrainee);
            this.mainPanel.Controls.Add(this.courseSelect);
            this.mainPanel.Controls.Add(this.cancelBtn);
            this.mainPanel.Controls.Add(this.TakeBtn);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // banner
            // 
            this.banner.Size = new System.Drawing.Size(584, 72);
            this.banner.Text = "Trainee Attendence";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(118)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(179, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 369);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultView);
            this.panel2.Location = new System.Drawing.Point(21, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 329);
            this.panel2.TabIndex = 0;
            // 
            // resultView
            // 
            this.resultView.AllowUserToAddRows = false;
            this.resultView.AllowUserToDeleteRows = false;
            this.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultView.Location = new System.Drawing.Point(0, 0);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(628, 329);
            this.resultView.TabIndex = 0;
            // 
            // TakeBtn
            // 
            this.TakeBtn.Location = new System.Drawing.Point(721, 444);
            this.TakeBtn.Name = "TakeBtn";
            this.TakeBtn.Size = new System.Drawing.Size(131, 36);
            this.TakeBtn.TabIndex = 3;
            this.TakeBtn.Text = "Take Attendence";
            this.TakeBtn.UseVisualStyleBackColor = true;
            this.TakeBtn.Click += new System.EventHandler(this.TakeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(179, 444);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(131, 36);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // courseSelect
            // 
            this.courseSelect.AutoSize = true;
            this.courseSelect.Location = new System.Drawing.Point(197, 19);
            this.courseSelect.Name = "courseSelect";
            this.courseSelect.Size = new System.Drawing.Size(113, 20);
            this.courseSelect.TabIndex = 5;
            this.courseSelect.Text = "Attendence For:";
            // 
            // courseTrainee
            // 
            this.courseTrainee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseTrainee.FormattingEnabled = true;
            this.courseTrainee.Location = new System.Drawing.Point(329, 16);
            this.courseTrainee.Name = "courseTrainee";
            this.courseTrainee.Size = new System.Drawing.Size(371, 28);
            this.courseTrainee.TabIndex = 6;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(749, 15);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(79, 28);
            this.selectBtn.TabIndex = 7;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // TraineeAttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 640);
            this.Name = "TraineeAttendenceForm";
            this.Text = "Sai Yoga Training - Trainee Attendence";
            this.Load += new System.EventHandler(this.TraineeAttendenceForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button TakeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox courseTrainee;
        private System.Windows.Forms.Label courseSelect;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.DataGridView resultView;
    }
}