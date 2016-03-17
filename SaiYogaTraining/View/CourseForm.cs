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
        private Employee emp;

        internal Employee Emp
        {
            get { return emp; }
            set { emp = value; }
        }
        public CourseForm()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            if (Emp.Type.Equals("employee"))
            {
                addCourseBtn.Enabled = false;
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
