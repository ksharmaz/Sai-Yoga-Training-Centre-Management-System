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
    public partial class TeacherAddForm : DetailForm
    {
        Teacher teacher;
        private string tID;

        public TeacherAddForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            this.qualificationList.SelectedIndex = 0;
        }

        private void FillData()
        {
            teacher.Name = nametxt.Text.Trim();
            teacher.Phone = contacttxt.Text.Trim();
            teacher.Qualification = qualificationList.SelectedItem.ToString();
            teacher.Address = addresstxt.Text.Trim();
        }

        private void addTeacher_Click(object sender, EventArgs e)
        {
            teacher = new Teacher();
            FillData();
            if (teacher.Insert())
            {
                MessageBox.Show("Teacher Added Successfully", "Teacher Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            tID = teacher.TeacherID;
        }
    }
}
