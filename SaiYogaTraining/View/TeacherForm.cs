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
    public partial class TeacherForm : DetailForm
    {
        Teacher teacher;
        private string tID;

        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            this.qualificationList.SelectedIndex = 0;
            teacher = new Teacher();
            var tlist = teacher.ListAll();
            if (tlist.Count > 0)
            {
                foreach(var item in tlist)
                {
                    teacherIDList.Items.Add(item.Key);
                }
            }
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

        private void addTeacher_Click(object sender, EventArgs e)
        {
            teacher = new Teacher();
            FillData();
            if (teacher.Insert())
            {
                MessageBox.Show("Data Inserted");
            }
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

        private void teacherIDList_SelectedIndexChanged(object sender, EventArgs e)
        { 
            teacher.GetTeacher(teacherIDList.SelectedItem.ToString());
            FillFormData();
        }
    }
}
