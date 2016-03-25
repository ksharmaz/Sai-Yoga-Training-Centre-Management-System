using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaiYogaTraining.Model;
using System.Text.RegularExpressions;

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

        private void courseName_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.courseName, string.Empty);
        }

        private void courseName_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.courseName.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProvider.SetError(this.courseName, "Mandatory Field!");
            }
            e.Cancel = cancel;
        }

        private void courseFee_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.courseFee, string.Empty);
        }

        private void courseFee_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            Match match = Regex.Match(this.courseFee.Text, "^[0-9]*$");
            if (!match.Success || string.IsNullOrEmpty(this.courseFee.Text))
            {
                this.errorProvider.SetError(this.courseFee, "Please enter number between 0 to 9!");
                cancel = true;
            }
            e.Cancel = cancel;
        }
    }
}
