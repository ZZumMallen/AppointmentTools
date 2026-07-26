using AppointmentTools.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;
using DTC = AppointmentTools.Controllers;
#pragma warning disable IDE0060

namespace AppointmentTools {

    [ComVisible(true)]
    public class Ribbon : Office.IRibbonExtensibility {

        private Office.IRibbonUI ribbon;

        public Ribbon() { }

        public string GetCustomUI(string ribbonID) {
            return GetResourceText("AppointmentTools.Ribbon.xml");
        }

        public void Ribbon_Load(Office.IRibbonUI ribbonUI) {
            this.ribbon = ribbonUI;
        }

        public async void OnDriveTimeButton_Click(Office.IRibbonControl control) {

            DTC.DT_Logic dtLogic = new DTC.DT_Logic();
            await dtLogic.GetDriveTimeAsync
        }

        public void OnMyButton_Click(Office.IRibbonControl control) {
            if(control is null) => throw new ArgumentNullException(nameof(control));
        }



        #region Helpers

        private static string GetResourceText(string resourceName) {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for(int i = 0; i < resourceNames.Length; ++i) {
                if(string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0) {
                    using(StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i]))) {
                        if(resourceReader != null) {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
#pragma warning restore IDE0060
    }
}
