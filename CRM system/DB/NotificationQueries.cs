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


        public DataTable GetNotificationsByUserId(int userId)
        {
            DataTable notifications = new DataTable();

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

            return notifications;
        }


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
