using CRM_system.DB;
using System;
using System.Collections.Generic;
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

        public Events_Forms()
        {
            InitializeComponent();
            userEventsQueries = new UserEventsQueries(); // Initialize UserEventsQueries
            LoadEventPanels(); // Load events dynamically
        }

        /// <summary>
        /// Method to dynamically load and generate event panels once more are created.
        /// </summary>
        private void LoadEventPanels(string searchQuery = "")
        {
            try
            {
                // Clear existing controls
                FlowPanelEvents.Controls.Clear();

                // Retrieve all events
                var events = userEventsQueries.GetAllEventsForCards();

                // Filter events based on the search query (case-insensitive, by event name)
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    events = events.Where(ev => ev.EventName != null && ev.EventName.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                }

                if (events == null || events.Count == 0)
                {
                    // Show a message if no matching events are found
                    Label noEventsLabel = new Label
                    {
                        Text = "No events found.",
                        Font = new Font("Arial", 12, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    FlowPanelEvents.Controls.Add(noEventsLabel);
                    return;
                }

                foreach (var ev in events)
                {
                    // Create a new panel for the event
                    Panel eventPanel = new Panel
                    {
                        Size = new Size(240, 396), // Adjusted size for three panels in a row
                        BackColor = Color.FromArgb(19, 19, 19),
                        Margin = new Padding(5)
                    };

                    // Create the event image
                    PictureBox eventPic = new PictureBox
                    {
                        Size = new Size(243, 139),
                        Image = ev.EventImage, // Set the image from the event
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(0, 0)
                    };

                    // Create the event name label
                    Label eventName = new Label
                    {
                        Text = ev.EventName,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        ForeColor = Color.White,
                        Size = new Size(240, 42),
                        AutoSize = false,
                        Location = new Point(2, 145)
                    };

                    // Create the event description label
                    Label eventDesc = new Label
                    {
                        Text = ev.EventDescription,
                        Font = new Font("Arial", 9),
                        ForeColor = Color.LightGray,
                        Size = new Size(240, 85),
                        AutoSize = false,
                        Location = new Point(2, 190)
                    };

                    // Create the event location label
                    Label eventLocation = new Label
                    {
                        Text = $"Location: {ev.LocationCity}",
                        Font = new Font("Arial", 9),
                        ForeColor = Color.LightGray,
                        Size = new Size(106, 16),
                        Location = new Point(2, 273)
                    };

                    // Create the event schedule label
                    Label eventSchedule = new Label
                    {
                        Text = $"Date: {ev.EventDate}",
                        Font = new Font("Arial", 9),
                        ForeColor = Color.LightGray,
                        Size = new Size(106, 16),
                        Location = new Point(4, 300)
                    };

                    // Create the event price label
                    Label eventPrice = new Label
                    {
                        Text = ev.FeeAmount != "0"
                            ? $"Price: {ev.FeeAmount} {ev.FeeCurrency}"
                            : "Price: Free",
                        Font = new Font("Arial", 10),
                        ForeColor = Color.White,
                        Size = new Size(106, 16),
                        Location = new Point(3, 330)
                    };

                    // Create the join event button
                    Button joinEventButton = new Button
                    {
                        Text = "Join Event",
                        BackColor = Color.FromArgb(255, 87, 87),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Size = new Size(127, 31),
                        Location = new Point(50, 357),
                        Tag = ev.Id // Store the event ID
                    };
                    joinEventButton.FlatAppearance.BorderSize = 0;
                    joinEventButton.Click += JoinEvent_Click; // Attach the click event

                    // Add controls to the panel
                    eventPanel.Controls.Add(eventPic);
                    eventPanel.Controls.Add(eventName);
                    eventPanel.Controls.Add(eventDesc);
                    eventPanel.Controls.Add(eventLocation);
                    eventPanel.Controls.Add(eventSchedule);
                    eventPanel.Controls.Add(eventPrice);
                    eventPanel.Controls.Add(joinEventButton);

                    // Add the panel to the FlowLayoutPanel
                    FlowPanelEvents.Controls.Add(eventPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the click event for "Join Event" buttons.
        /// </summary>
        private void JoinEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button joinButton && joinButton.Tag is int eventId)
                {
                    int userId = UserSession.ID; // Replace with your actual logged-in user's ID

                    if (userEventsQueries.AddUserToEvent(userId, eventId))
                    {
                        MessageBox.Show("Successfully joined the event!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        joinButton.Enabled = false;
                        joinButton.Text = "Joined";
                    }
                    else
                    {
                        MessageBox.Show("Failed to join the event. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error joining event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for search box text change
        /// </summary>
        private void userEventsSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search query from the text box
            string query = userEventsSearch.Text.Trim();

            // Reload the event panels based on the search query
            LoadEventPanels(query);
        }

    }
}
