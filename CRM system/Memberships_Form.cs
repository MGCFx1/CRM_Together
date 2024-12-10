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
        private MembershipQueries membershipQueries;

        public Memberships_Form()
        {
            InitializeComponent();
            membershipQueries = new MembershipQueries(); // Initialize the MembershipQueries instance
        }

        private void btnCommunityMembership_Click(object sender, EventArgs e)
        {
            SaveMembership(1);
        }

        private void btnWorkspaceMembership_Click(object sender, EventArgs e)
        {
            SaveMembership(2);
        }

        /// <summary>
        /// Saves the selected membership to the database.
        /// </summary>
        private void SaveMembership(int membershipId)
        {
            try
            {
                int userId = UserSession.ID; // Get the logged-in user's ID

                // Check if the user already has an active membership
                if (membershipQueries.HasActiveMembership(userId))
                {
                    MessageBox.Show("You already have an active membership.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Fetch the duration from the Memberships table
                int durationInDays = membershipQueries.GetMembershipDuration(membershipId);
                DateTime startDate = DateTime.UtcNow;
                DateTime validUntil = startDate.AddDays(durationInDays);

                // Add the membership for the user
                bool success = membershipQueries.AddMembership(userId, membershipId, startDate.ToString("yyyy-MM-dd"), validUntil.ToString("yyyy-MM-dd"));
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