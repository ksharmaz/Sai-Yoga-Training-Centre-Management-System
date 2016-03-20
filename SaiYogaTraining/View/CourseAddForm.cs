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
        private Course crs;
        private string cID;

        public CourseAddForm()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            crs = new Course();
            FillData(crs);
            bool insert = crs.AddCourse();
            if (insert)
                MessageBox.Show("Data Inserted");
        }

        private void CourseAddForm_Load(object sender, EventArgs e)
        {
            this.courseDuration.SelectedIndex = 0;
            this.courseType.SelectedIndex = 0;
            crs = new Course();
            var list = crs.IDList();
            foreach(var lst in list)
            {
                courseID.Items.Add(lst.ToString());
            }
        }

        private void FillData(Course crs)
        {
            crs.CourseName = this.courseName.Text;
            crs.Duration = this.courseDuration.SelectedItem.ToString();
            crs.CType = this.courseType.SelectedItem.ToString();
            crs.Benefits = this.courseBenefits.Text;
            crs.Fee = int.Parse(this.courseFee.Text);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(crs.CourseID))
            {
                crs = new Course();
                FillData(crs);
                if(crs.UpdateCourse(cID))
                MessageBox.Show("Data Update Successfull");
            }
            else
                MessageBox.Show("Select data to update");
            
        }

        private void courseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            crs = new Course();
            crs.GetDetail(courseID.SelectedItem.ToString());
            FillFormData();
            cID = courseID.SelectedItem.ToString();
        }

        private void FillFormData()
        {
            this.courseName.Text = crs.CourseName;
            this.courseDuration.SelectedItem = crs.Duration;
            this.courseType.SelectedItem = crs.CType;
            this.courseBenefits.Text = crs.Benefits;
            this.courseFee.Text = crs.Fee.ToString();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            crs = new Course();
            if (crs.Delete(cID))
            {
                MessageBox.Show("Data Deleted");
            }
        }
    }
}
