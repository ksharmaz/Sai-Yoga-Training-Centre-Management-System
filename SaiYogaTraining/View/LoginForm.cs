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
    public partial class LoginForm : GlobalForm
    {
        Thread th;
        Session s1;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            bool isLogin = log.ValidateLogin(usrtxt.Text, passwdtxt.Text, GetRadioName());
            if (isLogin)
            {
                s1 = new Session(log.loginID);
                if (s1.hasSession())
                {
                    if (log.loginType.Equals("administrator"))
                        CreateNewForm(OpenAdminForm);
                    else if (log.loginType.Equals("employee"))
                    {
                            CreateNewForm(OpenEmployForm);
                    }
                        
                }
                else
                {
                    MessageBox.Show("Something Went Wrong !! Please Relogin", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Invalid Login/Password or Login Type", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("TODO: Show Change Password Form");
        }

        #region Private Helper Methods

        private void CreateNewForm(ThreadStart formName)
        {
            this.Close();
            th = new Thread(formName);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenAdminForm()
        {
            var admin = new AdministratorForm();
            admin.s1 = s1;
            Application.Run(admin);
        }

        private void OpenEmployForm()
        {
            var employ = new EmployeeLoginForm();
            employ.s1 = s1;
            Application.Run(employ);
        }

        private string GetRadioName()
        {
            return typegrp.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
        }

        #endregion
    }
}
