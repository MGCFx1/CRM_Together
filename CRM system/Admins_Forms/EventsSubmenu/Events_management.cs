using CRM_system.DB;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace CRM_system.Admins_Forms.EventsSubmenu
{
    public partial class Events_management : Form
    {
        private EventQueries eventQuery; // For handling event-related database queries
        private Image selectedImage; // To store the selected image

        public Events_management()
        {
            InitializeComponent();
            eventQuery = new EventQueries(); // Initialize EventQueries
        }

        // Method to validate inputs and add an event
        private void AddEvent()
        {
            try
            {
                var locationQueries = new LocationQueries();
                var feeQueries = new FeeQueries();

                // Event Values
                string name = adEventInName.Text.Trim();
                string description = adEventInDescription.Text.Trim();
                string attendanceLimit = attendLimBox.Text.Trim();
                string eventType = adEventInContentType.SelectedItem?.ToString();
                string schedule = adEventInSchedule.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string publishStatus = adEventInPublish.SelectedItem?.ToString();

                // Location Values
                string address = eventLocationBox.Text.Trim();
                string postcode = postCodeBox.Text.Trim();
                string city = cityBox.Text.Trim();

                // Fee Values
                string feeType = "Event";
                string currency = currencyBox.Text.Trim();
                string fee = feeBox.Text;

                // Validate Inputs
                if (string.IsNullOrEmpty(name)) throw new Exception("Event Name is required.");
                if (string.IsNullOrEmpty(description)) throw new Exception("Event Description is required.");
                if (string.IsNullOrEmpty(schedule)) throw new Exception("Event Date is needed.");
                if (string.IsNullOrEmpty(attendanceLimit) || !int.TryParse(attendanceLimit, out int result))
                    throw new Exception("Event attendee limit must be a valid integer.");
                if (string.IsNullOrEmpty(publishStatus)) throw new Exception("Publish Status is required.");
                if (string.IsNullOrEmpty(address)) throw new Exception("Address is required.");
                if (string.IsNullOrEmpty(city)) throw new Exception("City is required.");
                if (string.IsNullOrEmpty(postcode)) throw new Exception("Postcode is required.");
                if (string.IsNullOrEmpty(currency)) throw new Exception("Currency is required.");
                if (string.IsNullOrEmpty(fee) || !float.TryParse(fee, out float resultFee))
                    throw new Exception("Fee must be a valid number.");

                // Insert Location and Fee
                int locationId = locationQueries.InsertNewLocation(city, address, postcode);
                int feeId = feeQueries.InsertFee(feeType, resultFee, currency, "Event Fee");

                // Add Event to Database
                if (eventQuery.AddEvent(name, description, locationId, eventType, schedule, publishStatus, selectedImage, result, feeId, 8))
                {
                    MessageBox.Show("Event added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs(); // Clear all input fields after a successful operation
                }
                else
                {
                    throw new Exception("Failed to add event. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear all input fields
        private void ClearInputs()
        {
            adEventInName.Text = string.Empty;
            adEventInDescription.Text = string.Empty;
            eventLocationBox.Text = string.Empty;
            postCodeBox.Text = string.Empty;
            cityBox.Text = string.Empty;
            attendLimBox.Text = string.Empty;
            adEventInContentType.SelectedIndex = -1; // Reset ComboBox
            adEventInSchedule.Value = DateTime.Now; // Reset DateTimePicker
            adEventInPublish.SelectedIndex = -1; // Reset ComboBox
            currencyBox.Text = string.Empty;
            feeBox.Text = string.Empty;
            adlblFileName.Text = "No file chosen"; // Reset file name label
            selectedImage = null; // Reset selected image
        }

        // Upload Image Logic
        private void UploadImage()
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    openFileDialog.Title = "Select an Image";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedImage = Image.FromFile(openFileDialog.FileName);
                        adlblFileName.Text = Path.GetFileName(openFileDialog.FileName);
                        MessageBox.Show("Image uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to upload image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button to add event input details and stores them in the db
        private void adEventSave_Click(object sender, EventArgs e)
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

        //Button to clear all the input fields that was inserted.
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

        //Button to open a dialog to upload images.
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
    }
}
