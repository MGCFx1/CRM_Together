using CRM_system.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace CRM_system.DB
{
    public class EventQueries
    {
        // Connection string to the SQLite database
        private string ConnectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "DB", "crm.db") + ";Version=3;";

        private static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                if (ImageFormat.Jpeg.Equals(image.RawFormat))
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (ImageFormat.Png.Equals(image.RawFormat))
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                }
                else
                {
                    return null;
                }
                return ms.ToArray();
            }
        }

        // Converts a byte array to the image.
        public static Image ByteArrayToImage(byte[] byteArray)
        {
            Console.WriteLine("Ouput be here: " + BitConverter.ToString(byteArray));
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting byte array to image: {ex.Message}");
                return null;
            }
        }


        // Adds a new event to the database
        public bool AddEvent(string name, string description, int location, string contentType, string event_date, string publishStatus, Image imagePath, int attendance_limit, int fee, int user_id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Events (event_name, event_description, event_type, attendance_limit, " +
                               "event_date, publish_status, event_image, location_id, fee_id, admin_id) " +
                               "VALUES (@Name, @Description, @event_type, @attendance_limit, @Date," +
                               " @PublishStatus, @ImagePath, @location_id, @fee_id, @admin_id);";

                Console.WriteLine("Converted" + BitConverter.ToString(ImageToByteArray(imagePath)));

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@location_id", location);
                    command.Parameters.AddWithValue("@event_type", contentType);
                    command.Parameters.AddWithValue("@Date", event_date);
                    command.Parameters.AddWithValue("@PublishStatus", publishStatus);
                    command.Parameters.AddWithValue("@ImagePath", ImageToByteArray(imagePath));
                    command.Parameters.AddWithValue("@attendance_limit", attendance_limit);
                    command.Parameters.AddWithValue("@fee_id", fee);
                    command.Parameters.AddWithValue("@admin_id", user_id);

                    return command.ExecuteNonQuery() > 0; 
                }
            }
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
                    return rowsAffected > 0; 
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

                string query = "SELECT COUNT(*) FROM Events;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    activeEventCount = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return activeEventCount;
        }

        //retrieves all event from the "Events" table and return them as list
        public List<Models.Event> GetAllEventsAsList()
        {
            var events = new List<Models.Event>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"SELECT 
                                e.id AS EventID,
                                e.event_name AS EventName,
                                e.event_type AS EventType,
                                e.event_description AS EventDescription,
                                e.attendance_limit AS AttendanceLimit,
                                e.publish_status AS PublishStatus,
                                e.event_date AS EventDate,
                                l.city AS LocationCity,
                                e.fee_id AS FeeId,
                                e.admin_id AS AdminId
                                --e.event_image AS EventImage
                            FROM 
                                Events e
                            LEFT JOIN 
                                Locations l ON e.location_id = l.id;
                            ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var ev = new Models.Event
                            {
                                Id = reader.GetInt32(0),
                                EventName = reader.GetString(1),
                                EventType = reader.GetString(2),
                                EventDescription = reader.GetString(3),
                                AttendanceLimit = reader.GetInt32(4),
                                PublishStatus = reader.GetString(5),
                                EventDate = reader.GetString(6),
                                LocationCity = reader.GetString(7),
                                FeeId = reader.GetInt32(8),
                                AdminId = reader.GetInt32(9),
                                //EventImage = reader.IsDBNull(10) ? null : ByteArrayToImage((byte[])reader["EventImage"])
                            };

                            events.Add(ev);
                        }
                    }
                }
            }

            return events;
        }

        // Fetch event details by ID
        public Event GetEventById(int eventId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Events WHERE id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", eventId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Event
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                EventName = reader["event_name"].ToString(),
                                EventDescription = reader["event_description"].ToString(),
                                EventType = reader["event_type"].ToString(),
                                PublishStatus = reader["publish_status"].ToString(),
                                AttendanceLimit = reader.GetInt32(reader.GetOrdinal("attendance_limit")),
                                EventDate = reader["event_date"].ToString(),
                                
                                
                            };
                        }
                    }
                }
            }
            return null;
        }

        //Update Event Details with PopOut Form
        public bool UpdateEvent(Event updatedEvent)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"UPDATE Events
                         SET event_name = @Name,
                             event_description = @Description,
                             event_type = @Type,
                             publish_status = @Status,
                             attendance_limit = @Limit,
                             event_date = @Date
                             WHERE id = @Id";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", updatedEvent.Id);
                    command.Parameters.AddWithValue("@Name", updatedEvent.EventName);
                    command.Parameters.AddWithValue("@Description", updatedEvent.EventDescription);
                    command.Parameters.AddWithValue("@Type", updatedEvent.EventType);
                    command.Parameters.AddWithValue("@Status", updatedEvent.PublishStatus);
                    command.Parameters.AddWithValue("@Limit", updatedEvent.AttendanceLimit);
                    command.Parameters.AddWithValue("@Date", updatedEvent.EventDate);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        //Get all events for the eveent attendees list.
        public DataTable GetAllEventAttendees()
        {
            DataTable attendeesTable = new DataTable();

            string query = @"
        SELECT 
            ea.id AS AttendeeID,
            u.id AS UserID,
            u.name AS UserName,
            e.id AS EventID,
            e.event_name AS EventName,
            ea.joined_at AS JoinedAt
        FROM 
            EventAttendees ea
        JOIN 
            Users u ON ea.user_id = u.id
        JOIN 
            Events e ON ea.event_id = e.id
        ORDER BY 
            ea.joined_at DESC;
    ";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(attendeesTable);
                    }
                }
            }

            return attendeesTable;
        }

        //Remove attendee from admins event attendees form
        public bool RemoveEventAttendee(int attendeeId)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM EventAttendees WHERE id = @AttendeeID";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AttendeeID", attendeeId);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if a row was deleted
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing attendee: {ex.Message}");
                return false;
            }
        }
    }
}