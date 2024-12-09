using CRM_system.DB; // Reference to access the EventQueries class
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CRM_system.Admins_Forms.EventsSubmenu
{
    public partial class Events_Attendees : Form
    {
        private EventQueries eventQueries; // For handling event-related database queries

        public Events_Attendees()
        {
            InitializeComponent();
            eventQueries = new EventQueries(); // Initialize EventQueries
        }

        // Method to load all attendees for all events
        private void LoadAllEventAttendees()
        {
            try
            {
                // Fetch all attendees for all events
                var allAttendees = eventQueries.GetAllEventAttendees();

                // Bind the attendees data to DataGridView
                dgEventsAttendees.DataSource = allAttendees;

                // Format the DataGridView
                FormatAttendeesGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading all event attendees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        // Format the DataGridView for attendees
        private void FormatAttendeesGrid()
        {
            dgEventsAttendees.AutoGenerateColumns = true; 
            dgEventsAttendees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEventsAttendees.AllowUserToAddRows = false; // Disable adding rows manually
            dgEventsAttendees.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Ensure full rows are selected
            dgEventsAttendees.ReadOnly = true; // Make the grid read-only
        }

        // Event handler for loading attendees when the form is loaded
        private void Events_Attendees_Load(object sender, EventArgs e)
        {
            LoadAllEventAttendees(); 
        }

        // Button to refresh attendees list  
        private void btnRefattendees_Click(object sender, EventArgs e)
        {
            try
            {
                // Reload all attendees for all events
                LoadAllEventAttendees();

                // Notify the user with pop notification
                MessageBox.Show("Attendees List Refreshed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing attendees list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button click event to refresh the attendees list
        private void btnRemoveAttendees_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dgEventsAttendees.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an attendee to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the Attendee ID from the selected row
                int attendeeId = Convert.ToInt32(dgEventsAttendees.SelectedRows[0].Cells["AttendeeID"].Value);

                // Confirm the action
                var confirmResult = MessageBox.Show("Are you sure you want to remove this attendee?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Call the database method to remove the attendee
                if (eventQueries.RemoveEventAttendee(attendeeId))
                {
                    MessageBox.Show("Attendee removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the attendee list after removal
                    LoadAllEventAttendees();
                }
                else
                {
                    MessageBox.Show("Failed to remove the attendee. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing attendee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Search for an attendee dynamically with TextChanged 
        private void SearchEventAttendees_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = SearchEventAttendees.Text.Trim();

                if (dgEventsAttendees.DataSource is DataTable dataTable)
                {
                    DataView dataView = dataTable.DefaultView;

                    // Apply filter to the DataView
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        dataView.RowFilter = $"Convert(AttendeeID, 'System.String') LIKE '%{searchText}%' OR " +
                                             $"UserName LIKE '%{searchText}%' OR " +
                                             $"Convert(EventID, 'System.String') LIKE '%{searchText}%' OR " +
                                             $"EventName LIKE '%{searchText}%' OR " +
                                             $"JoinedAt LIKE '%{searchText}%'";
                    }
                    else
                    {
                        dataView.RowFilter = string.Empty; // Clear the filter
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching attendees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }


