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
            atd.InitiateAttendence(selectValue.Value, selectValue.Key);
            //FillCombo();
            resultView.DataSource = atd.SelectAttendence();
        }
        private void FillCombo()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Status";
            combo.Name = "combo";
            combo.Items.Add("Absent");
            combo.Items.Add("Present");
            //resultView.Columns.Add(combo);
        }

        private void TakeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.GetConnect();
                for(int i = 0; i < resultView.Rows.Count; i++)
                {
                    var query = @"UPDATE Attendance SET " +
                    "status=" + resultView.Rows[3].Cells["Status"].Value;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exp)
            {

                throw;
            }
            finally
            {
                Connection.CloseConnect();
            }
        }
    }
}
