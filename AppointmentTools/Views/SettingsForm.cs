using AppointmentTools.Controllers;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentTools.Views {
    public partial class SettingsForm : Form {
        public SettingsForm() {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e) {
            string tempKey = SettingsManager.GetApiKey();

            if(string.IsNullOrWhiteSpace(tempKey)) {
                txtApiKey.Text = "No Key Exists";
                txtApiKey.UseSystemPasswordChar = false;
            }
            else {
                txtApiKey.Text = tempKey;
            }

            bool tempSound = SettingsManager.GetSoundEnabledValue();
            chkPlaySound.Checked = tempSound;


        }

        private void ChkShowKey_CheckedChanged(object sender, EventArgs e) {
            var check = chkShowKey.Checked;

            switch(check) {
                case true:
                    txtApiKey.UseSystemPasswordChar = false;
                    return;
                case false:
                    txtApiKey.UseSystemPasswordChar = true;
                    return;

            }
        }

        private async void BtnSave_Click(object sender, EventArgs e) {
            string keyToSave = txtApiKey.Text.Trim();

            if(string.IsNullOrWhiteSpace(keyToSave)) {
                ShowStatus("API key can't be blank.", isError: true);
                return;
            }

            int thresholdToSave = (int) numThreshold.Value;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            bool keySaved = SettingsManager.UpdateApiKey(keyToSave);
            bool thresholdSaved = SettingsManager.UpdateThresholdValue(thresholdToSave);

            if(!keySaved || !thresholdSaved) {
                ShowStatus("Something went wrong saving your settings. Please try again.", isError: true);
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                return;
            }

            ShowStatus("Settings saved.", isError: false);

            // brief pause so the confirmation is actually readable before the dialog closes
            await Task.Delay(700);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ShowStatus(string message, bool isError) {
            lblStatus.ForeColor = isError ? Color.Firebrick : Color.SeaGreen;
            lblStatus.Text = message;
        }

        private void ChkPlaySound_CheckedChanged(object sender, EventArgs e) {
            var check = chkPlaySound.Checked;

            switch(check) {
                case true:
                    SettingsManager.UpdateSoundEnabledValue(true);
                    return;
                case false:
                    SettingsManager.UpdateSoundEnabledValue(false);
                    return;

            }
        }
    }
}
