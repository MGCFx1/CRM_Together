using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_system
{
    public partial class Accounts_Forms : Form
    {
        int id = 0;
        private DB.UserQueries query;

        public Accounts_Forms()
        {
            InitializeComponent();
            query = new DB.UserQueries(); // Initialize the database query object
            id = UserSession.ID; // Retrieve the logged-in user's ID
            accFullName.Text = UserSession.Name; // Display the user's full name
            accEmailAddress.Text = UserSession.Email; // Display the user's email
        }

        /// <summary>
        /// Validates whether a provided password matches the hashed password.
        /// </summary>
        public static bool IsPasswordValid(string password, string hashedPassword)
        {

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);

            return isPasswordValid;
        }

        /// <summary>
        /// Validates whether an email address is in a valid format.
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(email, emailPattern);
        }

        /// <summary>
        /// Saves the changes to the user account information
        /// <param name="email">Email address to validate.</param>
        /// <returns>True if the email format is valid; otherwise, false.</returns>
        /// </summary>
        private void accSaveChanges_Click(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            id = UserSession.ID;
            string name = accFullName.Text;
            string email = accEmailAddress.Text;
            string old_password = accCurrentPswrd.Text;
            string new_password = accNewPswrd.Text;

            // User Details
            Boolean isError = false;
            List<Models.User> usersWithEmail = query.GetUserByEmail(email);

            if (name == "" || name.Length < 4)
            {
                // If none of those things are blank
                lblErrname.Visible = true;
                lblErrname.Text = "name cannot be blank or less than 4 chars";
                isError = true;
            }
            else
            {
                lblErrname.Visible = false;
            }

            if (email == "")
            {
                // If none of those things are blank
                lblErrEmail.Visible = true;
                lblErrEmail.Text = "Email cannot be blank";
                isError = true;
            }
            else if ((usersWithEmail.Count > 0 && usersWithEmail[0].Email != "") && !(usersWithEmail[0].Email == UserSession.Email))
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

            if (new_password == "")
            {
                // If none of those things are blank
                lblErrNewPassword.Visible = true;
                lblErrNewPassword.Text = "New password cannot be blank";
                isError = true;
            }
            else if (new_password.Length < 8)
            {
                // If none of those things are blank
                lblErrNewPassword.Visible = true;
                lblErrNewPassword.Text = "New password is too weak; 8 characters required";
                isError = true;
            }
            else
            {
                lblErrNewPassword.Visible = false;
                // Storing the encrypted password in the database
                new_password = BCrypt.Net.BCrypt.HashPassword(new_password);
            }

            if (old_password == "")
            {
                lblErrPassword.Visible = true;
                lblErrPassword.Text = "Old password cannot be blank";
                isError = true;
            } else if (!IsPasswordValid(old_password, usersWithEmail[0].Password))
            {
                lblErrPassword.Visible = true;
                lblErrPassword.Text = "Old password is invalid";
                isError = true;
            }
            else
            {
                lblErrNewPassword.Visible = false;
            }

            if (isError)
            {
                return;
            }

            List<Models.User> usersByID = query.GetUserByID(id);

            query.UpdateUser(id, name, email, new_password, "active", usersByID[0].LocationID, usersByID[0].MembershipType);

            lblErrname.Text = "";
            lblErrEmail.Text = "";
            lblErrPassword.Text = "";
            lblErrNewPassword.Text = "";

            dashboard_form dashboard = new dashboard_form();
            dashboard.Show();
            this.Hide();
        }

        private void accDiscardChanges_Click(object sender, EventArgs e)
        {
            accFullName.Text = UserSession.Name;
            accEmailAddress.Text = UserSession.Email;
        }
    }
}
