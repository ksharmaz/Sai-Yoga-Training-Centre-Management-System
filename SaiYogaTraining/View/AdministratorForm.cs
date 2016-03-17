using System;
using SaiYogaTraining.Model;

namespace SaiYogaTraining.View
{
    public partial class AdministratorForm : FrontLogin
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            var emp = new Employee(s1.SessionID);
            uname.Text = emp.Name;
        }
    }
}
