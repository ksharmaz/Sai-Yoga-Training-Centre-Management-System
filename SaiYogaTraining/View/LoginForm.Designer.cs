namespace SaiYogaTraining.View
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usrlbl = new System.Windows.Forms.Label();
            this.passwdlbl = new System.Windows.Forms.Label();
            this.usrtxt = new System.Windows.Forms.TextBox();
            this.passwdtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.loginbtn);
            this.mainPanel.Controls.Add(this.passwdtxt);
            this.mainPanel.Controls.Add(this.usrtxt);
            this.mainPanel.Controls.Add(this.passwdlbl);
            this.mainPanel.Controls.Add(this.usrlbl);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(-16, 135);
            this.mainPanel.Size = new System.Drawing.Size(1104, 563);
            // 
            // banner
            // 
            this.banner.Location = new System.Drawing.Point(186, 30);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaiYogaTraining.Properties.Resources.keyring_icon;
            this.pictureBox1.Location = new System.Drawing.Point(673, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // usrlbl
            // 
            this.usrlbl.AutoSize = true;
            this.usrlbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrlbl.Location = new System.Drawing.Point(175, 120);
            this.usrlbl.Name = "usrlbl";
            this.usrlbl.Size = new System.Drawing.Size(106, 30);
            this.usrlbl.TabIndex = 2;
            this.usrlbl.Text = "Username";
            // 
            // passwdlbl
            // 
            this.passwdlbl.AutoSize = true;
            this.passwdlbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdlbl.Location = new System.Drawing.Point(175, 201);
            this.passwdlbl.Name = "passwdlbl";
            this.passwdlbl.Size = new System.Drawing.Size(99, 30);
            this.passwdlbl.TabIndex = 3;
            this.passwdlbl.Text = "Password";
            // 
            // usrtxt
            // 
            this.usrtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usrtxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrtxt.Location = new System.Drawing.Point(308, 126);
            this.usrtxt.Name = "usrtxt";
            this.usrtxt.Size = new System.Drawing.Size(211, 27);
            this.usrtxt.TabIndex = 4;
            // 
            // passwdtxt
            // 
            this.passwdtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwdtxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdtxt.Location = new System.Drawing.Point(308, 207);
            this.passwdtxt.Name = "passwdtxt";
            this.passwdtxt.PasswordChar = '●';
            this.passwdtxt.Size = new System.Drawing.Size(211, 27);
            this.passwdtxt.TabIndex = 5;
            this.passwdtxt.UseSystemPasswordChar = true;
            // 
            // loginbtn
            // 
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(353, 298);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(100, 37);
            this.loginbtn.TabIndex = 7;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 643);
            this.Name = "LoginForm";
            this.Text = "Sai Yoga Training Centre - Login Form";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usrlbl;
        private System.Windows.Forms.TextBox passwdtxt;
        private System.Windows.Forms.TextBox usrtxt;
        private System.Windows.Forms.Label passwdlbl;
        private System.Windows.Forms.Button loginbtn;
    }
}