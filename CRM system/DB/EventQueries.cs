using CRM_system.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_system.DB
{
    public class EventQueries
    {
        // Connection string to the SQLite database
        private string ConnectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "DB", "crm.db") + ";Version=3;";

        // Adds a new event to the database
        public bool AddEvent(string name, string description, int location, string contentType, string event_date, string publishStatus, string imagePath, int attendance_limit, int fee, int user_id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Events (event_name, event_description, event_type, attendance_limit, " +
                               "event_date, publish_status, event_image, location_id, fee_id, admin_id) " +
                               "VALUES (@Name, @Description, @event_type, @attendance_limit, @Date," +
                               " @PublishStatus, @ImagePath, @location_id, @fee_id, @admin_id);";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@location_id", location);
                    command.Parameters.AddWithValue("@event_type", contentType);
                    command.Parameters.AddWithValue("@Date", event_date);
                    command.Parameters.AddWithValue("@PublishStatus", publishStatus);
                    command.Parameters.AddWithValue("@ImagePath", imagePath);
                    command.Parameters.AddWithValue("@attendance_limit", attendance_limit);
                    command.Parameters.AddWithValue("@fee_id", fee);
                    command.Parameters.AddWithValue("@admin_id", user_id);

                    return command.ExecuteNonQuery() > 0; // Return true if a row was inserted
                }
            }
        }

        // Retrieves all events from the database
        public DataTable GetAllEvents()
        {
            var events = new DataTable();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT id AS 'ID', event_name AS 'Event Name', event_description AS 'Description', " +
                               "location_id AS 'Location', event_type AS 'Content Type', event_date AS 'Scheduled Date', " +
                               "publish_status AS 'Status' FROM Events;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(events);
                    }
                }
            }

            return events;
        }

        // Deletes an event by ID
        public bool DeleteEvent(int eventId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM Events WHERE id = @Id;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", eventId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if an event was deleted
                }
            }
        }

        // Counts the total number of active events in the database
        public int GetActiveEventCount()
        {
            int activeEventCount = 0;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Assuming "publish_status" is used to indicate active events
                string query = "SELECT COUNT(*) FROM Events;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    activeEventCount = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return activeEventCount;
        }
    }
}