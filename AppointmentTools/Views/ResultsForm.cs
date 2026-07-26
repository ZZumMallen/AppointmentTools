using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentTools.Views {
    public partial class ResultsForm : Form {

        public ResultsForm(string from, string to, string driveTime, string policyLine, bool meetsPolicyStandard) {
            InitializeComponent();            
            Label_HeaderFrom.Text = $"From: {from}";
            Label_HeaderTo.Text = $"To: {to}";
            Label_HeaderTime.Text = $"Time: {driveTime}";            
            Label_PolicyLine.Text = policyLine;            

            if(meetsPolicyStandard) {
                Label_PolicyLine.BackColor = Color.Green;
            }
            else {
                Label_PolicyLine.BackColor = Color.Red;
            }
        }



        private void Button_Ok_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
