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
        Session s1;

        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            LoginModel log = new LoginModel();
            bool isLogin = log.ValidateLogin(usrtxt.Text, passwdtxt.Text, GetRadioName());
            if (isLogin)
            {
                s1 = new Session(log.GetLoginID());
                if (s1.hasSession())
                {
                    if (log.GetLoginType().Equals("administrator"))
                        CreateNewForm(OpenAdminForm);
                    else if (log.GetLoginType().Equals("employee") || log.GetLoginType().Equals("teacher"))
                    {
                        if (log.GetLoginType().Equals("teacher"))
                            Console.WriteLine(); //TODO: Teacher form
                        else
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
            var admin = new Administrator();
            admin.s1 = s1;
            Application.Run(admin);
        }

        private void OpenEmployForm()
        {
            throw new NotImplementedException();
        }

        private string GetRadioName()
        {
            return typegrp.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
        }

        #endregion
    }
}
