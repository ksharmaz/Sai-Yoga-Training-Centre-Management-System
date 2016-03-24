namespace SaiYogaTraining.View
{
    partial class TeacherAttendenceForm
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
            this.components = new System.ComponentModel.Container();
            this.initBtn = new System.Windows.Forms.Button();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultView = new System.Windows.Forms.DataGridView();
            this.srnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tadateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hrsperdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saiYogaDBDataSet = new SaiYogaTraining.SaiYogaDBDataSet();
            this.teacherAttendanceTableAdapter = new SaiYogaTraining.SaiYogaDBDataSetTableAdapters.TeacherAttendanceTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saiYogaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.resultPanel);
            this.mainPanel.Controls.Add(this.initBtn);
            this.mainPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // banner
            // 
            this.banner.Location = new System.Drawing.Point(185, 35);
            this.banner.Size = new System.Drawing.Size(593, 72);
            this.banner.Text = "Teacher Attendence";
            // 
            // initBtn
            // 
            this.initBtn.Location = new System.Drawing.Point(383, 394);
            this.initBtn.Name = "initBtn";
            this.initBtn.Size = new System.Drawing.Size(192, 42);
            this.initBtn.TabIndex = 0;
            this.initBtn.Text = "Take Today\'s Attendence";
            this.initBtn.UseVisualStyleBackColor = true;
            this.initBtn.Click += new System.EventHandler(this.initBtn_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(118)))), ((int)(((byte)(77)))));
            this.resultPanel.Controls.Add(this.panel2);
            this.resultPanel.Location = new System.Drawing.Point(201, 21);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(581, 350);
            this.resultPanel.TabIndex = 1;
            this.resultPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultView);
            this.panel2.Location = new System.Drawing.Point(34, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 288);
            this.panel2.TabIndex = 0;
            // 
            // resultView
            // 
            this.resultView.AllowUserToAddRows = false;
            this.resultView.AllowUserToDeleteRows = false;
            this.resultView.AutoGenerateColumns = false;
            this.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srnoDataGridViewTextBoxColumn,
            this.tadateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.hrsperdayDataGridViewTextBoxColumn,
            this.teacheridDataGridViewTextBoxColumn});
            this.resultView.DataSource = this.teacherAttendanceBindingSource;
            this.resultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultView.Location = new System.Drawing.Point(0, 0);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(517, 288);
            this.resultView.TabIndex = 0;
            // 
            // srnoDataGridViewTextBoxColumn
            // 
            this.srnoDataGridViewTextBoxColumn.DataPropertyName = "sr_no";
            this.srnoDataGridViewTextBoxColumn.HeaderText = "Sr No.";
            this.srnoDataGridViewTextBoxColumn.Name = "srnoDataGridViewTextBoxColumn";
            this.srnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.srnoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tadateDataGridViewTextBoxColumn
            // 
            this.tadateDataGridViewTextBoxColumn.DataPropertyName = "tadate";
            this.tadateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.tadateDataGridViewTextBoxColumn.Name = "tadateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Absent",
            "Present"});
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hrsperdayDataGridViewTextBoxColumn
            // 
            this.hrsperdayDataGridViewTextBoxColumn.DataPropertyName = "hrs_per_day";
            this.hrsperdayDataGridViewTextBoxColumn.HeaderText = "Hours Per Day";
            this.hrsperdayDataGridViewTextBoxColumn.Name = "hrsperdayDataGridViewTextBoxColumn";
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "Teacher ID";
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            // 
            // teacherAttendanceBindingSource
            // 
            this.teacherAttendanceBindingSource.DataMember = "TeacherAttendance";
            this.teacherAttendanceBindingSource.DataSource = this.saiYogaDBDataSet;
            // 
            // saiYogaDBDataSet
            // 
            this.saiYogaDBDataSet.DataSetName = "SaiYogaDBDataSet";
            this.saiYogaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherAttendanceTableAdapter
            // 
            this.teacherAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaiYogaTraining.Properties.Resources.file_text_icon;
            this.pictureBox1.Location = new System.Drawing.Point(800, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TeacherAttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 586);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TeacherAttendenceForm";
            this.Text = "Sai Yoga Training - Teacher Attendence";
            this.Load += new System.EventHandler(this.TeacherAttendenceForm_Load);
            this.Controls.SetChildIndex(this.banner, 0);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.mainPanel.ResumeLayout(false);
            this.resultPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saiYogaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initBtn;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView resultView;
        private SaiYogaDBDataSet saiYogaDBDataSet;
        private System.Windows.Forms.BindingSource teacherAttendanceBindingSource;
        private SaiYogaDBDataSetTableAdapters.TeacherAttendanceTableAdapter teacherAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn srnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tadateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrsperdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}