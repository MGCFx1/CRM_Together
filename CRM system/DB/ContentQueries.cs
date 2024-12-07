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
    public class ContentQueries
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
        public bool AddContent(string title, string content_type, string description, Image content_image, string publishStatus, int fee, int user_id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO contents (title, content_type, description, content_image, " +
                               "publish_status, admin_id, fee_id) " +
                               "VALUES (@title, @content_type, @description, @content_image, @publish_status," +
                               " @admin_id, @fee_id);";

                Console.WriteLine("Converted" + BitConverter.ToString(ImageToByteArray(content_image)));

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@content_type", content_type);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@content_image", ImageToByteArray(content_image));
                    command.Parameters.AddWithValue("@publish_status", publishStatus);
                    //command.Parameters.AddWithValue("@attendance_limit", attendance_limit);
                    command.Parameters.AddWithValue("@fee_id", fee);
                    command.Parameters.AddWithValue("@admin_id", user_id);

                    return command.ExecuteNonQuery() > 0;
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
        public bool DeleteContent(int contentId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM Contents WHERE id = @Id;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", contentId);

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
        public List<Models.Contents> GetAllContentAsList()
        {
            var contents = new List<Models.Contents>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"SELECT 
                                c.id AS ContentID,
                                c.title AS ContentTitle,
                                c.content_type AS ContentType,
                                c.description AS ContentDescription,
                                --c.attendance_limit AS AttendanceLimit,
                                c.publish_status AS PublishStatus,
                                c.created_at AS CreatedAt,
                                c.updated_at AS UpdatedAt,
                                f.amount AS Amount,
                                f.currency AS Currency,
                                c.admin_id AS AdminId
                                --c.Content_image AS ContentImage
                            FROM 
                                Contents c
                            JOIN 
                               fee f
                            ON
                                c.fee_id=f.id;
                            ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var content = new Models.Contents
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                ContentType = reader.GetString(2),
                                Description = reader.GetString(3),
                                PublishStatus = reader.GetString(4),
                                CreatedAt = reader.GetString(5),
                                UpdatedAt = reader.GetString(6),
                                Amount = reader.GetFloat(7).ToString("0.00"),
                                Currency = reader.GetString(8),
                                AdminID = reader.GetInt32(9),
                                //EventImage = reader.IsDBNull(10) ? null : ByteArrayToImage((byte[])reader["EventImage"])
                            };

                            contents.Add(content);
                        }
                    }
                }
            }

            return contents;
        }

        // Fetch event details by ID
        public Contents GetContentById(int contentId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Contents WHERE id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", contentId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Contents
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Title = reader["title"].ToString(),
                                Description = reader["description"].ToString(),
                                ContentType = reader["content_type"].ToString(),
                                PublishStatus = reader["publish_status"].ToString(),
                                //AttendanceLimit = reader.GetInt32(reader.GetOrdinal("attendance_limit")),
                                //EventDate = reader["event_date"].ToString(),
                            };
                        }
                    }
                }
            }
            return null;
        }

        //Update Event Details with PopOut Form
        public bool updateContent(Contents updateContent)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"UPDATE Contents
                         SET title = @Title,
                             description = @Description,
                             content_type = @Type,
                             publish_status = @Status,
                             --attendance_limit = @Limit,
                             updated_at = @UpdatedAt
                         WHERE id = @Id";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", updateContent.Id);
                    command.Parameters.AddWithValue("@Title", updateContent.Title);
                    command.Parameters.AddWithValue("@Description", updateContent.Description);
                    command.Parameters.AddWithValue("@Type", updateContent.ContentType);
                    command.Parameters.AddWithValue("@Status", updateContent.PublishStatus);
                    //command.Parameters.AddWithValue("@Limit", updateContent.AttendanceLimit);
                    //command.Parameters.AddWithValue("@Date", updateContent.EventDate);
                    command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now); // Use current timestamp

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
