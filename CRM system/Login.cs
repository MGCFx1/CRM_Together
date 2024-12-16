using CRM_system.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRM_system
{
    public partial class Login : Form
    {
        private DB.UserQueries query;
        public Login()
        {
            InitializeComponent();
            query = new DB.UserQueries();
        }

        /// <summary>
        /// Toggles the visibility of the password field.
        /// </summary>
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
        /// Navigates to the SignUp form.
        /// </summary>
        private void label5_Click(object sender, EventArgs e)
        {
            var signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Verifies if the provided password matches the hashed password.
        /// </summary>
        /// <param name="password">Plain text password.</param>
        /// <param name="hashedPassword">Hashes the password in the db.</param>
        /// <returns>True if the password matches. False if it doesn't.</returns>
        public static bool IsPasswordValid(string password, string hashedPassword)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Validates an email address format using a regular expression.
        /// </summary>
        /// <param name="email">Email address to validate.</param>
        /// <returns>True if the email format is valid; otherwise, false.</returns>
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        /// <summary>
        /// Handles the login process, including input validation and user authentication.
        /// </summary>
        private void login_btn_Click(object sender, EventArgs e)
        {
            bool isError = false;
            string email = login_email.Text.Trim();
            string password = login_password.Text;

            // Fetch user details based on email
            List<Models.User> usersWithEmail = query.GetUserByEmail(email);

            // Validate email input
            if (string.IsNullOrWhiteSpace(email))
            {
                lblEmailErr.Visible = true;
                lblEmailErr.Text = "Email cannot be blank.";
                isError = true;
            }
            else if (!IsValidEmail(email))
            {
                lblEmailErr.Visible = true;
                lblEmailErr.Text = "Invalid email format.";
                isError = true;
            }
            else if (usersWithEmail.Count == 0)
            {
                lblEmailErr.Visible = true;
                lblEmailErr.Text = "Email does not exist.";
                isError = true;
            }
            else
            {
                lblEmailErr.Visible = false;
            }

            // Validate password input
            if (string.IsNullOrWhiteSpace(password))
            {
                lblPasswordErr.Visible = true;
                lblPasswordErr.Text = "Password cannot be blank.";
                isError = true;
            }
            else if (usersWithEmail.Count > 0 && !IsPasswordValid(password, usersWithEmail[0].Password))
            {
                lblPasswordErr.Visible = true;
                lblPasswordErr.Text = "Incorrect password.";
                isError = true;
            }
            else
            {
                lblPasswordErr.Visible = false;
            }

            // Check admin restriction
            if (usersWithEmail.Count > 0 && usersWithEmail[0].IsAdmin)
            {
                lblEmailErr.Visible = true;
                lblEmailErr.Text = "You are not authorized to access this area.";
                isError = true;
            }

            if (isError) return; // Stop further processing if there are validation errors

            // Membership status checks
            var user = usersWithEmail[0];
            if (user.MembershipStatus == "pending")
            {
                MessageBox.Show("Your membership is pending admin approval.", "Pending Approval");
                return;
            }

            if (user.MembershipStatus == "inactive")
            {
                MessageBox.Show("Your membership has been rejected by the admin.", "Membership Inactive");
                return;
            }

            // Set user session details
            UserSession.ID = user.Id;
            UserSession.Name = user.Name;
            UserSession.Email = user.Email;

            // Log the user's last login time
            query.UserLastLogin(user.Id);

            // Navigate to the dashboard
            this.Hide();
            var dashboardForm = new Users_Dashboard(user.Id);
            dashboardForm.Show();
        }

        /// <summary>
        /// Closes the application after user confirmation.
        /// </summary>
        private void login_close_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Directs the user to the reset password form
        /// </summary>
        private void resetPswdLinkLbl_Click(object sender, EventArgs e)
        {
            var forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.Show();
            this.Hide();
        }

        /// <summary>
        /// A back button to take the user back to the landing page.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            var landingPage = new Landing_Page();
            landingPage.Show();
            this.Close();
        }

        private void Login_Insert_Click(object sender, EventArgs e)
        {
            login_email.Text = "user@together.com";
            login_password.Text = "user1234";
        }
    }
}