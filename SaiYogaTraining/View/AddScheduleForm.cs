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
    public partial class AddScheduleForm : PopupForm
    {
        public AddScheduleForm()
        {
            InitializeComponent();
        }

        private void AddScheduleForm_Load(object sender, EventArgs e)
        {
            this.datePicker.MaxDate = DateTime.Today.AddDays(7);
            this.datePicker.Value = DateTime.Today;
            crs crs = new crs();
            Dictionary<int, string> dict = crs.CourseList();
            if (dict.Count > 0)
            {
                courseSelect.DataSource = new BindingSource(dict, null);
                courseSelect.DisplayMember = "Value";
                courseSelect.ValueMember = "Key";
                courseSelect.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No Course Available");
            }

            dict = (new Teacher()).ListAll();
            if(dict.Count > 0)
            {
                teacherSelect.DataSource = new BindingSource(dict, null);
                teacherSelect.DisplayMember = "Value";
                teacherSelect.ValueMember = "Key";
                teacherSelect.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No Teacher Available");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Schedule sdle = new Schedule();
            sdle.ClassDate = this.datePicker.Value;
            sdle.ClassTime = this.timePicker.Value;
            sdle.CourseID = this.courseSelect.SelectedValue.ToString();
            sdle.TeacherID = this.teacherSelect.SelectedValue.ToString();

            if (sdle.AddSchedule())
                MessageBox.Show("Schedule Added");
            else
                MessageBox.Show("Something went wrong!");

            this.Close();
        }
    }
}
