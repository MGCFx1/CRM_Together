using CRM_system.DB;
using CRM_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_system.Admins_Forms
{
    public partial class Admin_Edit_Event : Form
    {
        private readonly EventQueries eventQueries;
        private readonly int eventId;

        public Admin_Edit_Event(int eventId)
        {
            InitializeComponent();
            this.eventQueries = new EventQueries();
            this.eventId = eventId;

            LoadEventDetails(); // Load the event data into the form fields
        }

        //Fetch and load the event details into the form based on EventID
        private void LoadEventDetails()
        {
            try
            {
                // Fetch event details by ID
                var eventDetails = eventQueries.GetEventById(eventId);

                if (eventDetails != null)
                {
                    // Populate the form fields
                    PopEventName.Text = eventDetails.EventName;
                    PopEventDesc.Text = eventDetails.EventDescription;
                    PopEventType.SelectedItem = eventDetails.EventType;
                    PopEventAttend.Text = eventDetails.AttendanceLimit.ToString();
                    PopEventSchedule.Value = DateTime.Parse(eventDetails.EventDate);
                    PopEventPubSett.SelectedItem = eventDetails.PublishStatus;
                }
                else
                {
                    MessageBox.Show("Event not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Close the form if the event is not found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading event details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form on error
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        //Save Button to save and update the event details
        private void PopEventSave_Click(object sender, EventArgs e)
        {
            try
            {
               // Create an updated event object with details from the form fields.

                var updatedEvent = new Event
                {
                    Id = eventId,
                    EventName = PopEventName.Text.Trim(),
                    EventDescription = PopEventDesc.Text.Trim(),
                    EventType = PopEventType.SelectedItem?.ToString(),
                    PublishStatus = PopEventPubSett.SelectedItem?.ToString(),
                    AttendanceLimit = int.Parse(PopEventAttend.Text.Trim()),
                    EventDate = PopEventSchedule.Value.ToString("yyyy-MM-dd HH:mm:ss"),

                };

                // Save the updated event
                if (eventQueries.UpdateEvent(updatedEvent))
                {
                    MessageBox.Show("Event updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form after saving
                }
                else
                {
                    MessageBox.Show("Failed to update event. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Triggers when Discard button is pressed to close the form without saving
        private void PopEventDiscard_Click(object sender, EventArgs e)
        {
            {
                this.Close(); 
            }
        }

        private void PopEventName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}