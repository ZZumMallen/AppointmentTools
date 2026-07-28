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
        private static readonly string ApiKey = SettingsManager.GetKey();
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

        #region Callbacks

        private void OnSearchButton_Click(object sender, EventArgs e) {
            if(Results_List.Visible && Results_List.SelectedIndex >= 0) {
                SelectSuggestion();
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OnCancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void OnPasteButton_Click(object sender, EventArgs e) {
            if(Clipboard.ContainsText()) {
                _suppressTextChanged = true;
                Destination_TextBox.Text = Clipboard.GetText().Trim();
                Destination_TextBox.SelectionStart = Destination_TextBox.Text.Length;
                _suppressTextChanged = false;

                HideSuggestions();

                Destination_TextBox.Focus();
            }
        }

        private void OnButtonX_Click(object sender, EventArgs e) {
            Destination_TextBox.Clear();
        }

        private void OnDestinationText_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if(Results_List.Visible && Results_List.SelectedIndex >= 0) {
                    SelectSuggestion();
                    return;
                }

                OnSearchButton_Click(sender, EventArgs.Empty);
            }            
        }

        private void OnDestinationText_TextChanged(object sender, EventArgs e) {
            if(_suppressTextChanged)
                return;

            _debounceTimer.Stop();

            if(Origin_TextBox.Text.Trim().Length < 3) {
                HideSuggestions();
                return;
            }

            _debounceTimer.Start();
        }

        private void OnResults_KeyDown(object sender, KeyEventArgs e) {
            if(!Results_List.Visible)
                return;
            
            switch(e.KeyCode) {
                case Keys.Down:
                    Results_List.SelectedIndex =
                        (Results_List.SelectedIndex < Results_List.Items.Count - 1)
                            ? Results_List.SelectedIndex + 1
                            : 0;
                    e.Handled = true;
                    break;

                case Keys.Up:
                    if(Results_List.SelectedIndex > 0)
                        Results_List.SelectedIndex--;
                    e.Handled = true;
                    break;

                case Keys.Enter:
                    if(Results_List.SelectedIndex >= 0) {
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

        private void OnResults_Click(object sender, EventArgs e) {
            SelectSuggestion();
        }

        private async void OnDebounceTimerTick(object sender, EventArgs e) {
            _debounceTimer.Stop();
            await FetchSuggestionsAsync(Destination_TextBox.Text.Trim());
        }

        #endregion Callbacks

        #region Helper Methods

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
            Results_List.Items.Clear();
            foreach(var item in items)
                Results_List.Items.Add(item);

            int rows       = Math.Min(items.Count, MaxVisibleSuggestions);
            int listHeight = rows * SuggestionItemHeight + 4;

            Results_List.Height = listHeight;
            Results_List.Visible = true;
            Results_List.BringToFront();
        }

        private void HideSuggestions() {
            if(!Results_List.Visible)
                return;

            Results_List.Visible = false;
            Results_List.Items.Clear();
            Results_List.Height = 0;
        }

        private void SelectSuggestion() {
            if(Results_List.SelectedItem == null)
                return;

            _suppressTextChanged = true;
            Destination_TextBox.Text = Results_List.SelectedItem.ToString();
            Destination_TextBox.SelectionStart = Destination_TextBox.Text.Length;
            _suppressTextChanged = false;

            HideSuggestions();
            Destination_TextBox.Focus();
        }


        #endregion Helper Methods

    }
}
