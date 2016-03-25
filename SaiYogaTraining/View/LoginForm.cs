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
            bool isLogin = log.ValidateLogin(usrtxt.Text, passwdtxt.Text);
            if (isLogin)
            {
                s1 = new Session(log.loginID);
                if (s1.hasSession())
                {
                    this.Close();
                    CreateNewForm(OpenEmployForm);
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

        #region Private Helper Methods

        private void CreateNewForm(ThreadStart formName)
        {
            this.Close();
            th = new Thread(formName);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenEmployForm()
        {
            var employ = new EmployeeLoginForm();
            employ.s1 = s1;
            Application.Run(employ);
        }
        #endregion
    }
}
