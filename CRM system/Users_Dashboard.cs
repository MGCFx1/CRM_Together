using System;
using System.Windows.Forms;

namespace CRM_system
{
    public partial class Users_Dashboard : Form
    {
        private int CurrentUserId; // To store the logged-in user's ID

        //References to all the forms that can be opened in the the sidebar.
        dashboard_form dashboard;
        Memberships_Form memberships;
        Events_Forms events;
        eLearning_Form eLearning;
        Contacts_Form contacts;
        Accounts_Forms accounts;

        bool sidebarExpand;
        public Users_Dashboard(int userId)
        {
            InitializeComponent();

            // Set the user's account name in the sidebar
            pnAccount.Text = "           " + UserSession.Name.Split(' ')[0] + "'s \n           Account";
            CurrentUserId = userId; // Set the logged-in user's ID

            if (events == null)
            {
                events = new Events_Forms();
                events.FormClosed += Events_FormClosed;
                events.MdiParent = this;
                events.Show();
            }
            else
            {
                events.Activate();
            }
        }


        /// <summary>
        /// Timer to handle sidebar expand/collapse animation
        /// </summary>
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                ///if sidebar is already on expand, then minimise
                sidebar.Width = 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                { 
                  sidebarExpand = false;
                  sidebarTimer.Stop();
            }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }

        }

        //Activate the timer when menu button is clicked
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        //Activate timer when the title is clicked
        private void NavTitle_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        /// <summary>
        /// Button to close the application
        /// </summary>
        private void Signup_close_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // If the user clicks Yes, close the application
                Application.Exit();
            }
            // If the user clicks No, do nothing and return to the application
        }

        /// <summary>
        /// Reset the dashboard reference when the form is closed
        /// </summary>
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        /// <summary>
        /// Hnaldes the membership button sidebar to open the memberships form
        /// </summary>
        private void pnMemberships_Click(object sender, EventArgs e)
        {
            if (memberships == null)
            {
                memberships = new Memberships_Form();
                memberships.FormClosed += Memberships_FormClosed;
                memberships.MdiParent = this;
                memberships.Show();
            }
            else
            {
                memberships.Activate();
            }
        }

        //Reset the memberships form reference when closed.
        private void Memberships_FormClosed(object sender, FormClosedEventArgs e)
        {
            memberships = null;
        }

        /// <summary>
        /// All handlers are similar to the membership button logic.
        /// </summary>
        private void PnEvents_Click(object sender, EventArgs e)
        {
            if (events == null)
            {
                events = new Events_Forms();
                events.FormClosed += Events_FormClosed;
                events.MdiParent = this;
                events.Show();
            }
            else
            {
                events.Activate();
            }
        }

        private void Events_FormClosed(object sender, FormClosedEventArgs e)
        {
            events = null;
        }

        private void PneLearning_Click(object sender, EventArgs e)
        {
            if (eLearning == null)
            {
                eLearning = new eLearning_Form();
                eLearning.FormClosed += ELearning_FormClosed;
                eLearning.MdiParent = this;
                eLearning.Show();
            }
            else
            { 
                eLearning.Activate(); 
            }
        }

        private void ELearning_FormClosed(object sender, FormClosedEventArgs e)
        {
            eLearning = null;
        }

        private void pnContacts_Click(object sender, EventArgs e)
        {
            if (contacts == null)
            {
                contacts = new Contacts_Form();
                contacts.FormClosed += Contacts_FormClosed;
                contacts.MdiParent = this;
                contacts.Show();
            }    
            else
            {
                contacts.Activate();
            }
        }

        private void Contacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            contacts = null;
        }

        private void pnAccount_Click(object sender, EventArgs e)
        {
            if (accounts == null)
            {
                accounts = new Accounts_Forms();
                accounts.FormClosed += Accounts_FormClosed;
                accounts.MdiParent = this;
                accounts.Show();

            }
            else
            {
                accounts.Activate();
            }    
        }

        private void Accounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            accounts = null;
        }

        private void pnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new dashboard_form();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();

            }
        }

        /// <summary>
        /// Button for user's log out and redirection to landing page
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { 
                this.Hide();

                // Redirect user to the landing page
                var landingPage = new Landing_Page();
                landingPage.Show();
                this.Dispose();// Dispose the current form to free up resources
            }
            // If No, do nothing
        }

        /// <summary>
        /// Button for the notifications to activiate the notification form
        /// </summary>
        private void adNotification_Click(object sender, EventArgs e)
        {
            NotificationsForm notificationsForm = new NotificationsForm(CurrentUserId);
            notificationsForm.Show();
        }

    }
}
