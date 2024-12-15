using CRM_system.DB;
using System;
using CRM_system.Models;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CRM_system.Admins_Forms
{
    public partial class Admin_Edit_Content : Form
    {
        private readonly ContentQueries contentQueries;
        private readonly int contentId;
        public Admin_Edit_Content(int contentId)
        {
            InitializeComponent();
            this.contentQueries = new ContentQueries();
            this.contentId = contentId;

            LoadContentDetails(); // Load the content data into the form fields
        }

        //Fetch and load the content details into the form based on EventID
        private void LoadContentDetails()
        {
            try
            {
                Console.WriteLine("ID: " + this.contentId);
                // Fetch content details by ID
                var contentDetails = contentQueries.GetContentById(contentId);

                if (contentDetails != null)
                {
                    // Populate the form fields
                    PopContentName.Text = contentDetails.Title;
                    PopContentDesc.Text = contentDetails.Description;
                    PopContentType.SelectedItem = contentDetails.ContentType;
                    //PopContentAttend.Text = contentDetails.AttendanceLimit.ToString();
                    //PopContentSchedule.Value = DateTime.Parse(contentDetails.UpdatedAt);
                    PopContentPubSett.SelectedItem = contentDetails.PublishStatus;
                }
                else
                {
                    MessageBox.Show("Content not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Close the form if the content is not found
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show($"Error loading content details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Close the form on error
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        //Save Button to save and update the content details
        private void PopEventSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an updated content object with details from the form fields.

                var updatedContent = new Contents
                {
                    Id = contentId,
                    Title = PopContentName.Text.Trim(),
                    Description = PopContentDesc.Text.Trim(),
                    ContentType = PopContentType.SelectedItem?.ToString(),
                    PublishStatus = PopContentPubSett.SelectedItem?.ToString(),
                    //AttendanceLimit = int.Parse(PopContentAttend.Text.Trim()),
                    //EventDate = PopContentSchedule.Value.ToString("yyyy-MM-dd HH:mm:ss"),

                };

                // Save the updated content
                if (contentQueries.updateContent(updatedContent))
                {
                    MessageBox.Show("Content updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form after saving
                }
                else
                {
                    MessageBox.Show("Failed to update content. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
