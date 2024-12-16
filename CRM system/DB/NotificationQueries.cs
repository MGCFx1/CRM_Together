using System;
using System.Data.SQLite;
using System.Data;
using CRM_system.Models;
using System.IO;

namespace CRM_system.DB
{
    public class NotificationQueries
    {
        // Connection string to the SQLite database file
        private string ConnectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "DB", "crm.db") + ";version=3;";

        /// <summary>
        /// Adds a new notification for a specific user into the Notifications table.
        /// </summary>
        /// <param name="userId">The ID of the user receiving the notification.</param>
        /// <param name="type">The type of the notification.</param>
        /// <param name="message">The message for the notification.</param>
        public void AddNotification(int userId, string type, string message)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Notifications (user_id, type, message) VALUES (@userId, @type, @message);";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@message", message);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Retrieves all notifications for the logged in user from the databasee.
        /// Notifications are displayed in descending order.
        /// </summary>
        /// <param name="userId">The ID of the user's notifications to be retrieved.</param>
        /// <returns>A DataTable containing the list of notifications for the user.</returns>
        public DataTable GetNotificationsByUserId(int userId)
        {
            DataTable notifications = new DataTable(); // Holds the retrieved notifications

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT id, type, message, created_at FROM Notifications WHERE user_id = @UserId ORDER BY created_at DESC;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(notifications);
                    }
                }
            }

            return notifications; // Return the result as a DataTable
        }

        /// <summary>
        /// Deletes a specific notification from the database using its unique ID.
        /// </summary>
        /// <param name="notificationId">The unique ID of the notification to be deleted.</param>
        /// <returns>
        /// True if the notification was successfully deleted; otherwise, false.
        /// </returns>
        public bool DeleteNotificationById(int notificationId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM Notifications WHERE id = @NotificationId;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NotificationId", notificationId);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
