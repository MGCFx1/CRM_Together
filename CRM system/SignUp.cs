using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Text.RegularExpressions;

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

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void login_close_Click(object sender, EventArgs e)
        {

        }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_login_Click(object sender, EventArgs e)
        {
            Login sForm = new Login();
            sForm.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void signup_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = '*';
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void signup_interestlabel_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Interest_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_pswrd_showhide_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (signup_password.PasswordChar == '*')
            {
                signup_pswrd_hide.BringToFront();
                signup_password.PasswordChar = '\0'; // Show password
                
            }
            
        }

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


       // For login: maybe create a helper file too
        //public static bool IsPasswordValid(string password)
        //{
            //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            //Console.WriteLine("Hashed Password: " + hashedPassword);

            //// Verify the password
            //Console.Write("Enter password to authenticate: ");
            //string passwordToCheck = Console.ReadLine();

            //bool isPasswordValid = BCrypt.Net.BCrypt.Verify(passwordToCheck, hashedPassword);

            //return isPasswordValid;
        //}

        private void Signup_btn_Click(object sender, EventArgs e)
        {

            // User Details
            Boolean isError = false;
            string name = signup_fullname.Text;
            string email = signup_email.Text;
            string password = signup_password.Text;

            // Location Details
            string city = Signup_city.Text;
            string address = signup_address.Text;
            string postcode = signup_post_code.Text;

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
            query.InsertNewUser(name, email, password, location_id);

            lblErrName.Text = "";
            lblErrEmail.Text = "";
            lblErrPassword.Text = "";

            dashboard_form dashboard = new dashboard_form();
            dashboard.Show();
            this.Hide();
        }
    }
}
