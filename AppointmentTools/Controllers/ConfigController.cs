using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace AppointmentTools.Controllers {

    internal class ConfigController {
        private const string FallbackApiKey = "AIzaSyAW_DRZU9uXOZud2w3LUsFBC0F9s_cvqgA";

        private static readonly Configuration Config;

        

        public static string Get(string key) {
            return FallbackApiKey;
        }
    }
}



