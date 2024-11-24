using CRM_system.Models;
using CRM_system.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CRM_system.Admins_Forms
{
    public partial class Admins_Dashboard : Form
    {
        private DB.UserQueries userQuery;
        private DB.EventQueries eventQuery;

        public Admins_Dashboard()
        {
            InitializeComponent();
            userQuery = new DB.UserQueries();
            eventQuery = new DB.EventQueries(); // Initialize EventQueries
            LoadData();
            Console.WriteLine("Dashboard Initialized!");
        }

        public void LoadData()
        {
            try
            {
                // Fetch the total number of registered users
                int totalMembers = userQuery.GetUserCount();
                adMemberCount.Text = totalMembers.ToString();

                // Fetch the total number of active events
                int totalActiveEvents = eventQuery.GetActiveEventCount();
                adEventCount.Text = totalActiveEvents.ToString(); // Update the adEventCount label

                // Fetch pending users
                List<Models.User> pendingUsers = userQuery.GetUsersByStatus("pending");

                // Display up to 3 pending users
                for (int i = 0; i < pendingUsers.Count && i < 3; i++)
                {
                    if (i == 0)
                    {
                        panel11.Visible = true;
                        adMemberReqName1.Text = pendingUsers[i].Name;
                        adMemberReqEmail1.Text = pendingUsers[i].Email;
                    }
                    else if (i == 1)
                    {
                        panel12.Visible = true;
                        adMemberReqName2.Text = pendingUsers[i].Name;
                        adMemberReqEmail2.Text = pendingUsers[i].Email;
                    }
                    else
                    {
                        panel13.Visible = true;
                        adMemberReqName3.Text = pendingUsers[i].Name;
                        adMemberReqEmail3.Text = pendingUsers[i].Email;
                    }
                }

                // Hide unused panels if there are fewer than 3 pending users
                if (pendingUsers.Count < 1) panel11.Visible = false;
                if (pendingUsers.Count < 2) panel12.Visible = false;
                if (pendingUsers.Count < 3) panel13.Visible = false;
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReinitializeForm()
        {
            Controls.Clear(); // Clear all controls
            InitializeComponent(); // Reinitialize components
            LoadData(); // Re-fetch data or set the state
        }

        private void adMemberReqApp1_Click(object sender, EventArgs e)
        {
            List<Models.User> pendingUsers = userQuery.GetUsersByStatus("pending");
            var currentUser = pendingUsers[0];
            string status = "active";

            userQuery.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID);
            ReinitializeForm();
        }

        private void adMemberReqDec1_Click(object sender, EventArgs e)
        {
            List<Models.User> pendingUsers = userQuery.GetUsersByStatus("pending");

            var currentUser = pendingUsers[0];
            string status = "inactive";

            userQuery.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID);
            ReinitializeForm();
        }

        private void adMemberReqApp2_Click(object sender, EventArgs e)
        {
            List<Models.User> pendingUsers = userQuery.GetUsersByStatus("pending");
            var currentUser = pendingUsers[1];
            string status = "active";

            userQuery.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID);
            ReinitializeForm();
        }

        private void adMemberReqDec2_Click(object sender, EventArgs e)
        {
            List<Models.User> pendingUsers = userQuery.GetUsersByStatus("pending");

            var currentUser = pendingUsers[1];
            string status = "inactive";

            userQuery.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID);
            ReinitializeForm();
        }

        private void adMemberReqApp3_Click(object sender, EventArgs e)
        {
            List<Models.User> pendingUsers = userQuery.GetUsersByStatus("pending");
            var currentUser = pendingUsers[2];
            string status = "active";

            userQuery.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID);
            ReinitializeForm();
        }

        private void adMemberReqDec3_Click(object sender, EventArgs e)
        {
            List<Models.User> pendingUsers = userQuery.GetUsersByStatus("pending");

            var currentUser = pendingUsers[2];
            string status = "inactive";

            userQuery.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID);
            ReinitializeForm();
        }

        private void adEventCount_Click(object sender, EventArgs e)
        {

        }

        private void adMemberCount_Click(object sender, EventArgs e)
        {

        }
    }
}