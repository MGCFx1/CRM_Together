using CRM_system.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_system.Admins_Forms
{
    public partial class Admins_Learning : Form
    {
        //private string selectedImage; // To store the selected image path
        Image selectedImage;
        private ContentQueries contentQuery; // For handling content-related database queries
        private FeeQueries feeQuery;

        public Admins_Learning()
        {
            InitializeComponent();
            contentQuery = new ContentQueries(); // Initialize EventQueries
            feeQuery = new FeeQueries();
            LoadContent(); // Load events on form load
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
            var locationQueries = new CRM_system.DB.LocationQueries();
            var feeQueries = new CRM_system.DB.FeeQueries();

            // To Manage the case of Everything
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            // Content Values
            string title = adContentInName.Text.Trim();
            string description = adContentInDescription.Text.Trim();
            //string attendance_limit = attendLimBox.Text.Trim();
            string content_type = adInContentType.SelectedItem?.ToString();
            string schedule = adContentInSchedule.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string publishStatus = adContentInPublish.SelectedItem?.ToString();

            // Fee Values
            string fee_type = "Service";
            string currency = currencyBox.Text.Trim();
            string fee = feeBox.Text;


            //// Validate Content required fields
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Content Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(content_type))
            {
                MessageBox.Show("Content type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate required fields
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Content Description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate required fields
            if (string.IsNullOrEmpty(schedule))
            {
                MessageBox.Show("Content Date is needed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate required fields
            //if (string.IsNullOrEmpty((attendance_limit)))
            //{
            //    MessageBox.Show("Content attendee limit is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (string.IsNullOrEmpty(publishStatus))
            {
                MessageBox.Show("Please select a publish status (Public, Private, Draft).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if (Image.IsNullOrEmpty(selectedImage))
            //{
            //    MessageBox.Show("Please upload an image for the content.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

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

            int fee_id = feeQueries.InsertFee(fee_type, result_fee, currency, "Content Fee");

            //// Add the content to the database                                                                                  //change to UserSession.ID after testing
            if (contentQuery.AddContent(title, content_type, description, selectedImage, publishStatus, fee_id, 8))
            {
                MessageBox.Show("Content uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear all input fields on successful upload
                adContentInName.Text = string.Empty;
                adContentInDescription.Text = string.Empty;
                eventLocationBox.Text = string.Empty;
                attendLimBox.Text = string.Empty;


                adInContentType.SelectedIndex = -1; // Reset the combo box
                adContentInSchedule.Value = DateTime.Now; // Reset the DateTimePicker
                adContentInPublish.SelectedIndex = -1; // Reset the combo box
                adlblFileName.Text = "No file chosen"; // Reset the file name
                selectedImage = null; // Reset the image path

                //Clear all input fields

                // Fee Values
                currencyBox.Text = string.Empty;
                feeBox.Text = string.Empty;
                LoadContent();
            }
            else
            {
                MessageBox.Show("Failed to upload content. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error uploading content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        //Open dialog to allow user to upload an image for the content
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
                        // Load the selected file into an Image object
                        selectedImage = Image.FromFile(openFileDialog.FileName);
                        Console.WriteLine(selectedImage);

                        // Display the image in a PictureBox
                        //pictureBox1.Image = selectedImage;

                        MessageBox.Show("Image uploaded and saved successfully!");

                        // Display the file name in the Label
                        //adlblFileName.Text = System.IO.Path.GetFileName(selectedImage);

                        // Hide any previous error
                        lblImageError.Visible = false;
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
                adContentInName.Text = string.Empty;
                adContentInDescription.Text = string.Empty;
                eventLocationBox.Text = string.Empty;
                attendLimBox.Text = string.Empty;


                adInContentType.SelectedIndex = -1; // Reset the Content Type
                adContentInSchedule.Value = DateTime.Now; // Reset the Content date
                adContentInPublish.SelectedIndex = -1; // Reset the publish settings

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
        private void LoadContent()
        {
            //try
            //{
                // Fetch all events as a list
                var content = contentQuery.GetAllContentAsList();
                //var fee = feeQuery.GetFeeById();

                // Bind the events to the DataGridView
                dgContent.DataSource = content;

                // Adjust column headers to match the database schema
                dgContent.Columns["ID"].HeaderText = "Content ID";
                dgContent.Columns["Title"].HeaderText = "Title";
                dgContent.Columns["Description"].HeaderText = "Description";
                dgContent.Columns["ContentType"].HeaderText = "Type";
                //Add Count for User Content to count the number of members joined
                //dgContent.Columns["AttendanceLimit"].HeaderText = "Limit";
                //Add Content Fee by getting the fee from the fee table
                dgContent.Columns["PublishStatus"].HeaderText = "Status";
                dgContent.Columns["Currency"].HeaderText = "Currency";
                dgContent.Columns["Amount"].HeaderText = "Fee";
                dgContent.Columns["CreatedAt"].HeaderText = "Publish Date";
                dgContent.Columns["UpdatedAt"].HeaderText = "Last Updated";
                dgContent.Columns["AdminID"].HeaderText = "Admin";

                // Optional: Hide unwanted columns if necessary
                //dgContent.Columns["ContentImage"].Visible = false;
                dgContent.Columns["FeeID"].Visible = false;
                dgContent.Columns["AdminID"].Visible = false;
                dgContent.Columns["TierRequirement"].Visible = false;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error loading content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

        private void dgContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Refresh Events button to refresh the content's list
        private void btnLoadContent_Click(object sender, EventArgs e)
        {
            try
            {
                LoadContent();
                // Inform the user that the list has been refreshed
                MessageBox.Show("Content list refreshed successfully.", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //handle any errors
                MessageBox.Show($"Error refreshing the content list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button to remove any chosen events from the database
        private void btnRemoveContent_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an content is selected
                if (dgContent.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an content to remove.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the ID of the selected content
                int selectedContentId = Convert.ToInt32(dgContent.SelectedRows[0].Cells["Id"].Value);
            Console.WriteLine(dgContent.SelectedRows[0].Cells["Id"].Value);

                // Confirm the removal
                var confirmResult = MessageBox.Show("Are you sure you want to remove the selected Content?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Remove the content from the database
                if (contentQuery.DeleteContent(selectedContentId))
                {
                    MessageBox.Show("Content removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView
                    LoadContent();
                }
                else
                {
                    MessageBox.Show("Failed to remove the content. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditEvents_Click(object sender, EventArgs e)
        {
            if (dgContent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an content to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedContentId = Convert.ToInt32(dgContent.SelectedRows[0].Cells["ID"].Value);

            Console.WriteLine(selectedContentId);

            // Open the EditEventForm
            var editForm = new Admin_Edit_Content(selectedContentId);
            editForm.ShowDialog(); // Show the form as a modal dialog

            // Refresh the content list after editing
            LoadContent();
        }

        private void AdSearchEvents_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the search text from the textbox
                string searchText = AdSearchEvents.Text.Trim();

                // Cast the DataSource of dgContent back to a list of events
                var contents = (List<Models.Contents>)dgContent.DataSource;

                if (!string.IsNullOrEmpty(searchText))
                {
                    // Filter the events list based on the search text
                    var filteredEvents = contents.Where(content =>
                        content.Id.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        content.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        content.ContentType.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        content.Description.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        content.PublishStatus.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                    // Update the DataGridView with the filtered list
                    dgContent.DataSource = filteredEvents;
                }
                else
                {
                    // Reload the full list of events if the search box is empty
                    LoadContent();
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
