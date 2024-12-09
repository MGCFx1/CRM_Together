using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace CRM_system.Admins_Forms.ContactsSubmenu
{
    public partial class Manage_Contacts : Form
    {
        private DB.UserQueries userQueries;
        private DataTable contacts; // Store contacts for filtering
        private List<Models.User> pendingUsers;

        public Manage_Contacts()
        {
            InitializeComponent();
            userQueries = new DB.UserQueries();

            LoadData();
        }

        public void LoadData()
        {
            pendingUsers = userQueries.GetUsersByStatus("pending");

            for (int i = 0; i < pendingUsers.Count && i < 2; i++)
            {
                if (i == 0)
                {
                    panel15.Visible = true;
                    label14.Text = pendingUsers[i].Name;
                    label13.Text = pendingUsers[i].Email;
                }
                else
                {
                    panel16.Visible = true;
                    label17.Text = pendingUsers[i].Name;
                    label16.Text = pendingUsers[i].Email;
                }
            }
        }

        public void ReinitializeForm()
        {
            Controls.Clear(); // Clear all controls
            InitializeComponent(); // Reinitialize components
            LoadData(); // Re-fetch data or set the state

        }

        private void adMemberbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = adFullNameAdd.Text.Trim();
                string email = adEmailAddressAdd.Text.Trim();
                string password = adPasswordAdd.Text.Trim();

                // Validation flags
                bool isValid = true;

                // Email validation
                if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
                {
                    lblEmailError.Text = "Please enter a valid email address.";
                    lblEmailError.Visible = true;
                    isValid = false;
                }
                else
                {
                    lblEmailError.Visible = false;
                }

                // Password validation
                if (string.IsNullOrEmpty(password) || password.Length < 8)
                {
                    lblPasswordError.Text = "Password must be at least 8 characters.";
                    lblPasswordError.Visible = true;
                    isValid = false;
                }
                else
                {
                    lblPasswordError.Visible = false;
                }

                if (!isValid)
                {
                    return;
                }

                if (userQueries.AddNewMember(fullName, email, password))
                {
                    MessageBox.Show("Member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //// Refresh the DataGridView to show the new member
                    //LoadMemberContacts();

                    // Clear input fields and hide error labels
                    adFullNameAdd.Text = string.Empty;
                    adEmailAddressAdd.Text = string.Empty;
                    adPasswordAdd.Text = string.Empty;
                    adInterestAdd.Text = string.Empty;

                    lblEmailError.Visible = false;
                    lblPasswordError.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to add the member. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //helper method to validate email address
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void adEmailAddressAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var currentUser = pendingUsers[0];
            string status = "active";

            userQueries.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID, currentUser.MembershipType);
            ReinitializeForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var currentUser = pendingUsers[0];
            string status = "inactive";

            userQueries.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID, currentUser.MembershipType);

            ReinitializeForm();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var currentUser = pendingUsers[1];
            string status = "active";

            userQueries.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID, currentUser.MembershipType);
            ReinitializeForm();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var currentUser = pendingUsers[1];
            string status = "inactive";

            userQueries.UpdateUser(currentUser.Id, currentUser.Name, currentUser.Email, currentUser.Password, status, currentUser.LocationID, currentUser.MembershipType);
            ReinitializeForm();
        }
    }
 }
