using CRM_system.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRM_system.Admins_Forms
{
    public partial class Admins_Events : Form
    {
        private string imagePath; // To store the selected image path

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

            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please upload an image for the event.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            if (eventQueries.AddEvent(name, description, location_id, event_type, schedule, publishStatus, imagePath, result, fee_id, 8))
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
                imagePath = null; // Reset the image path

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
                        imagePath = openFileDialog.FileName;

                        // Display the file name in the Label
                        adlblFileName.Text = System.IO.Path.GetFileName(imagePath);

                        // Hide any previous error
                        lblImageError.Visible = false;
                        Console.WriteLine($"Image Path: {imagePath}");
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

        private void adEventsDiscardUp_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear all input fields
                adEventInName.Text = string.Empty;
                adEventInDescription.Text = string.Empty;
                eventLocationBox.Text = string.Empty;
                attendLimBox.Text = string.Empty;


                adEventInContentType.SelectedIndex = -1; // Reset the combo box
                adEventInSchedule.Value = DateTime.Now; // Reset the DateTimePicker
                adEventInPublish.SelectedIndex = -1; // Reset the combo box
                adlblFileName.Text = "No file chosen"; // Reset the file name
                imagePath = null; // Reset the image path

                //Clear all input fields
                //Location Values
                eventLocationBox.Text = string.Empty;
                postCodeBox.Text = string.Empty;
                cityBox.Text = string.Empty;

                // Fee Values
                currencyBox.Text = string.Empty;
                feeBox.Text = string.Empty;

                // Hide any error labels
                lblImageError.Visible = false;

                Console.WriteLine("All inputs and image upload have been cleared.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error discarding upload: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
