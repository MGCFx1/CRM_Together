using CRM_system.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_system.DB
{
    public class LocationQueries
    {
        // Connection string to the SQLite database file
        private string ConnectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "DB", "crm.db") + ";version=3;";

        public int InsertNewLocation(string city, string address, string postcode)
        {

            int newLocationId = -1;

            // Establish a connection to the SQLite database
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Define the SQL INSERT statement
                string insertQuery = "INSERT INTO Locations (city, address, postcode) VALUES (@city, @address, @postcode);";

                // Create a command and parameterize the query
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@postcode", postcode);

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
                }

                // Retrieve the ID of the newly inserted row
                using (var command = new SQLiteCommand("SELECT last_insert_rowid();", connection))
                {
                    newLocationId = Convert.ToInt32(command.ExecuteScalar());
                }


                connection.Close();
            }

            return newLocationId;
        }

        // Check if any user with a the same email exists
        public List<Models.Location> GetLocationByID(int id)
        {
            var locations = new List<Models.Location>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Define the SQL SELECT statement
                string selectQuery = "SELECT * FROM locations WHERE id=@id;";


                // Create a command to execute the query
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    // Add the email parameter to the command
                    command.Parameters.AddWithValue("@id", id);

                    // Execute the query and get the result
                    using (var reader = command.ExecuteReader())

                    {
                        while (reader.Read())
                        {
                            // Assuming the USERS table has columns like Id, Username, Email, and Password
                            var location = new Models.Location
                            {
                                Id = reader.GetInt32(0),  // First column (Id
                                City = reader.GetString(1),
                                Address = reader.GetString(2),
                                PostCode = reader.GetString(3)

                            };

                            // Add the user to the list
                            locations.Add(location);
                        }
                    }
                }

                connection.Close();
            }

            return locations;  // Return the list of users
        }
    }
}
