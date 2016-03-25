using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaiYogaTraining.View
{
    public partial class TeacherPageForm : GlobalForm
    {
        public TeacherPageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new SalaryPayForm()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new TeacherEditForm()).Show();
        }

        private void addLogin_Click(object sender, EventArgs e)
        {
            (new AddLoginPage()).Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            (new TeacherAddForm()).Show();
        }
    }
}
