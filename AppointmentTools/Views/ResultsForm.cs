using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppointmentTools.Views {
    public partial class ResultsForm : Form {

        public ResultsForm(string from, string to, string driveTime, string policyLine, bool meetsPolicyStandard) {
            InitializeComponent();
            Label_HeaderFrom.Text = from;
            Label_HeaderTo.Text = to;
            Label_HeaderTime.Text = driveTime;
            Label_PolicyLine.Text = policyLine;

            if(meetsPolicyStandard) {
                Label_PolicyLine.BackColor = Color.Green;
                Label_PolicyLine.ForeColor = Color.White;

            }
            else {
                Label_PolicyLine.BackColor = Color.Red;
                Label_PolicyLine.ForeColor = Color.White;
            }
        }

        private void Button_Ok_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
