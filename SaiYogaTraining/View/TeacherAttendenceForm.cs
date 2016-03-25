using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SaiYogaTraining.Model;

namespace SaiYogaTraining.View
{
    public partial class TeacherAttendenceForm : GlobalForm
    {
        public TeacherAttendenceForm()
        {
            InitializeComponent();
        }

        private void initBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < resultView.RowCount; i++)
            {
                (new TeacherAttendence()).UpdateAttendence(resultView.Rows[i].Cells[2].Value.ToString(), resultView.Rows[i].Cells[0].Value.ToString());
            }
            MessageBox.Show("Attendance Record Filled");
        }

        private void TeacherAttendenceForm_Load(object sender, EventArgs e)
        {
            TeacherAttendence tad = new TeacherAttendence();
            if (tad.InitiateAttendence())
            {
                resultView.Update();
                resultView.Sort(this.srnoDataGridViewTextBoxColumn, ListSortDirection.Descending);
                resultPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Something, Went Wrong!!");
                this.Close();
            }
            // TODO: This line of code loads data into the 'saiYogaDBDataSet.TeacherAttendance' table. You can move, or remove it, as needed.
            this.teacherAttendanceTableAdapter.Fill(this.saiYogaDBDataSet.TeacherAttendance);

        }

        private void hrsBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < resultView.RowCount; i++)
            {
                (new TeacherAttendence()).UpdateHourPerDay(resultView.Rows[i].Cells[4].Value.ToString(), resultView.Rows[i].Cells[0].Value.ToString());
            }
            MessageBox.Show("Hours Per Day Added");
        }
    }
}
