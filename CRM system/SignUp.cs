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
    public partial class SignUp : Form
    {
        private DB.UserQueries query;
        public SignUp()
        {
            InitializeComponent();
            query = new DB.UserQueries();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void Register_Name_Click(object sender, EventArgs e)
        {

        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            string name = signup_fullname.Text;
            string email = signup_email.Text;
            string password = signup_password.Text;

            query.InsertNewUser(name, email, password);
        }
    }
}
