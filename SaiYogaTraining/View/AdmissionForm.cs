using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using SaiYogaTraining.Model;
using System.Text.RegularExpressions;

namespace SaiYogaTraining.View
{
    public partial class AdmissionForm : GlobalForm
    {
        private byte[] image = null;

        public AdmissionForm()
        {
            InitializeComponent();
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opfd.FileName);
                image = UploadImage(img);
                if (image == null)
                {
                    MessageBox.Show("Image Upload Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    uploadtick.Image = SaiYogaTraining.Properties.Resources.sign_error_icon;
                }
                uploadtick.Visible = true;
            }
        }

        private void proceedbtn_Click(object sender, EventArgs e)
        {
            Trainee tn = new Trainee();
            if(image == null)
            {
                Image img = global::SaiYogaTraining.Properties.Resources._default;
                image = UploadImage(img);
            }
            tn.Photo = image;
            string tname = String.Concat(tnamef.Text.Trim(), " ", tnamel.Text.Trim());
            tn.Name = tname.Trim();
            tn.Address = taddress.Text.Trim();
            tn.Contact = tcontact.Text.Trim();
            tn.CourseID = coursedrop.SelectedValue.ToString();
            tn.Date = DateTime.Today;
            if (tn.Insert())
            {
                MessageBox.Show("Data Inserted");
                this.Close();
                TraineeForm tnf = new TraineeForm();
                tnf.Show();
            }
            else
                MessageBox.Show("Something went wrong");
        }

        #region From Validation Code

        private void tnamef_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.tnamef.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProvider.SetError(this.tnamef, "Mandatory Field!");
            }
            e.Cancel = cancel;
        }

        private void tnamef_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.tnamef, string.Empty);
        }

        private void taddress_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.taddress.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProvider.SetError(this.taddress, "Mandatory Field!");
            }
            e.Cancel = cancel;
        }

        private void taddress_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.taddress, string.Empty);
        }

        private void tcontact_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            Match match = Regex.Match(this.tcontact.Text, "^[0-9]*$");
            if (!match.Success || string.IsNullOrEmpty(this.tcontact.Text))
            {
                this.errorProvider.SetError(this.tcontact, "Please enter number between 0 to 9!");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void tcontact_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.tcontact, string.Empty);
        }
        #endregion

        private void AdmissionForm_Load(object sender, EventArgs e)
        {
            var dict = Course.CourseList();
            coursedrop.DataSource = new BindingSource(dict, null);
            coursedrop.DisplayMember = "Value";
            coursedrop.ValueMember = "Key";
            coursedrop.SelectedIndex = 0;
        }

        private byte[] UploadImage(Image img)
        {
            MemoryStream tmpStream = new MemoryStream();
            img.Save(tmpStream, img.RawFormat);
            tmpStream.Seek(0, SeekOrigin.Begin);
            byte[] imgbyte = new byte[tmpStream.Length];
            tmpStream.Read(imgbyte, 0, (int)tmpStream.Length);
            return imgbyte;
        }
    }
}
