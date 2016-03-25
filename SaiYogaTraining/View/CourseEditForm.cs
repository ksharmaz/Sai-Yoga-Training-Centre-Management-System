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
    public partial class CourseEditForm : GlobalForm
    {
        private crs crs;
        private string cID;

        public CourseEditForm()
        {
            InitializeComponent();
        }

        private void CourseAddForm_Load(object sender, EventArgs e)
        {
            crs = new crs();
            this.courseDuration.SelectedIndex = 0;
            this.courseType.SelectedIndex = 0;
            Dictionary<int,string> dict = crs.CourseList();
            this.coursetxt.DataSource = new BindingSource(dict, null);
            coursetxt.DisplayMember = "Value";
            coursetxt.ValueMember = "Key";
            crs.GetDetail(cID);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(crs.CourseID))
            {
                crs = new crs();
                FillData(crs);
                if(crs.UpdateCourse(cID))
                MessageBox.Show("Data Updated Successfully", "Course Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Select data to update", "Course Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        #region Helper Methods
        private void FillData(crs crs)
        {
            crs.CourseName = this.courseName.Text.Trim();
            crs.Duration = this.courseDuration.SelectedItem.ToString().Trim();
            crs.CType = this.courseType.SelectedItem.ToString().Trim();
            crs.Benefits = this.courseBenefits.Text.Trim();
            crs.Fee = int.Parse(this.courseFee.Text.Trim());
        }

        private void FillFormData()
        {
            this.courseName.Text = crs.CourseName;
            this.courseDuration.SelectedItem = crs.Duration;
            this.courseType.SelectedItem = crs.CType;
            this.courseBenefits.Text = crs.Benefits;
            this.courseFee.Text = crs.Fee.ToString();
        }
        #endregion

        private void delbtn_Click(object sender, EventArgs e)
        {
            crs = new crs();
            if (crs.Delete(cID))
            {
                MessageBox.Show("Data Deleted Successfully", "Course Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void coursetxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectValue = (KeyValuePair<int, string>)coursetxt.SelectedItem;
            cID = selectValue.Key.ToString();
            this.courseID.Text = cID;
            crs.GetDetail(cID);
            FillFormData();
        }
    }
}
