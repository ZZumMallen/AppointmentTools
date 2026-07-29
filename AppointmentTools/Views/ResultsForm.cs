using AppointmentTools.Controllers;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace AppointmentTools.Views {
    public partial class ResultsForm : Form {

        private bool playSound;

        public ResultsForm(string from, string to, string driveTime, string policyLine, bool meetsPolicyStandard) {
            InitializeComponent();
            playSound = SettingsManager.GetSoundEnabledValue();
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
                if(playSound) {
                    SystemSounds.Exclamation.Play();
                }
            }
        }

        private void Button_Ok_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
