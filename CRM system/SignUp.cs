using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace CRM_system
{
    public partial class SignUp : Form
    {
        private DB.UserQueries query;
        private DB.LocationQueries locationQuery;
        public SignUp()
        {
            InitializeComponent();
            query = new DB.UserQueries();
            locationQuery = new DB.LocationQueries();
        }

        /// <summary>
        /// Closes the application after user confirmation.
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
        /// Navigates to the login form.
        /// </summary>
        private void register_login_Click(object sender, EventArgs e)
        {
            Login sForm = new Login();
            sForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Makes the label background transparent (styling only).
        /// </summary>
        private void label7_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;

        }

        /// <summary>
        /// Masks the password field for security.
        /// </summary>
        private void signup_password_TextChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = '*';
        }

        /// <summary>
        /// Toggles password visibility (show password).
        /// </summary>
        private void signup_pswrd_showhide_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (signup_password.PasswordChar == '*')
            {
                signup_pswrd_hide.BringToFront();
                signup_password.PasswordChar = '\0'; // Show password
                
            }    
        }

        /// <summary>
        /// Validates an email address using a regular expression.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (signup_password.PasswordChar == '\0')
            {
                signup_pswrd_show.BringToFront();
                signup_password.PasswordChar = '*'; // Show password

            }
        }

        // To check if a user's email is valid
        public static bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(email, emailPattern);
        }

        /// <summary>
        /// Checks if a date of birth is valid and ensures that the user is at least 13 years old.
        /// </summary>
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
        /// Handles user sign-up, including validation, database insertion, and feedback.
        /// </summary>
        private void Signup_btn_Click(object sender, EventArgs e)
        {
            // Normalize user input
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            Boolean isError = false;
            string name = textInfo.ToTitleCase(signup_fullname.Text);
            string email = signup_email.Text.ToLower();
            string password = signup_password.Text;
            string membership_status = "pending";
            string date_of_birth = signup_dateOfBirth.Text;

            // Location Details
            string city = textInfo.ToTitleCase(Signup_city.Text);
            string address = textInfo.ToTitleCase(signup_address.Text);
            string postcode = signup_post_code.Text.ToUpper();

            List<Models.User> usersWithEmail = query.GetUserByEmail(email);
            if (name == "" || name.Length < 4)
            {
                // If none of those things are blank
                lblErrName.Visible = true;
                lblErrName.Text = "Name cannot be blank or less than 4 chars";
                isError = true;
            } else
            {
                lblErrName.Visible = false;
            }

            if (email == "")
            {
                // If none of those things are blank
                lblErrEmail.Visible = true;
                lblErrEmail.Text = "Email cannot be blank";
                isError = true;
            } else if (usersWithEmail.Count > 0 && usersWithEmail[0].Email != "")
            {
                lblErrEmail.Text = "Email is already in use";
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
                lblErrEmail.Visible = false;
            }

            Console.WriteLine(date_of_birth);


            if (!IsValidYear(date_of_birth))
            {
                // If none of those things are blank
                lblErrDOB.Visible = true;
                lblErrDOB.Text = "Invalid";
                isError = true;
            }
            else if (date_of_birth.Length < 8)
            {
                // If none of those things are blank
                lblErrDOB.Visible = true;
                //lblErrDOB.Text = "Password is too weak; 8 characters required";
                isError = true;
            }
            else
            {
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

            int location_id = locationQuery.InsertNewLocation(city, address, postcode);
            query.InsertNewUser(name, email, password, membership_status, false, location_id, "none", date_of_birth);

            lblErrName.Text = "";
            lblErrEmail.Text = "";
            lblErrPassword.Text = "";

            MessageBox.Show("You have successfully! You'll have to wait 48hrs to be approved by the admin " +
                "before you'll be able to login.", "Sign Up Successfull");

        }

        /// <summary>
        /// Navigates back to the landing page.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            {
                Landing_Page landingPage = new Landing_Page();
                landingPage.Show();
                this.Close(); 
            }
        }

    }
}
