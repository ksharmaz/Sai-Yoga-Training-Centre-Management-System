using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using SaiYogaTraining.Model;
using SaiYogaTraining.View._Partials;

namespace SaiYogaTraining.View
{
    public partial class TraineeAttendenceForm : GlobalForm
    {
        public TraineeAttendenceForm()
        {
            InitializeComponent();
        }

        private void TraineeAttendenceForm_Load(object sender, EventArgs e)
        {
            Schedule sdl = new Schedule();
            courseTrainee.DataSource = new BindingSource(sdl.GetList(), null);
            courseTrainee.DisplayMember = "Value";
            courseTrainee.ValueMember = "Key";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> selectValue = (KeyValuePair<string, string>)courseTrainee.SelectedValue;
            Attendence atd = new Attendence();
            bool trainee = atd.InitiateAttendence(selectValue.Value, selectValue.Key);
            resultView.DataSource = atd.SelectAttendence();
            if (!trainee)
                MessageBox.Show("No Trainee for this Course");
            resultPanel.Visible = true;
        }

        private void TakeBtn_Click(object sender, EventArgs e)
        {
            this.selectBtn.Enabled = false;
            for(int i=0; i<resultView.RowCount;i++)
            {
                (new Attendence()).UpdateAttendence(resultView.Rows[i].Cells[0].Value.ToString(),resultView.Rows[i].Cells[1].Value.ToString());
            }
            MessageBox.Show("Attendance Record Filled");
        }
    }
}
