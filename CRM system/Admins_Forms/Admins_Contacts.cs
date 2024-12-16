using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CRM_system.Admins_Forms
{
    public partial class Admins_Contacts : Form
    {
        private DB.UserQueries userQueries;
        private DataTable contacts; // Store contacts for filtering
        private List<Models.User> pendingUsers;

        public Admins_Contacts()
        {
            InitializeComponent();
            userQueries = new DB.UserQueries();
            LoadMemberContacts();
            LoadData();
        }

        /// <summary>
        /// Loads pending user data into the form's panels.
        /// Displays up to 2 pending users.
        /// </summary>
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

        /// <summary>
        /// Clears and reinitializs the forms components and reloads data.
        /// </summary>
        public void ReinitializeForm()
        {
            Controls.Clear(); // Clear all controls
            InitializeComponent(); // Reinitialize components
            LoadData(); // Re-fetch data or set the state
            LoadMemberContacts();
        }

        /// <summary>
        /// Loads all member contacts from the database and binds them to a DataGridView.
        /// </summary>
        private void LoadMemberContacts()
        {
            try
            {
                // Fetch all member contacts
                contacts = userQueries.GetAllMemberContacts();

                // Bind the data to the DataGridView
                adMemberList.DataSource = contacts;

                // DataGridView appearance
                adMemberList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                adMemberList.AllowUserToAddRows = false;
                adMemberList.ReadOnly = true;

                // Header Font
                var customFont = new Font("Poppins", 9, FontStyle.Bold);
                foreach (DataGridViewColumn column in adMemberList.Columns)
                {
                    column.HeaderCell.Style.Font = customFont;
                }

                // Column headers text
                adMemberList.Columns["ID"].HeaderText = "Member ID";
                adMemberList.Columns["Name"].HeaderText = "Full Name";
                adMemberList.Columns["Email"].HeaderText = "Email Address";
                adMemberList.Columns["Membership Status"].HeaderText = "Status";
                adMemberList.Columns["Membership Type"].HeaderText = "Membership Type";
                adMemberList.Columns["last_login"].HeaderText = "Last Login";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading member contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Filters the contact list based on the search text entered by the admin.
        /// </summary>
        private void adMemberSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the search text from the textbox
                string searchText = adMemberSearch.Text.Trim();

                if (!string.IsNullOrEmpty(searchText))
                {
                    // Apply filter using DataView
                    DataView dv = contacts.DefaultView;
                    dv.RowFilter = $"Convert(ID, 'System.String') LIKE '%{searchText}%' " +
                                   $"OR Name LIKE '%{searchText}%' " +
                                   $"OR Email LIKE '%{searchText}%' " +
                                   $"OR [Membership Status] LIKE '%{searchText}%' " +
                                   $"OR [Membership Type] LIKE '%{searchText}%'";
                }
                else
                {
                    // Clear the filter if the search box is empty
                    contacts.DefaultView.RowFilter = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Refreshes the contact list when the refresh button is clicked.
        /// </summary>
        private void adMembersRef_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMemberContacts();
                MessageBox.Show("List refreshed successfully.", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing the list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deletes the selected member from the database.
        /// </summary>
        private void adMembersRemove_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (adMemberList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedUserId = Convert.ToInt32(adMemberList.SelectedRows[0].Cells["ID"].Value);

                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // Remove user from database
                    if (userQueries.RemoveUserById(selectedUserId))
                    {
                        MessageBox.Show("User removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMemberContacts();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        /// <summary>
        /// Adds a new member to the database after validating input fields.
        /// </summary>
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

                    // Refresh the DataGridView to show the new member
                    LoadMemberContacts();

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



        private void adMemberbtn_Click_1(object sender, EventArgs e)
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

                    // Refresh the DataGridView to show the new member
                    LoadMemberContacts();

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

        /// <summary>
        /// Validates if the provided email format is correct.
        /// </summary>
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
    }
}
