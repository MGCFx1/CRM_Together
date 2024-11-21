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

namespace CRM_system.Admins_Forms
{
    public partial class Admins_Events : Form
    {
        public Admins_Events()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var eventQueries = new CRM_system.DB.EventQueries();

                // Get values from the input fields
                string name = adEventInName.Text.Trim();
                string description = adEventInDescription.Text.Trim();
                string location = adEventInLoaction.Text.Trim();
                string contentType = adEventInContentType.SelectedItem?.ToString(); 
                string schedule = adEventInSchedule.Value.ToString("yyyy-MM-dd HH:mm:ss"); 
                string publishStatus = adEventInPublish.SelectedItem?.ToString(); 

                // Validate required fields
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Event Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(publishStatus))
                {
                    MessageBox.Show("Please select a publish status (Public, Private, Draft).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add the event to the database
                if (eventQueries.AddEvent(name, description, location, contentType, schedule, publishStatus))
                {
                    MessageBox.Show("Event uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear fields after successful upload
                    adEventInName.Text = string.Empty;
                    adEventInDescription.Text = string.Empty;
                    adEventInLoaction.Text = string.Empty;
                    adEventInContentType.SelectedIndex = -1; 
                    adEventInSchedule.Value = DateTime.Now; 
                    adEventInPublish.SelectedIndex = -1; 
                }
                else
                {
                    MessageBox.Show("Failed to upload event. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

