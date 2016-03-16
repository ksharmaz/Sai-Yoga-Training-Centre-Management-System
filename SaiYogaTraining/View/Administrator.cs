using System;
using SaiYogaTraining.Model;

namespace SaiYogaTraining.View
{
    public partial class Administrator : FrontLogin
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            var emp = new Employee(s1.sessionID);
            uname.Text = emp.Name;
        }
    }
}
