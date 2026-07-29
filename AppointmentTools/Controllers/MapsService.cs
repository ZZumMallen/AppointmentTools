using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AppointmentTools.Controllers {
    public static class MapsService {

        private const string GoogleMapsSearchBaseUrl = "https://www.google.com/maps/search/?api=1&query=";

        /// <summary>
        /// Opens the user's default web browser to a Google Maps search
        /// for the supplied address/location string.
        /// </summary>
        /// <param name="address">The address or location text to search for.</param>
        public static void OpenGoogleMaps(string address) {
            if(string.IsNullOrWhiteSpace(address)) {
                throw new ArgumentException("Address must not be null or empty.", nameof(address));
            }

            string url = BuildGoogleMapsUrl(address);

            try {

                var psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch(Exception ex) {
                MessageBox.Show(
                    $"Could not open Google Maps.\n\nDetails: {ex.Message}",
                    "Error Opening Browser",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Builds a Google Maps "search" URL for the given address using
        /// the documented Maps URL API (does not require an API key).
        /// </summary>
        internal static string BuildGoogleMapsUrl(string address) {
            string encoded = Uri.EscapeDataString(address);
            return GoogleMapsSearchBaseUrl + encoded;
        }
    }
}
