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
    public partial class AttendencePageForm : GlobalForm
    {
        public AttendencePageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new TeacherAttendenceForm()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new TraineeAttendenceForm()).Show();
        }
    }
}
