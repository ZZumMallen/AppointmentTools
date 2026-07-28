using System;
using System.Windows.Forms;
using Settings = AppointmentTools.Properties.Settings;

namespace AppointmentTools.Controllers {

    internal class SettingsManager {

        // ---- generic engine (private) ----

        private static T GetValue<T>(string key, T fallback) {
            try {
                return (T) Settings.Default[key];
            }
            catch(Exception ex) {
                MessageBox.Show($"No value found for '{key}'! Exception: {ex.Message}");
                return fallback;
            }
        }

        private static void UpdateValue<T>(string key, T newValue) {
            object oldValue = Settings.Default[key];
            Settings.Default[key] = newValue;
            Settings.Default.Save();

            MessageBox.Show($"{key}: '{oldValue}' has been replaced with '{newValue}'");
        }

        // ---- typed, named wrappers (public API) ----

        public static string GetApiKey() =>
            GetValue(nameof(Settings.Default.CurrentKey), "No value found");

        public static void UpdateAPIKey(string newValue) =>
            UpdateValue(nameof(Settings.Default.CurrentKey), newValue);

        public static int GetThesholdValue() =>
            GetValue(nameof(Settings.Default.PolicyThreshold), 0);

        public static void UpdateThresholdValue(int newValue) =>
            UpdateValue(nameof(Settings.Default.PolicyThreshold), newValue);
    }
}