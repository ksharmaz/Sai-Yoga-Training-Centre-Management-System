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

namespace SaiYogaTraining.View
{
    public partial class AddLoginPage : PopupForm
    {
        public AddLoginPage()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (cPasstxt.Text.Trim().Equals(passtxt.Text.Trim()))
            {
                (new Login()).CreateLogin(usertxt.Text.Trim(), cPasstxt.Text.Trim());
                MessageBox.Show("Login Created Successfully", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Confirm Password doesn't Match", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cPasstxt.Text = "";
                passtxt.Text = "";
            }
        }
    }
}
