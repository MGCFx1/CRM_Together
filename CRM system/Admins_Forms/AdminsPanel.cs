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
    public partial class AdminsPanel : Form
    {
        Admins_Dashboard adDashboard;
        Admins_Contacts adContacts;
        Admins_Events adEvents;
        Admins_Learning adLearning;

        public AdminsPanel()
        {
            InitializeComponent();

            // Modularize this block
            if (adDashboard == null)
            {
                adDashboard = new Admins_Dashboard();
                adDashboard.FormClosed += AdDashboard_FormClosed;
                adDashboard.MdiParent = this;
                adDashboard.Show();
            }
            else
            {
                adDashboard.Activate();
            }
        }

        private void AdminsPanel_Load(object sender, EventArgs e)
        {

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

        private void adbtDashboard_Click(object sender, EventArgs e)
        {
            if (adDashboard == null)
            {
                adDashboard = new Admins_Dashboard();
                adDashboard.FormClosed += AdDashboard_FormClosed;
                adDashboard.MdiParent = this;
                adDashboard.Show();
            }
            else
            {
                adDashboard.Activate();
            }
        }

        private void AdDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            adDashboard = null;
        }

        private void adbtEvents_Click(object sender, EventArgs e)
        {
            if (adEvents == null)
            {
                adEvents = new Admins_Events();
                adEvents.FormClosed += AdEvents_FormClosed;
                adEvents.MdiParent = this;
                adEvents.Show();
            }
            else
            {
                adEvents.Activate();
            }
        }

        private void AdEvents_FormClosed(object sender, FormClosedEventArgs e)
        {
            adEvents = null;
        }

        private void adbtContacts_Click(object sender, EventArgs e)
        {
            if (adContacts == null)
            {
                adContacts = new Admins_Contacts();
                adContacts.FormClosed += AdContacts_FormClosed;
                adContacts.MdiParent = this;
                adContacts.Show();
            }
            else
            {
                adContacts.Activate();
            }
        }

        private void AdContacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            adContacts = null;
        }

        private void adbtLearning_Click(object sender, EventArgs e)
        {
            if (adLearning == null)
            {
                adLearning = new Admins_Learning();
                adLearning.FormClosed += AdLearning_FormClosed;
                adLearning.MdiParent = this;
                adLearning.Show();
            }
            else
            {
                adLearning.Activate();
            }
        }

        private void AdLearning_FormClosed(object sender, FormClosedEventArgs e)
        {
            adLearning = null;
        }

        private void signoutAdmin_Click(object sender, EventArgs e)
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
    }
}
