namespace SaiYogaTraining.View
{
    partial class TraineeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgbox = new System.Windows.Forms.PictureBox();
            this.datetimectrl = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.idSelector = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.feebtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.coursetxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.coursetxt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.feebtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.idSelector);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.datetimectrl);
            this.panel2.Controls.Add(this.imgbox);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.imgbox, 0);
            this.panel2.Controls.SetChildIndex(this.datetimectrl, 0);
            this.panel2.Controls.SetChildIndex(this.label6, 0);
            this.panel2.Controls.SetChildIndex(this.idSelector, 0);
            this.panel2.Controls.SetChildIndex(this.label7, 0);
            this.panel2.Controls.SetChildIndex(this.feebtn, 0);
            this.panel2.Controls.SetChildIndex(this.label8, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.nametxt, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.label4, 0);
            this.panel2.Controls.SetChildIndex(this.label5, 0);
            this.panel2.Controls.SetChildIndex(this.contacttxt, 0);
            this.panel2.Controls.SetChildIndex(this.editbtn, 0);
            this.panel2.Controls.SetChildIndex(this.delbtn, 0);
            this.panel2.Controls.SetChildIndex(this.addresstxt, 0);
            this.panel2.Controls.SetChildIndex(this.coursetxt, 0);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(354, 376);
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(155, 376);
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click_1);
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(228, 102);
            this.contacttxt.Size = new System.Drawing.Size(334, 27);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(151, 105);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(151, 158);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(228, 49);
            this.nametxt.Size = new System.Drawing.Size(334, 27);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(151, 52);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(228, 155);
            this.addresstxt.Size = new System.Drawing.Size(334, 52);
            // 
            // banner
            // 
            this.banner.Location = new System.Drawing.Point(174, 32);
            this.banner.Size = new System.Drawing.Size(397, 72);
            this.banner.Text = "Trainee Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaiYogaTraining.Properties.Resources.user_male_icon;
            this.pictureBox1.Location = new System.Drawing.Point(758, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // imgbox
            // 
            this.imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgbox.Location = new System.Drawing.Point(602, 49);
            this.imgbox.Name = "imgbox";
            this.imgbox.Size = new System.Drawing.Size(120, 120);
            this.imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbox.TabIndex = 11;
            this.imgbox.TabStop = false;
            // 
            // datetimectrl
            // 
            this.datetimectrl.Enabled = false;
            this.datetimectrl.Location = new System.Drawing.Point(242, 229);
            this.datetimectrl.Name = "datetimectrl";
            this.datetimectrl.Size = new System.Drawing.Size(200, 27);
            this.datetimectrl.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enroll Date";
            // 
            // idSelector
            // 
            this.idSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idSelector.FormattingEnabled = true;
            this.idSelector.Location = new System.Drawing.Point(534, 279);
            this.idSelector.Name = "idSelector";
            this.idSelector.Size = new System.Drawing.Size(188, 28);
            this.idSelector.TabIndex = 14;
            this.idSelector.SelectedIndexChanged += new System.EventHandler(this.idSelector_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Go to Trainee";
            // 
            // feebtn
            // 
            this.feebtn.Location = new System.Drawing.Point(569, 376);
            this.feebtn.Name = "feebtn";
            this.feebtn.Size = new System.Drawing.Size(113, 30);
            this.feebtn.TabIndex = 16;
            this.feebtn.Text = "Manage Fee";
            this.feebtn.UseVisualStyleBackColor = true;
            this.feebtn.Click += new System.EventHandler(this.feebtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(151, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Course";
            // 
            // coursetxt
            // 
            this.coursetxt.Enabled = false;
            this.coursetxt.Location = new System.Drawing.Point(228, 279);
            this.coursetxt.Name = "coursetxt";
            this.coursetxt.Size = new System.Drawing.Size(214, 27);
            this.coursetxt.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(209)))), ((int)(((byte)(186)))));
            this.panel3.Location = new System.Drawing.Point(594, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 152);
            this.panel3.TabIndex = 20;
            // 
            // TraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 661);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TraineeForm";
            this.Text = "Sai Yoga Training - Trainee Page";
            this.Load += new System.EventHandler(this.TraineeForm_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.banner, 0);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetimectrl;
        private System.Windows.Forms.PictureBox imgbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox idSelector;
        private System.Windows.Forms.Button feebtn;
        private System.Windows.Forms.TextBox coursetxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
    }
}