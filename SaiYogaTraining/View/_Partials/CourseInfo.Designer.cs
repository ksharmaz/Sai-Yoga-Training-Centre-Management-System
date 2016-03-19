using System.Windows.Forms;

namespace SaiYogaTraining.View
{
    partial class CourseInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.detailbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(170, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(66, 30);
            this.title.TabIndex = 1;
            this.title.Text = "label1";
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(12, 13);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(120, 120);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.Window;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Black;
            this.description.Location = new System.Drawing.Point(156, 47);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(332, 86);
            this.description.TabIndex = 5;
            this.description.Text = "";
            // 
            // detailbtn
            // 
            this.detailbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailbtn.Location = new System.Drawing.Point(374, 149);
            this.detailbtn.Name = "detailbtn";
            this.detailbtn.Size = new System.Drawing.Size(114, 27);
            this.detailbtn.TabIndex = 4;
            this.detailbtn.Text = "View Detail";
            this.detailbtn.UseVisualStyleBackColor = true;
            this.detailbtn.Click += new System.EventHandler(this.detailbtn_Click);
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.description);
            this.Controls.Add(this.detailbtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.logo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CourseInfo";
            this.Size = new System.Drawing.Size(500, 200);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label title;
        private RichTextBox description;
        private Button detailbtn;

        public PictureBox Logo
        {
            get
            {
                return logo;
            }

            set
            {
                logo = value;
            }
        }

        public Label Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public RichTextBox Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public Button Detailbtn
        {
            get
            {
                return detailbtn;
            }

            set
            {
                detailbtn = value;
            }
        }
    }
}
