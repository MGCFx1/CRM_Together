using System;
using System.Windows.Forms;

namespace CRM_system
{
    public partial class Landing_Page : Form
    {
        public Landing_Page()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to close and confirm with the user.
        /// </summary>
        private void Signup_close_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // If the user clicks Yes, close the application
                Application.Exit();
            }
            // If the user clicks No, do nothing and return to the application
        }

        /// <summary>
        /// Navigates to the Login form when Login button is pressed
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Login sForm = new Login();
            sForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Navigates to the SignUp button is pressed
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            SignUp sForm = new SignUp();
            sForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Navigates to the Admin Login form.
        /// </summary>
        private void adminLoginLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin aForm = new AdminLogin();
            aForm.Show();
        }
    }
}
