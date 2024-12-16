using CRM_system.Admins_Forms;
using CRM_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_system
{
    public partial class AdminLogin : Form
    {
        private DB.UserQueries query;
        public AdminLogin()
        {
            InitializeComponent();
            query = new DB.UserQueries();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (login_show.Checked)
            {
                login_password.PasswordChar = '\0'; // Show password
            }
            else
            {
                login_password.PasswordChar = '*'; // Hide password
            }
        }


        /// <summary>
        /// Validates the entered password against the hashed password.
        /// </summary>
        /// <param name="password">The entered password.</param>
        /// <param name="hashedPassword">The stored hashed password.</param>
        /// <returns>True if the password is valid; otherwise, false.</returns>
        public static bool IsPasswordValid(string password, string hashedPassword)
        {

            //bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);

            Boolean isPasswordValid = false;

            if (password == hashedPassword)
            {
                isPasswordValid = true;
            }

            return isPasswordValid;
        }

        /// <summary>
        /// Validates whether the input string is a valid email format.
        /// </summary>
        /// <param name="email">The email to validate.</param>
        /// <returns>True if the email is valid; otherwise, false.</returns>
        public static bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(email, emailPattern);
        }

        /// <summary>
        /// Handles the login button click event.
        /// Validates email, password, and admin permissions before login.
        /// </summary>
        private void login_btn_Click(object sender, EventArgs e)
        {
            Boolean isError = false; // Validation flag

            string email = login_email.Text; // Retrieve entered email and password
            string password = login_password.Text;
            // Fetch user data from the database based on the entered email
            List<Models.User> usersWithEmail = query.GetUserByEmail(email);


            if (email == "")
            {
                // If none of those things are blank
                lblEmailErr.Visible = true;
                lblEmailErr.Text = "Email cannot be blank";
                isError = true;
            }
            // Email validation
            else if (!IsValidEmail(email)) 
            {
                lblEmailErr.Text = "Sorry, that doesn't seem like a valid email";
                lblEmailErr.Visible = true;
                isError = true;
            }
            else if (!(usersWithEmail.Count > 0))
            {
                lblEmailErr.Text = "Email does not exist";
                //If something goes wrong
                lblEmailErr.Visible = true;
                isError = true;
            }
            else
            {
                lblEmailErr.Visible = false;
            }

            if (password == "")
            {
                // If none of those things are blank
                lblPasswordErr.Visible = true;
                lblPasswordErr.Text = "Password cannot be blank";
                isError = true;
            }
            else if (usersWithEmail.Count > 0 && !IsPasswordValid(password, usersWithEmail[0].Password)) // Check if the user is an admin
            {
                lblPasswordErr.Text = "Sorry, incorrect password";
                lblPasswordErr.Visible = true;
                isError = true; // Exit if any errors were found
            }
            else
            {
                lblPasswordErr.Visible = false;
            }

            if (usersWithEmail.Count > 0 && usersWithEmail[0].IsAdmin == false) // Successful login - set user session and navigate to Admin Panel
            {
                lblEmailErr.Text = "Sorry, you are an admin not a regular user.";
                lblEmailErr.Visible = true;
                isError = true;
            }

            if (isError) // Exit if any errors were found
            {
                return;
            }


            if (usersWithEmail != null && usersWithEmail.Count > 0)
            {
                UserSession.Name = usersWithEmail[0].Name; // Set the session user name
            }

            this.Hide();
            AdminsPanel adminsPanel = new AdminsPanel();
            adminsPanel.Show();
            
        }

        /// <summary>
        /// Displays a confirmation dialog when the user attempts to close the form.
        /// </summary>
        private void login_close_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Sets the PasswordChar property to mask password input.
        /// </summary>
        private void login_password_TextChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = '*'; //will change characters ti star *
        }

        /// <summary>
        /// Navigates back to the landing page.
        /// </summary>
        private void btnBackAd_Click(object sender, EventArgs e)
        {
            // Create an instance of the Landing_Page form
            Landing_Page landingPage = new Landing_Page();

            // Show the Landing_Page form
            landingPage.Show();

            // Close or hide the current form
            this.Close(); // Or use this.Hide();
        }

        /// <summary>
        /// Automatically populates the email and password fields for testing purposes.
        /// </summary>
        private void Login_Insert_Click(object sender, EventArgs e)
        {
            login_email.Text = "admin@together.com";
            login_password.Text = "admin1234";
        }
    }
}
