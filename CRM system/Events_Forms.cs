using CRM_system.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_system
{
    public partial class Events_Forms : Form
    {
        private UserEventsQueries userEventsQueries;

        // Lists to group controls for event panels
        private List<Panel> eventPanels;
        private List<PictureBox> eventPictures;
        private List<Label> eventNames;
        private List<Label> eventDescriptions;
        private List<Label> eventLocations;
        private List<Label> eventSchedules;
        private List<Label> eventPrices;
        private List<Button> eventJoinButtons;

        public Events_Forms()
        {
            InitializeComponent();
            userEventsQueries = new UserEventsQueries(); // Initialize UserEventsQueries
            InitializeEventControls(); // Group event controls
            LoadEventPanels(); // Load events into panels
        }

        // Method to group controls for event panels
        private void InitializeEventControls()
        {
            try
            {
                // Group panels
                eventPanels = new List<Panel> { usEventPanel1, usEventPanel2, usEventPanel3 };

                // Group picture boxes (ensure you add these controls in the Designer)
                //eventPictures = new List<PictureBox> { usEventPic1, usEventPic2, usEventPic3 };

                // Group labels for event details
                eventNames = new List<Label> { usEventNamel1, usEventNamel2, usEventNamel3 };
                eventDescriptions = new List<Label> { usEventDesc1, usEventDesc2, usEventDesc3 };
                eventLocations = new List<Label> { usEventLocationl1, usEventLocationl2, usEventLocationl3 };
                eventSchedules = new List<Label> { usEventSchedule1, usEventSchedule2, usEventSchedule3 };
                eventPrices = new List<Label> { usEventPrice1, usEventPrice2, usEventPrice3 };

                // Group join buttons
                eventJoinButtons = new List<Button> { usJoinEvent1, usJoinEvent2, usJoinEvent3 };

                // Assign click event handlers for join buttons
                foreach (var button in eventJoinButtons)
                {
                    button.Click += JoinEvent_Click;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing controls: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to load events into the event panels
        private void LoadEventPanels()
        {
            try
            {
                // Retrieve all events
                var events = userEventsQueries.GetAllEventsForCards();

                // Ensure the events list is not null
                if (events == null || events.Count == 0)
                {
                    MessageBox.Show("No events found to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Loop through the panels and populate controls with event data
                for (int i = 0; i < eventPanels.Count && i < events.Count; i++)
                {
                    var ev = events[i];

                    // Populate image (if available)
                    //if (!string.IsNullOrEmpty(ev.EventImage) && File.Exists(ev.EventImage))
                    //{
                    //    eventPictures[i].Image = Image.FromFile(ev.EventImage);
                    //    eventPictures[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    //}
                    //else
                    //{
                    //    eventPictures[i].Image = null; // No image available
                    //}

                    // Populate other event details
                    eventNames[i].Text = $"Event Name: {ev.EventName}";
                    eventDescriptions[i].Text = $"Description: {ev.EventDescription}";
                    eventLocations[i].Text = $"Location ID: {ev.LocationCity}"; // Replace with actual location name if available
                    eventSchedules[i].Text = $"Date: {ev.EventDate}";

                    // Fetch and display fee details
                    var fee = userEventsQueries.GetFeeDetails(ev.FeeId);
                    eventPrices[i].Text = fee != null ? $"Price: {fee.Amount} {fee.Currency}" : "Price: Free";

                    // Set the event ID as the button's Tag
                    eventJoinButtons[i].Tag = ev.Id;

                    // Make the panel visible
                    eventPanels[i].Visible = true;
                }

                // Hide unused panels
                for (int i = events.Count; i < eventPanels.Count; i++)
                {
                    eventPanels[i].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click event handler for "Join Event" buttons
        private void JoinEvent_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the sender is a button
                if (sender is Button joinButton && joinButton.Tag is int eventId)
                {
                    int userId = UserSession.ID; // Replace with your actual logged-in user's ID

                    // Add the user to the event
                    if (userEventsQueries.AddUserToEvent(userId, eventId))
                    {
                        MessageBox.Show("Successfully joined the event!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        joinButton.Enabled = false; // Disable the button after joining
                        joinButton.Text = "Joined"; // Update button text
                    }
                    else
                    {
                        MessageBox.Show("Failed to join the event. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No event selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error joining event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}