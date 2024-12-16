using CRM_system.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CRM_system.Admins_Forms.EventsSubmenu
{
    public partial class Events_list : Form
    {
        private EventQueries eventQuery; // For handling events database queries

        public Events_list()
        {
            InitializeComponent();
            eventQuery = new EventQueries(); // Initialize the EventQueries
            LoadEvents(); // Load events on form load
        }

        // Load events into the DataGridView
        private void LoadEvents()
        {
            try
            {
                // Fetch all events as a list
                var events = eventQuery.GetAllEventsAsList();

                // Bind the events to the DataGridView
                dgEvents.DataSource = events;

                // Adjust column headers to match the database schema
                dgEvents.Columns["ID"].HeaderText = "Event ID";
                dgEvents.Columns["EventName"].HeaderText = "Name";
                dgEvents.Columns["EventDescription"].HeaderText = "Description";
                dgEvents.Columns["EventType"].HeaderText = "Type";
                dgEvents.Columns["AttendanceLimit"].HeaderText = "Limit";
                dgEvents.Columns["PublishStatus"].HeaderText = "Status";
                dgEvents.Columns["EventDate"].HeaderText = "Date";
                dgEvents.Columns["LocationCity"].HeaderText = "Location";
                dgEvents.Columns["FeeId"].HeaderText = "Fee";
                dgEvents.Columns["AdminId"].HeaderText = "Admin";
                // dgEvents.Columns["EventImage"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search events
        private void AdSearchEvents_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string searchText = AdSearchEvents.Text.Trim();
                var events = (List<Models.Event>)dgEvents.DataSource;

                if (!string.IsNullOrEmpty(searchText))
                {
                    var filteredEvents = events.Where(ev =>
                        ev.Id.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        ev.EventName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        ev.EventType.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        ev.EventDescription.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        ev.PublishStatus.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
                    ).ToList();

                    dgEvents.DataSource = filteredEvents;
                }
                else
                {
                    LoadEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Refresh Events button to refresh the event's list
        private void btnRefEvents_Click_1(object sender, EventArgs e)
        {
            try
            {
                LoadEvents();
                // Notify the user that the list has been refreshed
                MessageBox.Show("Event list refreshed successfully.", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //handle any errors
                MessageBox.Show($"Error refreshing the event list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button to remove any chosen events from the database
        private void btnRemoveEvents_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Check if an event is selected
                if (dgEvents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an event to remove.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the ID of the selected event
                int selectedEventId = Convert.ToInt32(dgEvents.SelectedRows[0].Cells["Id"].Value);

                // Confirm the removal
                var confirmResult = MessageBox.Show("Are you sure you want to remove the selected event?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Remove the event from the database
                if (eventQuery.DeleteEvent(selectedEventId))
                {
                    MessageBox.Show("Event removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView after romeving event
                    LoadEvents();
                }
                else
                {
                    MessageBox.Show("Failed to remove the event. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Edit events with a popout form
        private void btnEditEvents_Click_1(object sender, EventArgs e)
        {
            if (dgEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an event to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedEventId = Convert.ToInt32(dgEvents.SelectedRows[0].Cells["Id"].Value);

            // Open the EditEventForm
            var editForm = new Admin_Edit_Event(selectedEventId);
            editForm.ShowDialog(); // Show the form as a modal dialog

            // Refresh the event list after editing
            LoadEvents();
        }
    }
}
