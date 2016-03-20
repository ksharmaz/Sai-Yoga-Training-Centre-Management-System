namespace SaiYogaTraining.View
{
    partial class AdministratorForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(199, 27);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Controls.SetChildIndex(this.label1, 0);
            this.mainPanel.Controls.SetChildIndex(this.uname, 0);
            this.mainPanel.Controls.SetChildIndex(this.button1, 0);
            this.mainPanel.Controls.SetChildIndex(this.button2, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 640);
            this.Name = "AdministratorForm";
            this.Text = "Sai Yoga Training - Admin Page";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
    }
}