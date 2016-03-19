using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaiYogaTraining.Model;

namespace SaiYogaTraining.View
{
    public partial class CourseInfo : UserControl
    {
        private string courseID;

        public CourseInfo()
        {
            InitializeComponent();
        }

        public string CourseID
        {
            get
            {
                return courseID;
            }

            set
            {
                courseID = value;
            }
        }

        private void detailbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show details");
        }
    }
}
