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
    public partial class CheckScheduleForm : GlobalForm
    {
        public CheckScheduleForm()
        {
            InitializeComponent();
        }

        private string GetRadioName()
        {
            return radioGroup.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchParam = GetRadioName();
            Schedule sdle = new Schedule();
            if (searchParam.Equals("Course"))
            {
               resultView.DataSource = sdle.GetScheduleByCourse(searchBox.Text.ToString().Trim());

            }
            else if (searchParam.Equals("Teacher"))
            {
               resultView.DataSource = sdle.GetScheduleByTeacher(searchBox.Text.ToString().Trim());
            }
            searchPanel.Visible = true;
        }
    }
}
