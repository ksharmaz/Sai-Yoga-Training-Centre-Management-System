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
            this.Title = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.edit = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(184, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(68, 30);
            this.Title.TabIndex = 1;
            this.Title.Text = "label1";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(186, 74);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(43, 17);
            this.description.TabIndex = 2;
            this.description.Text = "label1";
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(26, 20);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(120, 120);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // edit
            // 
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(343, 170);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(78, 27);
            this.edit.TabIndex = 3;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // del
            // 
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(443, 170);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(78, 27);
            this.del.TabIndex = 4;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.del);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.description);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.logo);
            this.Name = "CourseInfo";
            this.Size = new System.Drawing.Size(556, 224);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button del;
    }
}
