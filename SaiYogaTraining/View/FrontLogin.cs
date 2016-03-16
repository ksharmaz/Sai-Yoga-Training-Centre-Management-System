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
    public partial class FrontLogin : GlobalForm
    {
        internal Session s1;

        public FrontLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (s1.DeleteSession(s1))
            {
                Application.Exit();
            }
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult prompt = MessageBox.Show("Do you want to quit?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                switch (prompt)
                {
                    case DialogResult.OK:
                        if (s1.DeleteSession(s1))
                        {
                            Application.Exit();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}
