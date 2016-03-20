using System;
using SaiYogaTraining.Model;

namespace SaiYogaTraining.View
{
    public partial class AdministratorForm : FrontLogin
    {
        Employee emp;
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            emp = new Employee(s1.SessionID);
            uname.Text = emp.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseForm crs = new CourseForm();
            crs.Emp = this.emp;
            crs.Show();
        }
    }
}
