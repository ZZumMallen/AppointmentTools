using AppointmentTools.Controllers;
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
    public partial class SettingsForm : Form {

        private string previousApiValue;
        private string currentApiValue;
        private string newApiValue;

        private int previousThresholdValue;
        private int currentThresholdValue;
        private int newThresholdValue;

        public SettingsForm() {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e) {
            // save previous settings

            previousApiValue = SettingsManager.GetApiKey(); 
            previousThresholdValue = SettingsManager.GetThesholdValue();
        }

        private void OnApiShowButton(object sender, EventArgs e) {
            switch(txt_apiKey.UseSystemPasswordChar) {
                case true:
                    txt_apiKey.UseSystemPasswordChar = false;
                    break;
                case false:
                    txt_apiKey.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void OnApiUnlockButton(object sender, EventArgs e) {
            if(txt_apiKey.ReadOnly) { 
                txt_apiKey.ReadOnly = false;
            }        
        }

        private void OnThresholdUnlockButton(object sender, EventArgs e) {
            if(num_UpDown.ReadOnly) {
                num_UpDown.ReadOnly = false;
            }
        }

        private void OnSaveButton(object sender, EventArgs e) {
            SettingsManager.UpdateAPIKey(newApiValue);
            SettingsManager.UpdateThresholdValue(newThresholdValue);
        }

        private void OnUndoButton(object sender, EventArgs e) {
            SettingsManager.UpdateAPIKey(previousApiValue);
            SettingsManager.UpdateThresholdValue(previousThresholdValue);
        }


    }
}
