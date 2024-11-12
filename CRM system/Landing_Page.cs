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
    public partial class Landing_Page : Form
    {
        public Landing_Page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 10)) // black colourr, 10 pixels wide
            {
                e.Graphics.DrawLine(pen, 10, 10, 200, 10); // Draw line from (10, 10) to (200, 10)
            }
        
    }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login sForm = new Login();
            sForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp sForm = new SignUp();
            sForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, ComponentFactory.Krypton.Toolkit.ColorEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void Landing_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
