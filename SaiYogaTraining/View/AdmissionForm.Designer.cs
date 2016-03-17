namespace SaiYogaTraining.View
{
    partial class AdmissionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmissionForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admissionPanel = new System.Windows.Forms.Panel();
            this.uploadtick = new System.Windows.Forms.PictureBox();
            this.proceedbtn = new System.Windows.Forms.Button();
            this.coursedrop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.tcontact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.taddress = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tnamel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tnamef = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.admissionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadtick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.admissionPanel);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Size = new System.Drawing.Size(1104, 671);
            // 
            // banner
            // 
            this.banner.Location = new System.Drawing.Point(184, 33);
            this.banner.Size = new System.Drawing.Size(503, 72);
            this.banner.Text = "Admission Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaiYogaTraining.Properties.Resources.profile_group_icon;
            this.pictureBox1.Location = new System.Drawing.Point(739, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Trainee Admission Form";
            // 
            // admissionPanel
            // 
            this.admissionPanel.BackColor = System.Drawing.SystemColors.Window;
            this.admissionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admissionPanel.Controls.Add(this.uploadtick);
            this.admissionPanel.Controls.Add(this.proceedbtn);
            this.admissionPanel.Controls.Add(this.coursedrop);
            this.admissionPanel.Controls.Add(this.label5);
            this.admissionPanel.Controls.Add(this.uploadbtn);
            this.admissionPanel.Controls.Add(this.tcontact);
            this.admissionPanel.Controls.Add(this.label4);
            this.admissionPanel.Controls.Add(this.taddress);
            this.admissionPanel.Controls.Add(this.label3);
            this.admissionPanel.Controls.Add(this.tnamel);
            this.admissionPanel.Controls.Add(this.label2);
            this.admissionPanel.Controls.Add(this.tnamef);
            this.admissionPanel.Controls.Add(this.lbl);
            this.admissionPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionPanel.Location = new System.Drawing.Point(91, 62);
            this.admissionPanel.Name = "admissionPanel";
            this.admissionPanel.Size = new System.Drawing.Size(753, 519);
            this.admissionPanel.TabIndex = 1;
            // 
            // uploadtick
            // 
            this.uploadtick.Enabled = false;
            this.uploadtick.Image = global::SaiYogaTraining.Properties.Resources.sign_check_icon;
            this.uploadtick.Location = new System.Drawing.Point(575, 285);
            this.uploadtick.Name = "uploadtick";
            this.uploadtick.Size = new System.Drawing.Size(23, 22);
            this.uploadtick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uploadtick.TabIndex = 13;
            this.uploadtick.TabStop = false;
            this.uploadtick.Visible = false;
            // 
            // proceedbtn
            // 
            this.proceedbtn.Location = new System.Drawing.Point(295, 437);
            this.proceedbtn.Name = "proceedbtn";
            this.proceedbtn.Size = new System.Drawing.Size(134, 29);
            this.proceedbtn.TabIndex = 11;
            this.proceedbtn.Text = "Proceed";
            this.proceedbtn.UseVisualStyleBackColor = true;
            this.proceedbtn.Click += new System.EventHandler(this.proceedbtn_Click);
            // 
            // coursedrop
            // 
            this.coursedrop.FormattingEnabled = true;
            this.coursedrop.Location = new System.Drawing.Point(225, 351);
            this.coursedrop.Name = "coursedrop";
            this.coursedrop.Size = new System.Drawing.Size(373, 28);
            this.coursedrop.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select Course*";
            // 
            // uploadbtn
            // 
            this.uploadbtn.Location = new System.Drawing.Point(435, 283);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(134, 29);
            this.uploadbtn.TabIndex = 8;
            this.uploadbtn.Text = "Upload Image";
            this.uploadbtn.UseVisualStyleBackColor = true;
            this.uploadbtn.Click += new System.EventHandler(this.uploadbtn_Click);
            // 
            // tcontact
            // 
            this.tcontact.Location = new System.Drawing.Point(195, 285);
            this.tcontact.Name = "tcontact";
            this.tcontact.Size = new System.Drawing.Size(134, 27);
            this.tcontact.TabIndex = 7;
            this.tcontact.Validating += new System.ComponentModel.CancelEventHandler(this.tcontact_Validating);
            this.tcontact.Validated += new System.EventHandler(this.tcontact_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact*";
            // 
            // taddress
            // 
            this.taddress.Location = new System.Drawing.Point(195, 121);
            this.taddress.Name = "taddress";
            this.taddress.Size = new System.Drawing.Size(403, 126);
            this.taddress.TabIndex = 5;
            this.taddress.Text = "";
            this.taddress.Validating += new System.ComponentModel.CancelEventHandler(this.taddress_Validating);
            this.taddress.Validated += new System.EventHandler(this.taddress_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address*";
            // 
            // tnamel
            // 
            this.tnamel.Location = new System.Drawing.Point(464, 46);
            this.tnamel.Name = "tnamel";
            this.tnamel.Size = new System.Drawing.Size(134, 27);
            this.tnamel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // tnamef
            // 
            this.tnamef.Location = new System.Drawing.Point(195, 46);
            this.tnamef.Name = "tnamef";
            this.tnamef.Size = new System.Drawing.Size(134, 27);
            this.tnamef.TabIndex = 1;
            this.tnamef.Validating += new System.ComponentModel.CancelEventHandler(this.tnamef_Validating);
            this.tnamef.Validated += new System.EventHandler(this.tnamef_Validated);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(91, 49);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(90, 20);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "First Name*";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // AdmissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 760);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdmissionForm";
            this.Text = "Sai Yoga Training - Admission";
            this.Controls.SetChildIndex(this.banner, 0);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.admissionPanel.ResumeLayout(false);
            this.admissionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadtick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel admissionPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox taddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tnamel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tnamef;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tcontact;
        private System.Windows.Forms.ComboBox coursedrop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.Button proceedbtn;
        private System.Windows.Forms.PictureBox uploadtick;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}