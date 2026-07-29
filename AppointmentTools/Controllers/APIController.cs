using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppointmentTools.Controllers {

    internal class DriveTimeResult {
        public bool Success { get; set; }
        public int Minutes { get; set; }
        public string DisplayText { get; set; }   // "14 mins"
        public bool MeetsPolicy { get; set; }
        public int PolicyThresholdMinutes { get; set; }
        public string ErrorMessage { get; set; }
    }

    internal static class ApiController { // Thanks Claude!

        private static readonly HttpClient Http = new HttpClient();
        public static async Task<DriveTimeResult> GetAsync(string origin, string destination) {
            var result = new DriveTimeResult();
            int policyMaxMinutes = SettingsManager.GetThresholdValue();

            try {
                string apiKey = SettingsManager.GetApiKey();
                string url = "https://maps.googleapis.com/maps/api/distancematrix/json"
                           + $"?origins={Uri.EscapeDataString(origin)}"
                           + $"&destinations={Uri.EscapeDataString(destination)}"
                           + "&mode=driving"
                           + $"&key={apiKey}";

                string json = await Http.GetStringAsync(url);
                JObject data = JObject.Parse(json);

                // Top-level status check
                string topStatus = data["status"]?.ToString();
                if(topStatus != "OK") {
                    result.Success = false;
                    result.ErrorMessage = $"API error: {topStatus}";
                    return result;
                }

                // Element-level status check
                var element       = data["rows"][0]["elements"][0];
                string elemStatus = element["status"]?.ToString();
                if(elemStatus != "OK") {
                    result.Success = false;
                    result.ErrorMessage = $"Route not found ({elemStatus}). Check that both addresses are valid.";
                    return result;
                }

                int    seconds      = element["duration"]["value"].ToObject<int>();
                string durationText = element["duration"]["text"].ToString();

                result.Success = true;
                result.Minutes = seconds / 60;
                result.DisplayText = durationText;
                result.PolicyThresholdMinutes = policyMaxMinutes;
                result.MeetsPolicy = result.Minutes <= policyMaxMinutes;
            }
            catch(Exception ex) {
                result.Success = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
    }
}
