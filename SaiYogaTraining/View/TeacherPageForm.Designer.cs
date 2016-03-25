namespace SaiYogaTraining.View
{
    partial class TeacherPageForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.addLogin = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.addLogin);
            this.mainPanel.Controls.Add(this.addBtn);
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // banner
            // 
            this.banner.Size = new System.Drawing.Size(406, 72);
            this.banner.Text = "Teacher Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaiYogaTraining.Properties.Resources.kids_slide;
            this.pictureBox1.Location = new System.Drawing.Point(196, -64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(164, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pay Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(558, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Manage Teacher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(558, 211);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(166, 40);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add Teacher";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addLogin
            // 
            this.addLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLogin.Location = new System.Drawing.Point(164, 211);
            this.addLogin.Name = "addLogin";
            this.addLogin.Size = new System.Drawing.Size(131, 40);
            this.addLogin.TabIndex = 4;
            this.addLogin.Text = "Add Login";
            this.addLogin.UseVisualStyleBackColor = true;
            this.addLogin.Click += new System.EventHandler(this.addLogin_Click);
            // 
            // TeacherPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 481);
            this.Name = "TeacherPageForm";
            this.Text = "Sai Yoga Training - Teacher Page";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button addLogin;
    }
}