using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace CRM_system
{
    public partial class ForgotPassword : Form
    {
        private DB.UserQueries query;
        private DB.LocationQueries locationQuery;
        public ForgotPassword()
        {
            InitializeComponent();
            query = new DB.UserQueries();
            locationQuery = new DB.LocationQueries();
        }

        /// <summary>
        /// Closes the application after confirming with the user.
        /// </summary>
        private void label5_Click(object sender, EventArgs e)
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
        /// Navigates to the Login form when user presses login
        /// </summary>
        private void register_login_Click(object sender, EventArgs e)
        {
            Login sForm = new Login();
            sForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Validates the format of an email address.
        /// </summary>
        /// <param name="email">The email address to validate.</param>
        /// <returns>True if the email format is valid, otherwise false.</returns>
        public static bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(email, emailPattern);
        }

        /// <summary>
        /// Validates if the entered date is a valid date and ensures the user is at least 13 years old.
        /// </summary>
        /// <param name="dateString">The date string to validate.</param>
        /// <returns>True if the date is valid and the user is at least 13 years old, otherwise false.</returns>
        public static bool IsValidYear(string dateString)
        {
            // Try to parse the input string into a DateTime object
            DateTime date;
            bool isValidDate = DateTime.TryParse(dateString, out date);

            // If the date is valid, check if its year is less than the current year
            if (isValidDate)
            {
                int currentYear = DateTime.Now.Year;
                return date.Year <= currentYear - 13;
            }
            else
            {
                // If the date is invalid, return false (or handle it as needed)
                Console.WriteLine("Invalid date format.");
                return false;
            }
        }

        /// <summary>
        /// Handles  resetting the user's password, including validation and database updates.
        /// </summary>
        private void Signup_btn_Click(object sender, EventArgs e)
        {
            // To Manage the case of Everything
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            // User Details
            Boolean isError = false;
            string email = signup_email.Text.ToLower();
            string date_of_birth = signup_dateOfBirth.Text;
            string password = signup_password.Text;

            // Location Details
            string postcode = signup_post_code.Text.ToUpper();

            List<Models.User> usersWithEmail = query.GetUserByEmail(email);
            var locations = new List<Models.Location>();

            if (email == "")
            {
                // If none of those things are blank
                lblErrEmail.Visible = true;
                lblErrEmail.Text = "Email cannot be blank";
                isError = true;
            }
            else if (!(usersWithEmail.Count > 0))
            {
                lblErrEmail.Text = "No such user exists";
                //If something goes wrong
                lblErrEmail.Visible = true;
                isError = true;
            }
            else if (!IsValidEmail(email))
            {
                lblErrEmail.Text = "Sorry, that doesn't seem like an email";
                lblErrEmail.Visible = true;
                isError = true;
            }
            else
            {
                locations = locationQuery.GetLocationByID(usersWithEmail[0].LocationID);
                lblErrEmail.Visible = false;
            }

            if (postcode == "")
            {
                // If none of those things are blank
                lblPostCodeErr.Visible = true;
                lblPostCodeErr.Text = "Post Code Cannot Be Blank";
                isError = true;
            }
            else if (postcode != locations[0].PostCode)
            {
                // If none of those things are blank
                lblPostCodeErr.Visible = true;
                lblPostCodeErr.Text = "Wrong Post Code";
                isError = true;
            }
            else
            {
                lblPostCodeErr.Visible = false;
            }


            if (usersWithEmail.Count > 0 && (date_of_birth != usersWithEmail[0].UserDateOfBirth))
            {
                // If none of those things are blank
                lblErrDOB.Visible = true;
                lblErrDOB.Text = "Incorrect Date of Birth";
                isError = true;
            }
            else
            {
                Console.WriteLine("That");
                lblErrDOB.Visible = false;
            }

            if (password == "")
            {
                // If none of those things are blank
                lblErrPassword.Visible = true;
                lblErrPassword.Text = "Password cannot be blank";
                isError = true;
            }
            else if (password.Length < 8)
            {
                // If none of those things are blank
                lblErrPassword.Visible = true;
                lblErrPassword.Text = "Password is too weak; 8 characters required";
                isError = true;
            }
            else
            {
                lblErrPassword.Visible = false;
                // Storing the encrypted password in the database
                password = BCrypt.Net.BCrypt.HashPassword(password);
            }

            if (isError)
            {
                return;
            }

            lblErrEmail.Text = "";

            query.UpdateUserPassword(usersWithEmail[0].Id, password);

            MessageBox.Show("You have successfully changed your password!", "Password Reset Successfull");

            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
