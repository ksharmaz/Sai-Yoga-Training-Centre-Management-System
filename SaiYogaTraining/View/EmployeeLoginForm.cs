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
        private Employee emp;

        internal Employee Emp
        {
            get{ return emp;}
            set {emp = value;}
        }

        public EmployeeLoginForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            emp = new Employee(s1.SessionID);
            uname.Text = emp.Name;
        }

        private void admissionbtn_MouseHover(object sender, EventArgs e)
        {
            admissionbtn.Text = "Admission Page >>";
        }

        private void admissionbtn_MouseLeave(object sender, EventArgs e)
        {
            admissionbtn.Text = "Admission Page";
        }

        private void admissionbtn_Click(object sender, EventArgs e)
        {
            AdmissionForm admission = new AdmissionForm();
            admission.Show();
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            var course = new CourseForm();
            course.Emp = this.Emp;
            course.Show();
        }

        private void traineebtn_Click(object sender, EventArgs e)
        {
            TraineeForm tfm = new TraineeForm();
            tfm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherForm tfm = new TeacherForm();
            tfm.Show();
        }
    }
}
