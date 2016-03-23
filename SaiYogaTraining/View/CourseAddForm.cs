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
        private string cID;

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
            crs = new crs();
            var list = crs.IDList();
            foreach(var lst in list)
            {
                courseID.Items.Add(lst.ToString());
            }
        }

        private void FillData(crs crs)
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
                crs = new crs();
                FillData(crs);
                if(crs.UpdateCourse(cID))
                MessageBox.Show("Data Update Successfull");
            }
            else
                MessageBox.Show("Select data to update");
            
        }

        private void courseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            crs = new crs();
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
            crs = new crs();
            if (crs.Delete(cID))
            {
                MessageBox.Show("Data Deleted");
            }
        }
    }
}
