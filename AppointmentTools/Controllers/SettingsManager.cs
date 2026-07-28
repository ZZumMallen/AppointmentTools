using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Settings = AppointmentTools.Properties.Settings;



// Settings Keys so far: CurrentKey, PolicyThreshold
// Nonsense Settings: Setting, Setting1

namespace AppointmentTools.Controllers {


    internal class SettingsManager {
        //private const string FallbackApiKey = "AIzaSyAW_DRZU9uXOZud2w3LUsFBC0F9s_cvqgA";

        public string CurrentApiKey => _apiKey;
        public int ThresholdValue => _thresholdValue;

        private readonly string _apiKey = Settings.Default.CurrentKey;
        private readonly int _thresholdValue = Settings.Default.PolicyThreshold;

        

        public static string GetKey() {
            try {
                string myKey = Settings.Default.CurrentKey;
                return myKey;
            }
            catch(Exception ex) {
                string noKeyMessage = $"No key found! Exception: {ex.Message}";
                return noKeyMessage;
            }
        }



        public void UpdateKey(string newValue) {
            string oldValue = Settings.Default.CurrentKey;
            Settings.Default.CurrentKey = newValue;

            MessageBox.Show($"key {oldValue} has been replaced with key: {newValue}");

        }

        public static string GetApiKey() {
            try {
                string value = Settings.Default.CurrentKey;
                return value;
            }
            catch(Exception ex) {
                string noKeyMessage = $"No key found! Exception: {ex.Message}";
                return noKeyMessage;
            }
        }

        public static int GetThesholdValue() {
            try {
                int value = Settings.Default.PolicyThreshold;
                return value;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return nu
            }
        }
    }
}



