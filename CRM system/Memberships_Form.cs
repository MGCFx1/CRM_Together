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
    public partial class Memberships_Form : Form
    {
        private UserQueries userQueries;

        public Memberships_Form()
        {
            InitializeComponent();
            userQueries = new UserQueries(); // Initialize the UserQueries instance

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCommunityMembership_Click(object sender, EventArgs e)
        {
            SaveMembership(1);
        }

        private void btnWorkspaceMembership_Click(object sender, EventArgs e)
        {
            SaveMembership(2);
        }

        // Saves the selected membership to the database.
  
        private void SaveMembership(int membershipId)
        {
            try
            {
                int userId = UserSession.ID; // Get the logged-in user's ID

                // Check if the user already has an active membership
                if (userQueries.HasActiveMembership(userId))
                {
                    MessageBox.Show("You already have an active membership.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Add the membership for the user
                bool success = userQueries.AddMembership(userId, membershipId, DateTime.UtcNow.ToString("yyyy-MM-dd"));
                if (success)
                {
                    MessageBox.Show("Membership successfully activated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to activate membership. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error activating membership: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


  