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
    public partial class dashboard_form : Form
    {
        private UserEventsQueries userEventsQueries;
        private UserQueries userQueries;

        public dashboard_form()
        {
            InitializeComponent();
            userEventsQueries = new UserEventsQueries(); // Initialize the database query handler
            userQueries = new UserQueries(); // Initialize the queries class

            lblUserName.Text = $"Welcome, {UserSession.Name}"; // Display the logged-in user's name
            LoadJoinedEvents(); // Load all events joined by the user
            LoadMembershipDetails();// Load membership details


        }

        // Method to load all events joined by the user
        private void LoadJoinedEvents()
        {
            try
            {
                int userId = UserSession.ID; // Replace with the actual logged-in user's ID

                // Fetch joined events
                var joinedEvents = userEventsQueries.GetUserJoinedEvents(userId);

                // Bind the data to the DataGridView
                dgJoinedEvents.DataSource = joinedEvents;

                // Ensure the grid columns are styled/formatted appropriately
                FormatJoinedEventsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading joined events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Format the DataGridView columns
        private void FormatJoinedEventsGrid()
        {
            dgJoinedEvents.AutoGenerateColumns = true; // Allow columns to auto-generate from the data source
            dgJoinedEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgJoinedEvents.AllowUserToAddRows = false; // Disable adding rows manually
            dgJoinedEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Ensure full rows are selected
            dgJoinedEvents.ReadOnly = true; // Make the grid read-only
        }

        private void RefreshJoinedEvents_Click(object sender, EventArgs e)
        {
            LoadJoinedEvents(); // Refresh the joined events
            MessageBox.Show("Events List Refreshed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgLeaveEvent_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected in the DataGridView
                if (dgJoinedEvents.SelectedRows.Count > 0)
                {
                    // Get the Event ID from the selected row
                    int eventId = Convert.ToInt32(dgJoinedEvents.SelectedRows[0].Cells["Event ID"].Value);
                    int userId = UserSession.ID; // Replace with the logged-in user's ID

                    // Confirm the action
                    var confirmResult = MessageBox.Show("Are you sure you want to leave this event?",
                                                        "Confirm Leave Event",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Remove the user from the event
                        if (userEventsQueries.RemoveUserFromEvent(userId, eventId))
                        {
                            MessageBox.Show("Successfully left the event.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadJoinedEvents(); // Refresh the joined events list
                        }
                        else
                        {
                            MessageBox.Show("Failed to leave the event. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an event to leave.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error leaving event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        private void LoadMembershipDetails()
        {
            try
            {
                int userId = UserSession.ID; // Get the logged-in user's ID

                // Retrieve membership details from the database using UserQueries
                var membershipDetails = userQueries.GetMembershipDetails(userId);

                if (membershipDetails != null)
                {
                    usMemberTierLabel.Text = $"Tier: {membershipDetails.Tier}";
                    usMemberSinceLabel.Text = $"Member Since: {membershipDetails.MemberSince}";
                    usMemberStatusLabel.Text = $"Status: {membershipDetails.Status}";
                }
                else
                {
                    usMemberTierLabel.Text = "Tier: Not a Member";
                    usMemberSinceLabel.Text = "Member Since: N/A";
                    usMemberStatusLabel.Text = "Status: None";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading membership details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dashboard_form_Load(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void usMemberStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void dgJoinedEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}