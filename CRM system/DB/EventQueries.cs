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
        private string ConnectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "DB", "crm.db") + ";version=3;";

        /// <summary>
        /// Adds a new event to the database.
        /// </summary>
        public bool AddEvent(string name, string description, string location, string contentType, string schedule, string publishStatus)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Events (name, description, location, content_type, schedule, publish_status) " +
                               "VALUES (@Name, @Description, @Location, @ContentType, @Schedule, @PublishStatus);";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@ContentType", contentType);
                    command.Parameters.AddWithValue("@Schedule", schedule);
                    command.Parameters.AddWithValue("@PublishStatus", publishStatus);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if the event was successfully added
                }
            }
        }

        /// <summary>
        /// Retrieves all events from the database.
        /// </summary>
        public DataTable GetAllEvents()
        {
            var events = new DataTable();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT id AS 'ID', name AS 'Event Name', description AS 'Description', " +
                               "location AS 'Location', content_type AS 'Content Type', schedule AS 'Scheduled Date', " +
                               "publish_status AS 'Status' FROM Events;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(events);
                    }
                }
            }

            return events; // Return the DataTable containing all events
        }

        /// <summary>
        /// Deletes an event by ID.
        /// </summary>
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
    }
}