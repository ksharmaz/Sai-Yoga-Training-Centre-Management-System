using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SaiYogaTraining.Model;
using SaiYogaTraining.View._Partials;

namespace SaiYogaTraining.View
{
    public partial class FeePayForm : PopupForm
    {
        public string id = null;
        public int lastBal;
        public string formtype;
        private Fee fee; 

        public FeePayForm()
        {
            InitializeComponent();
        }

        private void FeePayForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Something went wrong!");
                this.Close();
            }
            typetxt.SelectedIndex = 0;
            datetxt.MaxDate = DateTime.Today;
            datetxt.Text = DateTime.Today.ToShortDateString();
            if (formtype.Equals("trainee"))
            {
                fee = new Fee();
                balancetxt.Text = fee.CheckLastBalance(id).ToString();
                lastBal = int.Parse(balancetxt.Text);
                if (lastBal == 0)
                    MessageBox.Show("No Fee Remaining");
                else if (lastBal == -1)
                {
                    MessageBox.Show("Something went wrong!");
                    this.Close();
                }
            }
            else if (formtype.Equals("admission"))
            {
                balancetxt.Text = lastBal.ToString();
            }
        }

        private void FillData()
        {
            fee.Balance = lastBal;
            fee.PayAmt = int.Parse(amttxt.Text);
            fee.PayDate = datetxt.Value;
            fee.PayType = typetxt.SelectedItem.ToString();
            fee.Other = remarkstxt.Text.ToString().Trim();
            fee.TraineeEnroll = id;
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            fee = new Fee();
            lastBal = fee.CalculateBalance(int.Parse(balancetxt.Text), int.Parse(amttxt.Text));
            if (lastBal != -1)
            {
                FillData();
                if (fee.insert())
                {
                    MessageBox.Show("Fee Paid");
                    DisableAll();
                }    
            }
        }

        private void DisableAll()
        {
            this.amttxt.Enabled = false;
            this.datetxt.Enabled = false;
            this.typetxt.Enabled = false;
            this.remarkstxt.Enabled = false;
            this.paybtn.Enabled = false;
            this.receiptbtn.Enabled = true;
        }

        private void receiptbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF Document File | *.pdf";
            dialog.DefaultExt = ".pdf";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dialog.FileName, FileMode.Create);
                fee.GeneratePDF(fs);
                MessageBox.Show("PDF Generated");
            }
            
        }

        private void amttxt_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            Match match = Regex.Match(this.amttxt.Text, "^[0-9]*$");
            if (!match.Success || string.IsNullOrEmpty(this.amttxt.Text))
            {
                this.errorProvider.SetError(this.amttxt, "Please enter number between 0 to 9!");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void amttxt_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.amttxt, string.Empty);
        }
    }
}
