using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CRM_system
{
    public partial class NotificationsForm : Form
    {
        private int _userId; // User ID for fetching notifications
        private DB.UserQueries _query; // To access UserQueries methods

        public NotificationsForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _query = new DB.UserQueries();
        }

        private void NotificationsForm_Load(object sender, EventArgs e)
        {
            LoadNotifications(_userId);
        }

        // Load notifications for the logged-in user
        private void LoadNotifications(int userId)
        {
            try
            {
                // Clear existing controls in the FlowLayoutPanel
                FlowPanelNotifications.Controls.Clear();

                // Fetch notifications using UserQueries
                var notifications = _query.GetNotificationsByUserId(userId);

                if (notifications.Rows.Count == 0)
                {
                    // If no notifications, show a message
                    Label noNotifLabel = new Label
                    {
                        Text = "No new notifications.",
                        Font = new Font("Arial", 12, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        AutoSize = true
                    };
                    FlowPanelNotifications.Controls.Add(noNotifLabel);
                    return;
                }

                foreach (DataRow row in notifications.Rows)
                {
                    int notificationId = Convert.ToInt32(row["id"]);
                    string type = row["type"].ToString();
                    string message = row["message"].ToString();
                    string date = row["created_at"].ToString();

                    // Create a notification panel
                    Panel notificationPanel = new Panel
                    {
                        Size = new Size(393, 86), // Updated size
                        BackColor = Color.LightGray,
                        Margin = new Padding(5)
                    };

                    // Add notification icon
                    PictureBox notifIcon = new PictureBox
                    {
                        Image = NotifIcon1.Image, // Use the existing image from NotifIcon1
                        SizeMode = NotifIcon1.SizeMode,
                        Location = new Point(7, 15), // Unchanged location
                        Size = new Size(49, 53) // Unchanged size
                    };

                    // Add title
                    Label lblType = new Label
                    {
                        Text = type,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        ForeColor = Color.Black,
                        Location = new Point(63, 11), // Updated location
                        AutoSize = true
                    };

                    // Add message
                    Label lblMessage = new Label
                    {
                        Text = message,
                        Font = new Font("Arial", 9),
                        ForeColor = Color.DarkGray,
                        Location = new Point(63, 25), // Updated location
                        AutoSize = false, // Turned off AutoSize
                        Size = new Size(258, 37) // Manually set size
                    
                    };

                    // Add date
                    Label lblDate = new Label
                    {
                        Text = date,
                        Font = new Font("Arial", 8, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        Location = new Point(65, 60), // Updated location
                        AutoSize = true
                    };

                    // Add erase button with icon
                    Button btnErase = new Button
                    {
                        Image = NotifErase1.Image, // Use the existing icon for NotifErase1
                        Location = new Point(341, 32), // Updated location
                        Size = new Size(32, 32), // Adjust size to fit the icon
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Transparent,
                        TabStop = false // Prevent tab focus
                    };

                    btnErase.FlatAppearance.BorderSize = 0; // Remove button border
                    btnErase.Click += (s, e) => EraseNotification(notificationId, notificationPanel);

                    // Add controls to the panel
                    notificationPanel.Controls.Add(notifIcon);
                    notificationPanel.Controls.Add(lblType);
                    notificationPanel.Controls.Add(lblMessage);
                    notificationPanel.Controls.Add(lblDate);
                    notificationPanel.Controls.Add(btnErase);

                    // Add the panel to the FlowLayoutPanel
                    FlowPanelNotifications.Controls.Add(notificationPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notifications: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Erase a notification
        private void EraseNotification(int notificationId, Panel notificationPanel)
        {
            try
            {
                // Use UserQueries to delete the notification
                if (_query.DeleteNotificationById(notificationId))
                {
                    // Remove the panel from the UI
                    FlowPanelNotifications.Controls.Remove(notificationPanel);
                }
                else
                {
                    MessageBox.Show("Failed to erase the notification.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error erasing notification: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void NotifPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FlowPanelNotifications_Paint(object sender, PaintEventArgs e)
        {
        }

        private void NotifErase1_Click(object sender, EventArgs e)
        {

        }

        private void NotifMessege1_Click(object sender, EventArgs e)
        {

        }

        private void NotifDate1_Click(object sender, EventArgs e)
        {

        }

        private void NotifTitle1_Click(object sender, EventArgs e)
        {

        }

        private void NotifIcon1_Click(object sender, EventArgs e)
        {

        }

        private void NotifCloseForm_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the NotificationsForm
        }
    }
}
