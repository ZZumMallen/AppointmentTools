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


        public static string ShowApi() {
            return Settings.Default.CurrentKey;
        }

        public static string GetKey() {
            string myKey = Settings.Default.CurrentKey;

            if (string.IsNullOrEmpty(myKey)) {
                MessageBox.Show("myKey is null or empty, falling back");
                myKey = FallbackApiKey;
            }

            return myKey;
        }

        public static string Get(string key) {
            return FallbackApiKey;
        }
    }
}



