using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaiYogaTraining.Model;
using SaiYogaTraining.View._Partials;
using System.Text.RegularExpressions;

namespace SaiYogaTraining.View
{
    public partial class SalaryPayForm : PopupForm
    {
        Salary slr;
        public SalaryPayForm()
        {
            InitializeComponent();
        }

        private void SalaryPayForm_Load(object sender, EventArgs e)
        {
            var teach = new Teacher();
            var dict = teach.ListAll();
            if(dict.Count > 0)
            {
                teacherSelect.DataSource = new BindingSource(dict, null);
                teacherSelect.DisplayMember = "Value";
                teacherSelect.ValueMember = "Key";
            }
            else
            {
                MessageBox.Show("No Teacher Available");
            }
        }

        private void teacherSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalhrstxt.Text = "";
            chrgtxt.Text = "";
            KeyValuePair<int, string> selectEntry = (KeyValuePair<int, string>)teacherSelect.SelectedItem;
            string tID = selectEntry.Key.ToString();
            idtxt.Text = tID;
            slr = new Salary();
            slr.CalculateTotalHrs(tID);
            totalhrstxt.Text = slr.TotalNoHrs.ToString();
        }

        private void chrgtxt_TextChanged(object sender, EventArgs e)
        {
            string s = chrgtxt.Text;
            if (string.IsNullOrEmpty(s))
                s = "0";
            slr.ChargesPerHrs = int.Parse(s);
            totaltxt.Text = slr.CalculateTotal().ToString();
            paybtn.Enabled = true;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            Salary slr = new Salary();
            slr.ChargesPerHrs = int.Parse(chrgtxt.Text.ToString().Trim());
            slr.TotalNoHrs = int.Parse(totalhrstxt.Text.ToString().Trim());
            slr.Total = int.Parse(totaltxt.Text.ToString().Trim());
            slr.TeacherID = idtxt.Text.ToString().Trim();

            if (slr.Insert())
                MessageBox.Show("Data Inserted");
            else
                MessageBox.Show("Something went wrong");
            this.Close();
        }

        private void chrgtxt_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.chrgtxt, string.Empty);
        }

        private void chrgtxt_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            Match match = Regex.Match(this.chrgtxt.Text, "^[0-9]*$");
            if (!match.Success || string.IsNullOrEmpty(this.chrgtxt.Text))
            {
                this.errorProvider.SetError(this.chrgtxt, "Please enter number between 0 to 9!");
                cancel = true;
            }
            e.Cancel = cancel;
        }
    }
}
