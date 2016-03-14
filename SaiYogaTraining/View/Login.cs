using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SaiYogaTraining.Model;

namespace SaiYogaTraining.View
{
    public partial class Login : GlobalForm
    {
        Thread th;

        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaiYogaDBDataContext dbcontext = new SaiYogaDBDataContext();
                var LoginQuery = (from login in dbcontext.Logins
                                  where login.userid.Equals(usrtxt.Text) && login.passwd.Equals(passwdtxt.Text)
                                  select login).FirstOrDefault();

                if(LoginQuery != null)
                {
                    //if (LoginQuery.ltype.Equals("administrator"))
                    //{
                    //    this.Close();
                    //    th = new Thread(OpenAdminForm);
                    //    th.SetApartmentState(ApartmentState.STA);
                    //    th.Start();
                    //}
                    //else if (LoginQuery.ltype.Equals("employee"))
                    //{
                    //    //this.Close();
                    //    //th = new Thread(OpenEmployForm);
                    //    //th.SetApartmentState(ApartmentState.STA);
                    //    //th.Start();
                    //}
                    MessageBox.Show("TODO");
                }
                else
                {
                    MessageBox.Show("Invalid Login/Password or Login Type", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("Database Connection Error: " + exp.Message);
            }
        }

        private void OpenAdminForm()
        {
            Application.Run(new Course());
        }

        private string GetRadioName()
        {
            return typegrp.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("TODO: Show Change Password Form");
        }
    }
}
