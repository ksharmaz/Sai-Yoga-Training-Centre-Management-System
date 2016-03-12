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
                                  where login.userid.Equals(usrtxt.Text) && login.passwd.Equals(passwdtxt.Text) && login.ltype.Equals(GetRadioName())
                                  select login).FirstOrDefault();

                if (LoginQuery.ltype.Equals("administrator"))
                {
                    this.Close();
                    th = new Thread(OpenAdminForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else if (LoginQuery.ltype.Equals("employees"))
                {
                    //this.Close();
                    //th = new Thread(OpenEmployForm);
                    //th.SetApartmentState(ApartmentState.STA);
                    //th.Start();
                }
                else
                {
                    MessageBox.Show("Invalid Login/Password or Login Type");
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
    }
}
