using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CRM_system.Admins_Forms
{
    public partial class AdminsPanel : Form
    {
        // Form variables
        Admins_Dashboard adDashboard;
        //Admins_Contacts adContacts;
        //Admins_Events adEvents;
        Admins_Learning adLearning;

        // Events Submenu Forms
        EventsSubmenu.Events_list adEventsList;
        EventsSubmenu.Events_management adManageEvents;
        EventsSubmenu.Events_Attendees adEventsAttendees;
        EventsSubmenu.Events_Reports adEventsReports;

        // Contacts Submenu Forms:
        ContactsSubmenu.Contacts_List adContactsList;
        ContactsSubmenu.Manage_Contacts adManageContacts;
        ContactsSubmenu.Contacts_Reports adContactsReports;

        // Dropdown logic variables
        private const int CollapsedHeight = 53; // Height when collapsed
        private const int ExpandedHeight = 209; // Height when expanded
        private const int PanelWidth = 211; // Constant width of the panel
        private const int Step = 10; // Step size for expanding/collapsing

        private bool isEventsExpanded = false; // Tracks whether the events dropdown is expanded
        private bool isContactsExpanded = false; // Tracks whether the contacts dropdown is expanded

        public AdminsPanel()
        {
            InitializeComponent();


            // Initialize dropdown panel states
            eventsContainer.Size = new Size(PanelWidth, CollapsedHeight);
            contactsContainer.Size = new Size(PanelWidth, CollapsedHeight);
            eventsContainer.Visible = true;
            contactsContainer.Visible = true;

            // Attach Timer and button events
            eventsTransition.Tick += EventsTransition_Tick;
            ContactsTransition.Tick += ContactsTransition_Tick;

            // Events buttons
            adbtEvents.Click += AdbtEvents_Click;
            adbtEventsList.Click += AdbtEventsList_Click;
            adbtManageEvents.Click += AdbtManageEvents_Click;
            adbtEventsAttendees.Click += AdbtEventsAttendees_Click;
            adbtEventsReports.Click += AdbtEventsReports_Click;

            // Contacts buttons
            adbtContacts.Click += AdbtContacts_Click;
            adbtContactsList.Click += AdbtContactsList_Click;
            adbtManageContacts.Click += AdbtManageContacts_Click;
            adbtContactsReports.Click += AdbtContactsReports_Click;
        }

        // Method to handle sign out
        private void Signup_close_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Event handler for opening the Admins Dashboard.
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

        // Handles expanding/collapsing the Events submenu.
        private void AdDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            adDashboard = null;
        }

        private void AdbtEvents_Click(object sender, EventArgs e)
        {
            // Ensure the Contacts submenu is closed
            if (isContactsExpanded)
            {
                isContactsExpanded = false;
                ContactsTransition.Start();
            }

            // Toggle the Events submenu
            isEventsExpanded = !isEventsExpanded;
            eventsTransition.Start();
        }

        // Event handler for opening the Events List form and ensure not both submenus are open.
        private void EventsTransition_Tick(object sender, EventArgs e)
        {
            if (isEventsExpanded)
            {
                // Expand the dropdown panel
                if (eventsContainer.Height < ExpandedHeight)
                {
                    eventsContainer.Height += Step;
                    if (eventsContainer.Height > ExpandedHeight)
                    {
                        eventsContainer.Height = ExpandedHeight; // Ensure it stops at max height
                    }
                }
                else
                {
                    eventsTransition.Stop(); // Stop Timer once fully expanded
                }
            }
            else
            {
                // Collapse the dropdown panel
                if (eventsContainer.Height > CollapsedHeight)
                {
                    eventsContainer.Height -= Step;
                    if (eventsContainer.Height < CollapsedHeight)
                    {
                        eventsContainer.Height = CollapsedHeight; // Ensure it stops at min height
                    }
                }
                else
                {
                    eventsTransition.Stop(); // Stop Timer once fully collapsed
                }
            }
        }

        // Event handler for opening the Manage Events form.
        private void AdbtEventsList_Click(object sender, EventArgs e)
        {
            if (adEventsList == null)
            {
                adEventsList = new EventsSubmenu.Events_list();
                adEventsList.FormClosed += AdEventsList_FormClosed;
                adEventsList.MdiParent = this;
                adEventsList.Show();
            }
            else
            {
                adEventsList.Activate();
            }
        }

        private void AdEventsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            adEventsList = null;
        }

        //Event attendees form opener
        private void AdbtManageEvents_Click(object sender, EventArgs e)
        {
            if (adManageEvents == null)
            {
                adManageEvents = new EventsSubmenu.Events_management();
                adManageEvents.FormClosed += AdManageEvents_FormClosed;
                adManageEvents.MdiParent = this;
                adManageEvents.Show();
            }
            else
            {
                adManageEvents.Activate();
            }
        }

        private void AdManageEvents_FormClosed(object sender, FormClosedEventArgs e)
        {
            adManageEvents = null;
        }

        // Event handler for opening the Events Reports form.
        private void AdbtEventsAttendees_Click(object sender, EventArgs e)
        {
            if (adEventsAttendees == null)
            {
                adEventsAttendees = new EventsSubmenu.Events_Attendees();
                adEventsAttendees.FormClosed += AdEventsAttendees_FormClosed;
                adEventsAttendees.MdiParent = this;
                adEventsAttendees.Show();
            }
            else
            {
                adEventsAttendees.Activate();
            }
        }

        private void AdEventsAttendees_FormClosed(object sender, FormClosedEventArgs e)
        {
            adEventsAttendees = null;
        }

        // Event handlers for Contacts submenu are similar to the Events submenu above.
        // ...

        private void AdbtEventsReports_Click(object sender, EventArgs e)
        {
            if (adEventsReports == null)
            {
                adEventsReports = new EventsSubmenu.Events_Reports();
                adEventsReports.FormClosed += AdEventsReports_FormClosed;
                adEventsReports.MdiParent = this;
                adEventsReports.Show();
            }
            else
            {
                adEventsReports.Activate();
            }
        }

        private void AdEventsReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            adEventsReports = null;
        }


        //private void AdContacts_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    adContacts = null;
        //}

        private void AdbtLearning_Click(object sender, EventArgs e)
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

        private void SignoutAdmin_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                var landingPage = new Landing_Page();
                landingPage.Show();
                this.Dispose();
            }
        }



        // Contacts Dropdown Logic
        private void AdbtContacts_Click(object sender, EventArgs e)
        {
            // Ensure the Events submenu is closed
            if (isEventsExpanded)
            {
                isEventsExpanded = false;
                eventsTransition.Start();
            }

            // Toggle the Contacts submenu
            isContactsExpanded = !isContactsExpanded;
            ContactsTransition.Start();
        }

        private void ContactsTransition_Tick(object sender, EventArgs e)
        {
            if (isContactsExpanded)
            {
                contactsContainer.Height += Step;
                if (contactsContainer.Height >= ExpandedHeight)
                {
                    contactsContainer.Height = ExpandedHeight;
                    ContactsTransition.Stop();
                }
            }
            else
            {
                contactsContainer.Height -= Step;
                if (contactsContainer.Height <= CollapsedHeight)
                {
                    contactsContainer.Height = CollapsedHeight;
                    ContactsTransition.Stop();
                }
            }
        }

        private void AdbtContactsList_Click(object sender, EventArgs e)
        {
            if (adContactsList == null)
            {
                adContactsList = new ContactsSubmenu.Contacts_List();
                adContactsList.FormClosed += AdContactsList_FormClosed;
                adContactsList.MdiParent = this;
                adContactsList.Show();
            }
            else
            {
                adContactsList.Activate();
            }
        }

        private void AdContactsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            adContactsList = null;
        }

        private void AdbtManageContacts_Click(object sender, EventArgs e)
        {
            if (adManageContacts == null)
            {
                adManageContacts = new ContactsSubmenu.Manage_Contacts();
                adManageContacts.FormClosed += AdManageContacts_FormClosed;
                adManageContacts.MdiParent = this;
                adManageContacts.Show();
            }
            else
            {
                adManageContacts.Activate();
            }
        }

        private void AdManageContacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            adManageContacts = null;
        }

        private void AdbtContactsReports_Click(object sender, EventArgs e)
        {
            if (adContactsReports == null)
            {
                adContactsReports = new ContactsSubmenu.Contacts_Reports();
                adContactsReports.FormClosed += AdContactsReports_FormClosed;
                adContactsReports.MdiParent = this;
                adContactsReports.Show();
            }
            else
            {
                adContactsReports.Activate();
            }
        }

        private void AdContactsReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            adContactsReports = null;
        }
    }
}