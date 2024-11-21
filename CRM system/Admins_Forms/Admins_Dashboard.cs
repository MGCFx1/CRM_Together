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
    public partial class Admins_Dashboard : Form
    {
        
        private DB.UserQueries userQueries;

        public Admins_Dashboard()
        {
            InitializeComponent();

           
            userQueries = new DB.UserQueries();

            // Load the data for the admin dashboard
            LoadDashboardData();
        }

        // Method to  display data on the dashboard
        private void LoadDashboardData()
        {
            try
            {
                // Fetch the total number of registered users
                int totalMembers = userQueries.GetUserCount();

                // Update the adMemberCount label with the count
                adMemberCount.Text = totalMembers.ToString();
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adMemberCount_Click(object sender, EventArgs e)
        {
          
        }

        private void adUser_Click(object sender, EventArgs e)
        {

        }
    }
}
