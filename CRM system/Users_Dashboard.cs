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
        bool sidebarExpand;
        public Users_Dashboard()
        {
            InitializeComponent();
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
    }
}
