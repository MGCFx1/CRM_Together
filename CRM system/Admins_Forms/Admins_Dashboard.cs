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
        private DB.UserQueries query;
        public Admins_Dashboard()
        {
            InitializeComponent();
            query = new DB.UserQueries();
            LoadData();
            Console.WriteLine("Alright!!");
        }

        public void LoadData()
        {
            List<Models.User> pendingUsers = query.GetUsersByStatus("pending");
            Console.WriteLine(pendingUsers.Count);

            try
            {
                // Fetch the total number of registered users
                int totalMembers = query.GetUserCount();

                // Update the adMemberCount label with the count
                adMemberCount.Text = totalMembers.ToString();
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            for (int i = 0; i < pendingUsers.Count && i < 2; i++)
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
        }

        public void ReinitializeForm()
        {
            Controls.Clear(); // Clear all controls
            InitializeComponent(); // Reinitialize components
            LoadData(); // Re-fetch data or set the state
        }


        private void adMemberReqApp1_Click(object sender, EventArgs e)
        {
            List<Models.User> pendingUsers = query.GetUsersByStatus("pending");
            var currentUser = pendingUsers[0];
            string status = "active";

            query.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID);
            ReinitializeForm();
        }

        private void adMemberReqDec1_Click(object sender, EventArgs e)
        {
            List<Models.User> pendingUsers = query.GetUsersByStatus("pending");

            var currentUser = pendingUsers[0];
            string status = "inactive";

            query.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID);
            ReinitializeForm();

            // Load the data for the admin dashboard
            LoadData();
        }

        private void adMemberCount_Click(object sender, EventArgs e)
        {
          
        }

        private void adUser_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adMemberReqApp1_Click_1(object sender, EventArgs e)
        {

        }

        private void adMemberReqApp2_Click(object sender, EventArgs e)
        {

        }

        private void Admins_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void adMemberReqApp1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
