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



namespace AppointmentTools.Controllers {


    internal class ConfigController {
        private const string FallbackApiKey = "AIzaSyAW_DRZU9uXOZud2w3LUsFBC0F9s_cvqgA";

        public static string GetKey() {
            try {
                string myKey = Settings.Default.CurrentKey;
                return myKey;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return FallbackApiKey;
            }
        }

        public void UpdateKey(string newValue) {
            string oldValue = Settings.Default.CurrentKey;
            Settings.Default.CurrentKey = newValue;

            MessageBox.Show($"key {oldValue} has been replaced with key: {newValue}");

        }

        public void ResetKeyToFallback() {
            Settings.Default.CurrentKey = FallbackApiKey;
        }

        public static string Get(string key) {
            return FallbackApiKey;
        }
    }
}



