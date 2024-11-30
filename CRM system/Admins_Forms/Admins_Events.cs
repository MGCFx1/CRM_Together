using CRM_system.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRM_system.Admins_Forms
{
    public partial class Admins_Events : Form
    {
        //private string selectedImage; // To store the selected image path
        Image selectedImage;
        private EventQueries eventQuery; // For handling event-related database queries


        public Admins_Events()
        {
            InitializeComponent();
            eventQuery = new EventQueries(); // Initialize EventQueries
            LoadEvents(); // Load events on form load

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                var eventQueries = new CRM_system.DB.EventQueries();
                var locationQueries = new CRM_system.DB.LocationQueries();
                var feeQueries = new CRM_system.DB.FeeQueries();

                // To Manage the case of Everything
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                // Event Values
                string name = adEventInName.Text.Trim();
                string description = adEventInDescription.Text.Trim();
                string attendance_limit = attendLimBox.Text.Trim();
                string event_type = adEventInContentType.SelectedItem?.ToString();
                string schedule = adEventInSchedule.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string publishStatus = adEventInPublish.SelectedItem?.ToString();

                //Loation Values
                string address = eventLocationBox.Text.Trim();
                string postcode = postCodeBox.Text.Trim();
                string city = cityBox.Text.Trim();

                // Fee Values
                string fee_type = "Event";
                string currency = currencyBox.Text.Trim();
                string fee = feeBox.Text;


            //// Validate Event required fields
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Event Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate required fields
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Event Description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate required fields
            if (string.IsNullOrEmpty(schedule))
            {
                MessageBox.Show("Event Date is needed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate required fields
            if (string.IsNullOrEmpty((attendance_limit)))
            {
                MessageBox.Show("Event attendee limit is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(publishStatus))
            {
                MessageBox.Show("Please select a publish status (Public, Private, Draft).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if (Image.IsNullOrEmpty(selectedImage))
            //{
            //    MessageBox.Show("Please upload an image for the event.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (!int.TryParse(attendance_limit, out int result))
            {
                MessageBox.Show("Event attendee limit must be an integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate required Location fields
            if (string.IsNullOrEmpty((address)))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validate required fields
            if (string.IsNullOrEmpty((city)))
            {
                MessageBox.Show("City is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validate required fields
            if (string.IsNullOrEmpty((postcode)))
            {
                MessageBox.Show("Postcode is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate required fields
            if (string.IsNullOrEmpty((currency)))
            {
                MessageBox.Show("Please select one of the given currencies.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(fee, out float result_fee))
            {
                MessageBox.Show("The fee must be a decimal or integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int location_id = locationQueries.InsertNewLocation(city, address, postcode);
            int fee_id = feeQueries.InsertFee(fee_type, result_fee, currency, "Event Fee");

            //// Add the event to the database                                                                                  //change to UserSession.ID after testing
            if (eventQueries.AddEvent(name, description, location_id, event_type, schedule, publishStatus, selectedImage, result, fee_id, 8))
            {
                MessageBox.Show("Event uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear all input fields on successful upload
                adEventInName.Text = string.Empty;
                adEventInDescription.Text = string.Empty;
                eventLocationBox.Text = string.Empty;
                attendLimBox.Text = string.Empty;


                adEventInContentType.SelectedIndex = -1; // Reset the combo box
                adEventInSchedule.Value = DateTime.Now; // Reset the DateTimePicker
                adEventInPublish.SelectedIndex = -1; // Reset the combo box
                adlblFileName.Text = "No file chosen"; // Reset the file name
                selectedImage = null; // Reset the image path

                //Clear all input fields
                //Location Values
                eventLocationBox.Text = string.Empty;
                postCodeBox.Text = string.Empty;
                cityBox.Text = string.Empty;

                // Fee Values
                currencyBox.Text = string.Empty;
                feeBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Failed to upload event. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error uploading event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        //Open dialog to allow user to upload an image for the event
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    openFileDialog.Title = "Select an Image";

                    // Show the dialog and check if the user selected a file
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the file path
                        //selectedImage = openFileDialog.FileName;
                        // Load the selected file into an Image object
                        selectedImage = Image.FromFile(openFileDialog.FileName);
                        Console.WriteLine(selectedImage);

                        // Display the image in a PictureBox
                        //pictureBox1.Image = selectedImage;

                        MessageBox.Show("Image uploaded and saved successfully!");

                        // Display the file name in the Label
                        //adlblFileName.Text = System.IO.Path.GetFileName(selectedImage);

                        // Hide any previous error
                        //lblImageError.Visible = false;
                        //Console.WriteLine($"Image Path: {selectedImage}");
                    }
                }
            }
            catch (Exception ex)
            {
                lblImageError.Text = "Failed to load image. Please try again.";
                lblImageError.Visible = true;
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        //Discard button to clear all input fields and hide error messeges
        private void adEventsDiscardUp_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear all input fields
                adEventInName.Text = string.Empty;
                adEventInDescription.Text = string.Empty;
                eventLocationBox.Text = string.Empty;
                attendLimBox.Text = string.Empty;


                adEventInContentType.SelectedIndex = -1; // Reset the Content Type
                adEventInSchedule.Value = DateTime.Now; // Reset the Event date
                adEventInPublish.SelectedIndex = -1; // Reset the publish settings

                // Hide any error labels
                lblImageError.Visible = false;

                Console.WriteLine("All inputs and image upload have been cleared.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error discarding upload: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to retrieve and display a list of events in a DataGridView
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

                // Optional: Hide unwanted columns if necessary
                // dgEvents.Columns["EventImage"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Refresh Events button to refresh the event's list
        private void btnLoadEvents_Click(object sender, EventArgs e)
        {
            try
            {
                LoadEvents();
                // Inform the user that the list has been refreshed
                MessageBox.Show("Event list refreshed successfully.", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //handle any errors
                MessageBox.Show($"Error refreshing the event list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button to remove any chosen events from the database
        private void btnRemoveEvents_Click(object sender, EventArgs e)
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

                    // Refresh the DataGridView
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

        private void btnEditEvents_Click(object sender, EventArgs e)
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

        private void AdSearchEvents_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the search text from the textbox
                string searchText = AdSearchEvents.Text.Trim();

                // Cast the DataSource of dgEvents back to a list of events
                var events = (List<Models.Event>)dgEvents.DataSource;

                if (!string.IsNullOrEmpty(searchText))
                {
                    // Filter the events list based on the search text
                    var filteredEvents = events.Where(ev =>
                        ev.Id.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        ev.EventName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        ev.EventType.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        ev.EventDescription.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        ev.PublishStatus.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                    // Update the DataGridView with the filtered list
                    dgEvents.DataSource = filteredEvents;
                }
                else
                {
                    // Reload the full list of events if the search box is empty
                    LoadEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adUser_Click(object sender, EventArgs e)
        {

        }
    }
}
