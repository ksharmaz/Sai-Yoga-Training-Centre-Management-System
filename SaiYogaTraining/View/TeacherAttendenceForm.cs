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
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE TeacherAttendance SET status=@status, hrs_per_day=@hrs_per_day", Connection.GetConnect());
                foreach (DataGridViewRow row in resultView.Rows)
                {
                    cmd.Parameters.AddWithValue("@status", statusDataGridViewTextBoxColumn.DisplayMember);
                    cmd.Parameters.AddWithValue("@hrs_per_day", hrsperdayDataGridViewTextBoxColumn.Displayed);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Records inserted.");
            }
            catch (Exception)
            {
                Console.Write("Error Occured");
            }
            finally
            {
                Connection.CloseConnect();
            }
            
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
    }
}
