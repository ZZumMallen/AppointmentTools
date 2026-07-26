using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppointmentTools.Views;

namespace AppointmentTools.Controllers {
    internal class DT_Logic {

        
        public async void GetDriveTimeAsync(string origin, string destination) {
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

            origin = appointment.Location?.Trim();
            if(string.IsNullOrEmpty(origin)) {
                MessageBox.Show(
                    "The selected appointment has no Location field set.\n\n" +
                    "Please add an address to the appointment's Location field and try again.",
                    "No Location Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            // --- 3. Show input form for destination ---
            using(var form = new DT_InputForm(origin)) {
                if(form.ShowDialog() != DialogResult.OK)
                    return;

                string destination = form.DestinationAddress;

                if(string.IsNullOrWhiteSpace(destination)) {
                    MessageBox.Show(
                        "Please enter a destination address.",
                        "Missing Address",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // --- 4. Call Google Maps API ---
                //DriveTimeResult result = await DriveTimeAPI.GetAsync(origin, destination);

                // --- 5. Show result ---
                if(!result.Success) {
                    MessageBox.Show(
                        $"Could not retrieve drive time.\n\nDetails: {result.ErrorMessage}",
                        "API Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                string policyLine = result.MeetsPolicy
                        ? $"✔  Meets policy  (≤ 15 min)"
                        : $"✘  Exceeds policy  (> 15 min) — find a different slot.";

                MessageBox.Show(
                    $"From:   {origin}\n" +
                    $"To:       {destination}\n\n" +
                    $"Drive Time:  {result.DisplayText}\n\n" +
                    policyLine,
                    "Drive Time Result",
                    MessageBoxButtons.OK,
                    result.MeetsPolicy ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
        }





        

        private AppointmentItem GetActiveAppointment() {
            var app = Globals.ThisAddIn.Application;

            AppointmentItem appointment = null;

            if(app.ActiveInspector()?.CurrentItem is AppointmentItem fromInsapctor) {
                appointment = app.ActiveInspector().CurrentItem as AppointmentItem;
            }
            else if(app.ActiveExplorer().Selection.Count > 0 && app.ActiveExplorer().Selection[1] is AppointmentItem fromExplorer) {
                appointment = fromExplorer;
            }
            return appointment;
        }

        public void TestDrivetime() {
            MessageBox.Show("Test Drive Time Logic",
                "Test",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

    }
}
