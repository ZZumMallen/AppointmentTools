using System;
using System.Windows.Forms;
using Settings = AppointmentTools.Properties.Settings;

namespace AppointmentTools.Controllers {

    public static class SettingsManager {

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

        private static bool TryUpdateValue<T>(string key, T newValue) {
            try {
                Settings.Default[key] = newValue;
                Settings.Default.Save();
                return true;
            }
            catch(Exception ex) {
                MessageBox.Show(
                    $"Failed to save '{key}'. Exception: {ex.Message}",
                    "Settings Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        // ---- typed, named wrappers (public API) ----

        public static string GetApiKey() =>
            GetValue(nameof(Settings.Default.CurrentKey), "No value found");

        public static bool UpdateApiKey(string newValue) =>
            TryUpdateValue(nameof(Settings.Default.CurrentKey), newValue);

        public static int GetThesholdValue() =>
            GetValue(nameof(Settings.Default.PolicyThreshold), 0);

        public static bool UpdateThresholdValue(int newValue) =>
            TryUpdateValue(nameof(Settings.Default.PolicyThreshold), newValue);

        public static bool GetSoundEnabledValue() =>
            GetValue(nameof(Settings.Default.EnableSound), true);

        public static bool UpdateSoundEnabledValue(bool newValue) =>
            TryUpdateValue(nameof(Settings.Default.EnableSound), newValue);
    }
}