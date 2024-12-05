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
    internal class UserEventsQueries
    {
        private string ConnectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "DB", "crm.db") + ";Version=3;";

        /// <summary>
        /// Adds a user to an event in the EventAttendees table.
        /// </summary>
        public bool AddUserToEvent(int userId, int eventId)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    // Add user to the event
                    string query = "INSERT OR IGNORE INTO EventAttendees (event_id, user_id) VALUES (@EventId, @UserId);";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EventId", eventId);
                        command.Parameters.AddWithValue("@UserId", userId);

                        // Check if the insertion was successful
                        if (command.ExecuteNonQuery() > 0)
                        {
                            // Add a notification for the user
                            string notificationQuery = "INSERT INTO Notifications (user_id, type, message) VALUES (@UserId, 'Joined Event', @Message);";
                            using (var notificationCommand = new SQLiteCommand(notificationQuery, connection))
                            {
                                // Customize the notification message (you can expand this logic)
                                string message = $"You have successfully joined the event with ID: {eventId}.";

                                notificationCommand.Parameters.AddWithValue("@UserId", userId);
                                notificationCommand.Parameters.AddWithValue("@Message", message);

                                notificationCommand.ExecuteNonQuery();
                            }

                            return true; // Event joined and notification added
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddUserToEvent: {ex.Message}");
            }

            return false; // Return false if the operation fails
        }

        /// <summary>
        /// Checks if a user is already joined to a specific event.
        /// </summary>
        public bool IsUserJoined(int userId, int eventId)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM EventAttendees WHERE event_id = @EventId AND user_id = @UserId;";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EventId", eventId);
                        command.Parameters.AddWithValue("@UserId", userId);

                        return Convert.ToInt32(command.ExecuteScalar()) > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in IsUserJoined: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Retrieves all events joined by a specific user.
        /// </summary>
        public List<int> GetEventsJoinedByUser(int userId)
        {
            var joinedEvents = new List<int>();

            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT event_id FROM EventAttendees WHERE user_id = @UserId;";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                joinedEvents.Add(reader.GetInt32(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetEventsJoinedByUser: {ex.Message}");
            }

            return joinedEvents;
        }

        /// <summary>
        /// Retrieves event details for populating event cards in the UI.
        /// </summary>
        public List<Event> GetAllEventsForCards()
        {
            var events = new List<Event>();

            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT 
                                    e.id AS EventID,
                                    e.event_name AS EventName,
                                    e.event_description AS EventDescription,
                                    e.event_type AS EventType,
                                    e.attendance_limit AS AttendanceLimit,
                                    e.event_date AS EventDate,
                                    l.city AS LocationCity,
                                    e.fee_id AS FeeId,
                                    e.event_image AS EventImage
                                FROM 
                                    Events e
                                LEFT JOIN 
                                    Locations l ON l.id = e.location_id
                                WHERE 
                                    e.publish_status = 'Public'
                                ORDER BY e.id DESC;
                                ";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var ev = new Event
                                {
                                    Id = reader.GetInt32(0),
                                    EventName = reader.GetString(1),
                                    EventDescription = reader.GetString(2),
                                    EventType = reader.GetString(3), // Assuming EventType is used for image storage
                                    AttendanceLimit = reader.GetInt32(4),
                                    EventDate = reader.GetString(5),
                                    LocationCity = reader.GetString(6),
                                    FeeId = reader.GetInt32(7),
                                    EventImage = reader.IsDBNull(8) ? null : EventQueries.ByteArrayToImage((byte[])reader["EventImage"])// Load image path if available
                                };
                                //Console.WriteLine("Ran");
                                //Console.WriteLine(EventQueries.ByteArrayToImage((byte[])reader["EventImage"]));

                                events.Add(ev);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllEventsForCards: {ex.Message}");
            }

            return events;
        }

        /// <summary>
        /// Retrieves fee details for a given fee ID.
        /// </summary>
        public Fee GetFeeDetails(int feeId)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT id, fee_type, amount, currency, description 
                                     FROM Fee
                                     WHERE id = @FeeId;";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FeeId", feeId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Fee
                                {
                                    Id = reader.GetInt32(0),
                                    FeeType = reader.GetString(1),
                                    Amount = reader.GetString(2),
                                    Currency = reader.GetString(3),
                                    Description = reader.GetString(4)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetFeeDetails: {ex.Message}");
            }

            return null;
        }

        public DataTable GetUserJoinedEvents(int userId)
        {
            var joinedEventsTable = new DataTable();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    e.id AS 'Event ID',
                    e.event_name AS 'Event Name',
                    e.event_description AS 'Description',
                    e.event_date AS 'Date',
                    e.event_type AS 'Type',
                    ea.joined_at AS 'Joined At'
                FROM EventAttendees ea
                JOIN Events e ON ea.event_id = e.id
                WHERE ea.user_id = @UserId;";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId); // Properly assign the user ID
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(joinedEventsTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in GetUserJoinedEvents: {ex.Message}");
                }
            }

            return joinedEventsTable;
        }

        public bool RemoveUserFromEvent(int userId, int eventId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Remove user from the event
                    string query = @"
                DELETE FROM EventAttendees
                WHERE user_id = @UserId AND event_id = @EventId;";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@EventId", eventId);

                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if a row was deleted
                        if (rowsAffected > 0)
                        {
                            // Add a notification for the user
                            string notificationQuery = @"
                        INSERT INTO Notifications (user_id, type, message)
                        VALUES (@UserId, 'Left Event', @Message);";

                            using (var notificationCommand = new SQLiteCommand(notificationQuery, connection))
                            {
                                string message = $"You have successfully left the event with ID: {eventId}.";

                                notificationCommand.Parameters.AddWithValue("@UserId", userId);
                                notificationCommand.Parameters.AddWithValue("@Message", message);

                                notificationCommand.ExecuteNonQuery();
                            }

                            return true; // Successfully removed and notification added
                        }

                        return false; // No row was deleted
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in RemoveUserFromEvent: {ex.Message}");
                    return false;
                }
            }
        }
    }
}