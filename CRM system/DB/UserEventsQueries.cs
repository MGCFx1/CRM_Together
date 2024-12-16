using CRM_system.Models;
using OfficeOpenXml;
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
                            f.amount AS FeeAmount,
                            f.currency AS FeeCurrency,
                            e.event_image AS EventImage
                        FROM 
                            Events e
                        LEFT JOIN 
                            Locations l ON l.id = e.location_id
                        LEFT JOIN
                            Fee f ON f.id = e.fee_id
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
                                    EventType = reader.GetString(3),
                                    AttendanceLimit = reader.GetInt32(4),
                                    EventDate = reader.GetString(5),
                                    LocationCity = reader.IsDBNull(6) ? "Unknown City" : reader.GetString(6),
                                    FeeId = reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                                    FeeAmount = reader.IsDBNull(8) ? "0" : reader.GetDecimal(8).ToString("F2"),
                                    FeeCurrency = reader.IsDBNull(9) ? "N/A" : reader.GetString(9),
                                    EventImage = reader.IsDBNull(10) ? null : EventQueries.ByteArrayToImage((byte[])reader["EventImage"]) // Load image if available
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
        /// Retrieves a list of events joined by a specific user from the database.
        /// </summary>
        /// <param name="userId">ID of the user who joined events are to be retrieved.</param>
        /// /// <returns>A DataTable contains details of the events the user joined.</returns>
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

        public void GenerateEventsReport()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string query = @"SELECT 
                            e.id AS 'Event ID',
                            e.event_name AS 'Event Name',
                            e.event_type AS 'Event Type',
                            e.event_description AS 'Event Description',
                            e.event_date AS 'Event Date',
                            e.publish_status AS 'Publish Status',
                            e.attendance_limit AS 'Attendance Limit',
                            ROUND((COUNT(ea.user_id) * 100.0) / e.attendance_limit, 2) || '%' AS 'Attendance Percentage',
                            COUNT(ea.user_id) AS 'Total Attendees',
                            f.currency AS 'Currency',
                            f.amount AS 'Amount'
                            FROM Events e LEFT JOIN 
                            EventAttendees ea ON e.id = ea.event_id 
                            LEFT JOIN 
                            Fee f ON e.fee_id = f.id
                            GROUP BY 
                            e.id, e.event_name, e.event_type, e.event_description, e.attendance_limit, 'Total Attendees', 'Attendance Percentage', e.event_date, e.publish_status, f.currency, f.amount;
                        ";

            // Path for the Reports folder
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string reportsFolder = Path.Combine(projectDirectory, "..", "..", "Reports");

            // Ensure the Reports folder exists
            if (!Directory.Exists(reportsFolder))
            {
                Directory.CreateDirectory(reportsFolder);
            }

            // File path for the Excel file
            string filePath = Path.Combine(reportsFolder, "EventReport.xlsx");

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    // Load the data into a DataTable
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Create the Excel file
                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Users");
                        worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                        // Save the file in the Reports folder
                        FileInfo fileInfo = new FileInfo(filePath);
                        package.SaveAs(fileInfo);

                        Console.WriteLine($"Excel report generated at: {filePath}");
                    }
                }
            }
        }

        /// <summary>
        /// Generates an Excel report of all non-admin users, including their details,
        /// number of events joined, and participation percentage.
        /// </summary>
        public void GenerateUsersReport()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string query = @"SELECT u.id AS 'User ID', 
                            u.name AS 'Name', 
                            u.email AS 'Email', 
                            u.membership_status AS 'Membership Status', 
                            u.membership_type AS 'Membership Type',
                            u.date_of_birth AS 'Date of Birth',
                            l.city AS 'City',
                            u.created_at, 
                            u.last_login,
                            COUNT(ea.event_id) AS 'Events Joined',
                            ROUND((COUNT(ea.event_id) * 100.0) / (SELECT COUNT(*) FROM Events), 2) || '%' AS 'Participation Percentage'
                            FROM USERS u 
                            LEFT JOIN
                            locations l ON l.id=u.location_id
                            LEFT JOIN 
                            EventAttendees ea ON u.id = ea.user_id                          
                            WHERE is_admin=0
                            GROUP BY 
                            u.id, u.name, u.email, u.membership_status, u.membership_type, 
                            u.date_of_birth, u.created_at, u.last_login;
                            ";

            // Path for the Reports folder
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string reportsFolder = Path.Combine(projectDirectory, "..", "..", "Reports");

            // Ensure the Reports folder exists
            if (!Directory.Exists(reportsFolder))
            {
                Directory.CreateDirectory(reportsFolder);
            }

            // File path for the Excel file
            string filePath = Path.Combine(reportsFolder, "UsersReport.xlsx");

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    // Load the data into a DataTable
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Create the Excel file
                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Users");
                        worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                        // Save the file in the Reports folder
                        FileInfo fileInfo = new FileInfo(filePath);
                        package.SaveAs(fileInfo);

                        Console.WriteLine($"Excel report generated at: {filePath}");
                    }
                }
            }
        }

        /// <summary>
        /// Removes a user from a specific event and generates a notification
        /// to inform the user that they have left the event.
        /// </summary>
        /// <param name="userId">The ID of the user to be removed.</param>
        /// <param name="eventId">The ID of the event the user wants to leave.</param>
        /// <returns>True if the user is successfully removed and notified; otherwise, false.</returns>
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