using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaiYogaTraining.Model;
using SaiYogaTraining.View._Partials;

namespace SaiYogaTraining.View
{
    public partial class TeacherEditForm : DetailForm
    {
        Teacher teacher;
        private string tID;

        public TeacherEditForm()
        {
            InitializeComponent();
        }

        private void TeacherEditForm_Load(object sender, EventArgs e)
        {
            this.qualificationList.SelectedIndex = 0;
            teacher = new Teacher();
            var dict = teacher.ListAll();
            if(dict.Count == 0)
            {
                MessageBox.Show("No Teacher to Manage");
                this.Close();
            }
            teachertxt.DataSource = new BindingSource(dict, null);
            teachertxt.ValueMember = "Key";
            teachertxt.DisplayMember = "Value";
        }

        private void FillData()
        {
            teacher.Name = nametxt.Text.Trim();
            teacher.Phone = contacttxt.Text.Trim();
            teacher.Qualification = qualificationList.SelectedItem.ToString();
            teacher.Address = addresstxt.Text.Trim();
        }

        private void FillFormData()
        {
            nametxt.Text = teacher.Name;
            contacttxt.Text = teacher.Phone;
            qualificationList.SelectedItem = teacher.Qualification;
            addresstxt.Text = teacher.Address;
            tID = teacher.TeacherID;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            teacher = new Teacher();
            FillData();
            if (teacher.Update(tID))
                MessageBox.Show("Data Updated");
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (teacher.Delete(tID))
                MessageBox.Show("Delete Successful");
        }

        private void teachertxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectValue = (KeyValuePair<int, string>)teachertxt.SelectedItem;
            tID = selectValue.Key.ToString();
            teacherIDList.Text = tID;
            teacher = new Teacher();
            teacher.GetTeacher(tID);
            FillFormData();
        }
    }
}
