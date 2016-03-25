using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SaiYogaTraining.View._Partials
{
    public partial class DetailForm : GlobalForm
    {
        public DetailForm()
        {
            InitializeComponent();
        }

        private void nametxt_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.nametxt, string.Empty);
        }

        private void nametxt_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.nametxt.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProvider.SetError(this.nametxt, "Mandatory Field!");
            }
            e.Cancel = cancel;
        }

        private void contacttxt_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.contacttxt, string.Empty);
        }

        private void contacttxt_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            Match match = Regex.Match(this.contacttxt.Text, "^[0-9]*$");
            if (!match.Success || string.IsNullOrEmpty(this.contacttxt.Text))
            {
                this.errorProvider.SetError(this.contacttxt, "Please enter number between 0 to 9!");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void addresstxt_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.addresstxt, string.Empty);
        }

        private void addresstxt_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.contacttxt.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProvider.SetError(this.contacttxt, "Mandatory Field!");
            }
            e.Cancel = cancel;
        }
    }
}
