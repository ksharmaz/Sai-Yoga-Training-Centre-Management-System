namespace SaiYogaTraining.View
{
    partial class AddLoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.cPasstxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cPasstxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.passtxt);
            this.panel2.Controls.Add(this.usertxt);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.createBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Login Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(431, 372);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(106, 36);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "Create Login";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(114, 372);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(93, 36);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // usertxt
            // 
            this.usertxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(220, 89);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(317, 33);
            this.usertxt.TabIndex = 5;
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(220, 171);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '●';
            this.passtxt.Size = new System.Drawing.Size(317, 33);
            this.passtxt.TabIndex = 6;
            // 
            // cPasstxt
            // 
            this.cPasstxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPasstxt.Location = new System.Drawing.Point(220, 251);
            this.cPasstxt.Name = "cPasstxt";
            this.cPasstxt.PasswordChar = '●';
            this.cPasstxt.Size = new System.Drawing.Size(317, 33);
            this.cPasstxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // AddLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 468);
            this.Name = "AddLoginPage";
            this.Text = "Sai Yoga Training - Add Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox cPasstxt;
        private System.Windows.Forms.Label label4;
    }
}