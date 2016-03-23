using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using SaiYogaTraining.View._Partials;
using SaiYogaTraining.Model;

namespace SaiYogaTraining.View
{
    public partial class TraineeForm : DetailForm
    {
        private Trainee tn;
        public TraineeForm()
        {
            InitializeComponent();
        }

        private void idSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            tn = new Trainee();
            tn.GetDetail(int.Parse(idSelector.SelectedItem.ToString()));
            FillData(tn);
        }

        private void TraineeForm_Load(object sender, EventArgs e)
        {
            idSelector.Items.Clear();
            tn = new Trainee();
            var lst = tn.IDList();
            foreach(var ls in lst)
            {
                idSelector.Items.Add(ls.ToString());
            }
            if(lst.Count != 0)
            {
                tn.GetDetail(lst[0]);
                FillData(tn);
                this.idSelector.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No Trainee Record Available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void FillData(Trainee tn)
        {
            this.nametxt.Text = tn.Name;
            this.contacttxt.Text = tn.Contact;
            this.addresstxt.Text = tn.Address;
            MemoryStream ms = new MemoryStream(tn.Photo, 0, tn.Photo.Length);
            ms.Position = 0;
            this.imgbox.Image = Image.FromStream(ms, true);
            this.coursetxt.Text = crs.GetCourseName(tn.CourseID);
            this.datetimectrl.Value = tn.Date;
            
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("Do you want to delete user: " + nametxt.Text, "Confirmation Prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            switch (prompt)
            {
                case DialogResult.OK:
                    if (tn.Delete(tn.ID))
                        MessageBox.Show("Trainee delete successful", "Delete Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Something went wrong!!");
                    break;
                case DialogResult.Cancel:
                    break;
            }
            TraineeForm_Load(this, null);
            
        }

        private void FillFormData()
        {
            tn.Name = this.nametxt.Text.Trim();
            tn.Contact = this.contacttxt.Text.Trim();
            tn.Address = this.addresstxt.Text.Trim();
        }

        private void editbtn_Click_1(object sender, EventArgs e)
        {
            FillFormData();
            if (tn.Update(tn.ID))
                MessageBox.Show("Update Success");
        }

        private void feebtn_Click(object sender, EventArgs e)
        {
            FeePayForm frm = new FeePayForm();
            frm.id = tn.ID;
            frm.formtype = "trainee";
            frm.Show();
        }
    }
}
