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
    public partial class CourseAddForm : GlobalForm
    {
        private crs crs;

        public CourseAddForm()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            crs = new crs();
            FillData(crs);
            bool insert = crs.AddCourse();
            if (insert)
                MessageBox.Show("Data Inserted");
        }

        private void CourseAddForm_Load(object sender, EventArgs e)
        {
            this.courseDuration.SelectedIndex = 0;
            this.courseType.SelectedIndex = 0;
        }

        private void FillData(crs crs)
        {
            crs.CourseName = this.courseName.Text.Trim();
            crs.Duration = this.courseDuration.SelectedItem.ToString().Trim();
            crs.CType = this.courseType.SelectedItem.ToString().Trim();
            crs.Benefits = this.courseBenefits.Text.Trim();
            crs.Fee = int.Parse(this.courseFee.Text.Trim());
        }
    }
}
