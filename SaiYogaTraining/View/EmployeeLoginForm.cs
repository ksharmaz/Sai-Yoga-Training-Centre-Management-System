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
            var emp = new Employee(s1.SessionID);
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
    }
}
