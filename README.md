# AppointmentTools

An Outlook add-in (VSTO) that helps customer service reps quickly check drive time to an appointment's location, verify it against a policy threshold, and jump to Google Maps or copy the address — all from the Outlook ribbon.

## Features

- **Check Drive Time** — enter a destination and get an estimated drive time from the appointment's location, with an address autocomplete/suggestion list and a clear pass/fail indicator against your configured policy threshold.
- **Google Maps** — open the appointment's location directly in Google Maps.
- **Copy Location** — copy the appointment's location to the clipboard.
- **Settings** — configure your Google Maps API key, the drive-time policy threshold (in minutes), and whether a sound plays when a result exceeds policy.

> [!IMPORTANT]
> **These buttons appear on a contextual ribbon tab that shows up when a calendar appointment is selected**.

<img width="246" height="99" alt="AppointmentToolsRibbonPic" src="https://github.com/user-attachments/assets/0b1c5872-efc4-4a62-aeaf-b0139b8161dc" />

## Requirements

- Outlook (desktop, Windows) with the .NET Framework 4.8 runtime and the VSTO runtime installed.
- A [Google Maps Platform](https://developers.google.com/maps) API key with the Distance Matrix API and Places API enabled, entered via the add-in's Settings dialog.

## Getting started (development)

1. Open `AppointmentTools.slnx` in Visual Studio.
2. Restore NuGet packages (see `AppointmentTools/packages.config`).
3. Build and run — Visual Studio will launch Outlook with the add-in loaded.
4. Open the add-in's Settings dialog (ribbon → Settings) and paste in your Google Maps API key.

## Configuration

Settings are stored per-user (`AppointmentTools/Properties/Settings.settings`):

| Setting | Description |
|---|---|
| `CurrentKey` | Your Google Maps API key. |
| `PolicyThreshold` | Maximum drive time (minutes) considered within policy. |
| `EnableSound` | Whether a sound plays when a result exceeds policy. |

## License

MIT — see [LICENSE](LICENSE).
