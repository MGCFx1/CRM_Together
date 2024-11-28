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
    public partial class Users_Dashboard : Form
    {
        dashboard_form dashboard;
        Memberships_Form memberships;
        Events_Forms events;
        eLearning_Form eLearning;
        Contacts_Form contacts;
        Accounts_Forms accounts;

        bool sidebarExpand;
        public Users_Dashboard()
        {
            InitializeComponent();
            //pnAccount.Text = "           " + UserSession.Name.Split(' ')[0] + "'s \n           Account";
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

        private void Users_Dashboard_Load(object sender, EventArgs e)
        {

        }

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

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void NavTitle_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void Signup_close_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // If the user clicks Yes, close the application
                Application.Exit();
            }
            // If the user clicks No, do nothing and return to the application
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            else {
            dashboard.Activate();

            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

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

        private void Memberships_FormClosed(object sender, FormClosedEventArgs e)
        {
            memberships = null;
        }

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hide the current form 
                this.Hide();

                // Show the Landing_Page
                var landingPage = new Landing_Page();
                landingPage.Show();

                // Dispose the current form to free up resources
                this.Dispose();
            }
            // If No, do nothing
        }

        private void adUserProf_Click(object sender, EventArgs e)
        {

        }
    }
}
