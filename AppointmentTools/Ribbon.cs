using AppointmentTools.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;
using Dtl = AppointmentTools.Services.DriveTimeLogic;


namespace AppointmentTools {
    [ComVisible(true)]
    public class Ribbon : Office.IRibbonExtensibility {
        private Office.IRibbonUI ribbon;

        public Ribbon() {
        }

        public string GetCustomUI(string ribbonID) {
            return GetResourceText("AppointmentTools.Ribbon.xml");
        }


        #region Ribbon Callbacks
        #pragma warning disable IDE0060 // ignore control not used


        public void Ribbon_Load(Office.IRibbonUI ribbonUI) {
            this.ribbon = ribbonUI;
        }

        public void OnMyButton_Click(Office.IRibbonControl control) {
            System.Windows.Forms.MessageBox.Show("My Button clicked!");
        }

        public void OnDriveTimeButton_Click(Office.IRibbonControl control) {
            Dtl driveTimeLogic = new Dtl();
            driveTimeLogic?.TestDrivetime();
        }

        #pragma warning restore IDE0060

        #endregion

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
    }
}
