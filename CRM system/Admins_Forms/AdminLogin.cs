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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        // For login: maybe create a helper file too
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

        // To check if a user's email is valid
        public static bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(email, emailPattern);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Boolean isError = false;
            string email = login_email.Text;
            string password = login_password.Text;

            List<Models.User> usersWithEmail = query.GetUserByEmail(email);


            if (email == "")
            {
                // If none of those things are blank
                lblEmailErr.Visible = true;
                lblEmailErr.Text = "Email cannot be blank";
                isError = true;
            }

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
            else if (usersWithEmail.Count > 0 && !IsPasswordValid(password, usersWithEmail[0].Password))
            {
                lblPasswordErr.Text = "Sorry, incorrect password";
                lblPasswordErr.Visible = true;
                isError = true;
            }
            else
            {
                lblPasswordErr.Visible = false;
            }

            if (usersWithEmail.Count > 0 && usersWithEmail[0].IsAdmin == false)
            {
                lblEmailErr.Text = "Sorry, you are an admin not a regular user.";
                lblEmailErr.Visible = true;
                isError = true;
            }


            if (isError)
            {
                return;
            }


            if (usersWithEmail != null && usersWithEmail.Count > 0)
            {
                UserSession.Name = usersWithEmail[0].Name;
            }

            this.Hide();
            AdminsPanel adminsPanel = new AdminsPanel();
            adminsPanel.Show();
            //lblEmailErr.Text = "Successful login";
            //lblEmailErr.Visible = true;
            
        }

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = '*';
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
