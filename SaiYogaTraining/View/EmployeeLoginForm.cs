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
    public partial class EmployeeLoginForm : FrontLogin
    {
        public EmployeeLoginForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void admissionbtn_Click(object sender, EventArgs e)
        {
            (new AdmissionForm()).Show();
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            (new CourseForm()).Show();
        }

        private void traineebtn_Click(object sender, EventArgs e)
        {
            (new TraineeForm()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new TeacherPageForm()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new AttendencePageForm()).Show();
        }
    }
}
