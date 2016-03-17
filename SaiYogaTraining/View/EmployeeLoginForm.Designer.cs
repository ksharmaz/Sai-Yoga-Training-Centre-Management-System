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
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 23);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.admissionbtn);
            this.mainPanel.Controls.SetChildIndex(this.button1, 0);
            this.mainPanel.Controls.SetChildIndex(this.uname, 0);
            this.mainPanel.Controls.SetChildIndex(this.admissionbtn, 0);
            this.mainPanel.Controls.SetChildIndex(this.label2, 0);
            // 
            // banner
            // 
            this.banner.Size = new System.Drawing.Size(490, 72);
            this.banner.Text = "Employees Page";
            // 
            // admissionbtn
            // 
            this.admissionbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionbtn.Location = new System.Drawing.Point(290, 123);
            this.admissionbtn.Name = "admissionbtn";
            this.admissionbtn.Size = new System.Drawing.Size(320, 46);
            this.admissionbtn.TabIndex = 3;
            this.admissionbtn.Text = "Admission Page";
            this.admissionbtn.UseVisualStyleBackColor = true;
            this.admissionbtn.Click += new System.EventHandler(this.admissionbtn_Click);
            this.admissionbtn.MouseLeave += new System.EventHandler(this.admissionbtn_MouseLeave);
            this.admissionbtn.MouseHover += new System.EventHandler(this.admissionbtn_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Go To";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button admissionbtn;
    }
}