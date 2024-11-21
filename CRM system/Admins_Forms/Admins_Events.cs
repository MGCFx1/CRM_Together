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

                if (string.IsNullOrEmpty(imagePath))
                {
                    MessageBox.Show("Please upload an image for the event.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add the event to the database
                if (eventQueries.AddEvent(name, description, location, contentType, schedule, publishStatus, imagePath))
                {
                    MessageBox.Show("Event uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear fields after successful upload
                    adEventInName.Text = string.Empty;
                    adEventInDescription.Text = string.Empty;
                    adEventInLoaction.Text = string.Empty;
                    adEventInContentType.SelectedIndex = -1;
                    adEventInSchedule.Value = DateTime.Now;
                    adEventInPublish.SelectedIndex = -1;
                    adlblFileName.Text = "No file chosen"; // Reset the file name display
                    imagePath = null; // Reset the image path
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
                adEventInLoaction.Text = string.Empty;
                adEventInContentType.SelectedIndex = -1; // Reset the combo box
                adEventInSchedule.Value = DateTime.Now; // Reset the DateTimePicker
                adEventInPublish.SelectedIndex = -1; // Reset the combo box
                adlblFileName.Text = "No file chosen"; // Reset the file name
                imagePath = null; // Reset the image path

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
    }
}
