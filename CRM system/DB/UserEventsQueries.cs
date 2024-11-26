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

                    string query = "INSERT OR IGNORE INTO EventAttendees (event_id, user_id) VALUES (@EventId, @UserId);";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EventId", eventId);
                        command.Parameters.AddWithValue("@UserId", userId);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddUserToEvent: {ex.Message}");
                return false;
            }
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
                                        e.id, 
                                        e.event_name, 
                                        e.event_description, 
                                        e.event_type, 
                                        e.attendance_limit, 
                                        e.event_date, 
                                        e.location_id, 
                                        e.fee_id, 
                                        e.event_image 
                                    FROM Events e;";

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
                                    LocationId = reader.GetInt32(6),
                                    FeeId = reader.GetInt32(7),
                                    EventImage = reader.IsDBNull(8) ? null : reader.GetString(8) // Load image path if available
                                };

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
                                     FROM Fees 
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
    }
}