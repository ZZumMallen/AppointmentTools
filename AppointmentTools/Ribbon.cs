using AppointmentTools.Views;
using AppointmentTools.Controllers;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;
using InputForm = AppointmentTools.Views.InputForm;

#pragma warning disable IDE0060

namespace AppointmentTools {

    [ComVisible(true)]
    public class Ribbon : Office.IRibbonExtensibility {
        private Office.IRibbonUI ribbon;

        public Ribbon() { }

        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID) {
            return GetResourceText("AppointmentTools.Ribbon.xml");
        }
        #endregion

        #region Ribbon Callbacks

        public void Ribbon_Load(Office.IRibbonUI ribbonUI) {
            this.ribbon = ribbonUI;
        }

        public async void OnDriveTimeButton_Click(Office.IRibbonControl control) {
            if(control is null) {
                throw new ArgumentNullException(nameof(control));
            }

            AppointmentItem appointment = GetActiveAppointment();

            // null check 
            if(appointment == null) {
                MessageBox.Show(
                    "Please select a calendar appointment first.",
                    "No Appointment Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string origin = appointment.Location?.Trim();
            if(string.IsNullOrEmpty(origin)) {
                MessageBox.Show(
                    "The selected appointment has no Location field set.\n\n" +
                    "Please add an address to the appointment's Location field and try again.",
                    "No Location Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string destinationText;

            using(var form = new InputForm(origin)) {
                if(form.ShowDialog() != DialogResult.OK)
                    return;

                destinationText = form.Destination_TextBox.Text;

                if(string.IsNullOrWhiteSpace(destinationText)) {
                    MessageBox.Show(
                        "Please enter a destination address.",
                        "Missing Address",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DriveTimeResult result = await ApiController.GetAsync(origin, destinationText);

                if(!result.Success) {
                    MessageBox.Show(
                        $"Could not retrieve drive time.\n\nDetails: {result.ErrorMessage}",
                        "API Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                bool meetsPolicyStandard = result.MeetsPolicy;

                string policyLine = result.MeetsPolicy
                        ? $"Meets policy  (≤ 15 min)"
                        : $"Exceeds policy  (> 15 min) — find a different slot.";

                using(var resultsForm = new ResultsForm(origin, destinationText, result.DisplayText, policyLine, meetsPolicyStandard)) {
                    if(resultsForm.ShowDialog() != DialogResult.OK)
                        return;
                }
            }
        }

        #endregion Ribbon Callbacks

        #region Helpers

        private AppointmentItem GetActiveAppointment() {
            var app = Globals.ThisAddIn.Application;
            AppointmentItem appointment = null;

            // Check if an appointment is open in its own window
            if(app.ActiveInspector()?.CurrentItem is AppointmentItem fromInspector)
                appointment = fromInspector;

            // Otherwise check calendar view selection
            else if(app.ActiveExplorer()?.Selection?.Count > 0
                     && app.ActiveExplorer().Selection[1] is AppointmentItem fromExplorer)
                appointment = fromExplorer;

            return appointment;
        }

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

#pragma warning restore IDE0060