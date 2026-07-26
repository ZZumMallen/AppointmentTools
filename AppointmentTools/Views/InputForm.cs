using AppointmentTools.Controllers;
using AppointmentTools.Views;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppointmentTools.Views {
    public partial class InputForm : Form {

        #region Fields
        public string DestinationAddress => Destination_TextBox.Text.Trim();        
        private static readonly HttpClient Http = new HttpClient();
        private static readonly string ApiKey = ConfigController.Get("GoogleMapsApiKey");
        private readonly Timer _debounceTimer;
        private bool   _suppressTextChanged;   // prevents re-triggering while we fill the box
        private const int SuggestionItemHeight = 18;   // px per row
        private const int MaxVisibleSuggestions = 4;

        #endregion Fields

        public InputForm(string appointmentLocation) {
            InitializeComponent();
            Origin_TextBox.Text = appointmentLocation;

            _debounceTimer = new Timer { Interval = 350 };
            _debounceTimer.Tick += OnDebounceTimerTick;

            this.Shown += (s, e) => {
                Destination_TextBox.Focus();
                Destination_TextBox.SelectAll();
            };
        }

        private void OnSearchButtonClick(object sender, EventArgs e) {
            if(Destination_ResultsList.Visible && Destination_ResultsList.SelectedIndex >= 0) {
                SelectSuggestion();
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BTN_Paste_Click(object sender, EventArgs e) {
            if(Clipboard.ContainsText()) {
                _suppressTextChanged = true;
                Destination_TextBox.Text = Clipboard.GetText().Trim();
                Destination_TextBox.SelectionStart = Destination_TextBox.Text.Length;
                _suppressTextChanged = false;

                HideSuggestions();

                Destination_TextBox.Focus();
            }
        }

        private void OnDestinationTextChange(object sender, EventArgs e) {
            if(_suppressTextChanged)
                return;

            _debounceTimer.Stop();

            if(Origin_TextBox.Text.Trim().Length < 3) {
                HideSuggestions();
                return;
            }

            _debounceTimer.Start();
        }

        private async void OnDebounceTimerTick(object sender, EventArgs e) {
            _debounceTimer.Stop();
            await FetchSuggestionsAsync(Destination_TextBox.Text.Trim());
        }

        private async Task FetchSuggestionsAsync(string input) {

            try {
                string url = "https://maps.googleapis.com/maps/api/place/autocomplete/json"
                           + $"?input={Uri.EscapeDataString(input)}"
                           + "&types=address"
                           + $"&key={ApiKey}";

                string  json        = await Http.GetStringAsync(url);
                JObject data        = JObject.Parse(json);




                var     predictions = data["predictions"] as JArray;

                if(predictions == null || predictions.Count == 0) {
                    HideSuggestions();
                    return;
                }

                var suggestions = new List<string>();
                foreach(var p in predictions) {
                    string desc = p["description"]?.ToString();
                    if(!string.IsNullOrEmpty(desc))
                        suggestions.Add(desc);
                }

                // Marshal back to UI thread (async void + await already does this,
                // but guard explicitly in case of edge cases)
                if(InvokeRequired)
                    Invoke(new Action<List<string>>(ShowSuggestions), suggestions);
                else
                    ShowSuggestions(suggestions);
            }
#pragma warning disable CS0168
            catch(Exception ex) {
                HideSuggestions();
            }
#pragma warning restore CS0168
        }

        private void ShowSuggestions(List<string> items) {
            Destination_ResultsList.Items.Clear();
            foreach(var item in items)
                Destination_ResultsList.Items.Add(item);

            int rows       = Math.Min(items.Count, MaxVisibleSuggestions);
            int listHeight = rows * SuggestionItemHeight + 4;

            Destination_ResultsList.Height = listHeight;
            Destination_ResultsList.Visible = true;
            Destination_ResultsList.BringToFront();
        }

        private void HideSuggestions() {
            if(!Destination_ResultsList.Visible)
                return;

            Destination_ResultsList.Visible = false;
            Destination_ResultsList.Items.Clear();
            Destination_ResultsList.Height = 0;
        }

        private void SelectSuggestion() {
            if(Destination_ResultsList.SelectedItem == null)
                return;

            _suppressTextChanged = true;
            Destination_TextBox.Text = Destination_ResultsList.SelectedItem.ToString();
            Destination_TextBox.SelectionStart = Destination_TextBox.Text.Length;
            _suppressTextChanged = false;

            HideSuggestions();
            Destination_TextBox.Focus();
        }

        private void OnDestinationTextKeyDown(object sender, KeyEventArgs e) {
            if(!Destination_ResultsList.Visible)
                return;

            switch(e.KeyCode) {
                case Keys.Down:
                    Destination_ResultsList.SelectedIndex =
                        (Destination_ResultsList.SelectedIndex < Destination_ResultsList.Items.Count - 1)
                            ? Destination_ResultsList.SelectedIndex + 1
                            : 0;
                    e.Handled = true;
                    break;

                case Keys.Up:
                    if(Destination_ResultsList.SelectedIndex > 0)
                        Destination_ResultsList.SelectedIndex--;
                    e.Handled = true;
                    break;

                case Keys.Enter:
                    if(Destination_ResultsList.SelectedIndex >= 0) {
                        SelectSuggestion();
                        e.Handled = true;
                        e.SuppressKeyPress = true;   // stops the default OK-button beep
                    }
                    break;

                case Keys.Escape:
                    HideSuggestions();
                    e.Handled = true;
                    break;
            }
        }

        private void OnDestinationText_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                SelectSuggestion();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if(e.KeyCode == Keys.Escape) {
                HideSuggestions();
                Destination_ResultsList.Focus();
                e.Handled = true;
            }
        }

        private void OnDestinationResultsList_Click(object sender, EventArgs e) {
            SelectSuggestion();
        }
    }
}
