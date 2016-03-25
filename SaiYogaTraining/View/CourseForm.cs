using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaiYogaTraining.Model;

namespace SaiYogaTraining.View
{
    public partial class CourseForm : GlobalForm
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            CourseAddForm crs = new CourseAddForm();
            crs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new AddScheduleForm()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new CheckScheduleForm()).Show();
        }
    }
}
