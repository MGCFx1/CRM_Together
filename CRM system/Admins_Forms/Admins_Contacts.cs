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
    public partial class Admins_Contacts : Form
    {
        private DB.UserQueries userQueries;
        private DataTable contacts; // Store contacts for filtering

        public Admins_Contacts()
        {
            InitializeComponent();
            userQueries = new DB.UserQueries();
            LoadMemberContacts();
        }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading member contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adMemberSearchbtn_Click(object sender, EventArgs e)
        {

        }

        private void adMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

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
                                   $"OR [Membership Status] LIKE '%{searchText}%'";
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

        private void adMembersRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (adMemberList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected user's ID
                int selectedUserId = Convert.ToInt32(adMemberList.SelectedRows[0].Cells["ID"].Value);

                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // Attempt to remove the user from the database
                    if (userQueries.RemoveUserById(selectedUserId))
                    {
                        MessageBox.Show("User removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView
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
    }
}