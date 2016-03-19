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
    public partial class CourseForm : GlobalForm
    {
        private Employee emp;

        internal Employee Emp
        {
            get { return emp; }
            set { emp = value; }
        }
        public CourseForm()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            if (Emp.Type.Equals("employee"))
            {
                addCourseBtn.Enabled = false;
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Course crs = new Course();
            DataSet dr = crs.SearchAll(courseSearch.Text.Trim());
            if(dr.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Data Found","Search Result",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<CourseInfo> list = new List<CourseInfo>();
                if (list.Count > 0)
                    list.Clear();

                foreach (DataTable table in dr.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        var infoctrl = new CourseInfo();
                        infoctrl.CourseID = row["course_id"].ToString();
                        infoctrl.Title.Text = row["course_name"].ToString();
                        infoctrl.Description.Text = string.IsNullOrEmpty(row["benefits"].ToString()) ? "No Description" : row["benefits"].ToString();
                        //infoctrl.Logo.Image = row["image"];
                        //infoctrl = null;
                        //TODO: add control functionality
                        list.Add(infoctrl);
                    }
                }
                int yaxis = 20;
                searchResult.Visible = true;
                searchResult.AutoScroll = true;
                searchResult.Controls.Clear();
                foreach(var lst in list)
                {
                    int X = 100;
                    int Y = yaxis;
                    lst.Location = new Point(X, Y);
                    searchResult.Controls.Add(lst);
                    yaxis = int.Parse(lst.Location.Y.ToString()) + 220;
                }
                
            }
            
        }
    }
}
