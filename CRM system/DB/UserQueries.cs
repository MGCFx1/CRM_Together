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
    public class UserQueries
    {
        // Connection string to the SQLite database file
        private string ConnectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "DB", "crm.db") + ";version=3;";

        public void InsertNewUser(string name, string email, string password, string membership, int locationID)
        {
            // Establish a connection to the SQLite database
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Define the SQL INSERT statement
                string insertQuery = "INSERT INTO Users (name, email, password, membership_status, location_id)" +
                                     " VALUES (@name, @email, @password, @membership, @location_id);";

                // Create a command and parameterize the query
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@membership", membership);
                    command.Parameters.AddWithValue("@location_id", locationID);

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
                }

                connection.Close();
            }
        }

        // Method to retrieve all users and return them as a list
        public List<Models.User> GetAllUsers()
        {
            var users = new List<Models.User>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Define the SQL SELECT statement
                string selectQuery = "SELECT * FROM USERS;";

                // Create a command to execute the query
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    // Execute the query and get the result
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming the USERS table has columns like Id, Username, Email, and Password
                            var user = new Models.User
                            {
                                Id = reader.GetInt32(0),  // First column (Id)
                                Name = reader.GetString(1),  // Second column (Username)
                                Email = reader.GetString(2),  // Third column (Email)
                                Password = reader.GetString(3)  // Fourth column (Password)
                            };

                            // Add the user to the list
                            users.Add(user);
                        }
                    }
                }

                connection.Close();
            }

            return users;  // Return the list of users
        }

        // Check if any user with a the same email exists
        public List<Models.User> GetUserByEmail(string email)
        {
            var users = new List<Models.User>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Define the SQL SELECT statement
                string selectQuery = "SELECT * FROM USERS WHERE email=@email;";


                // Create a command to execute the query
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    // Add the email parameter to the command
                    command.Parameters.AddWithValue("@email", email);

                    // Execute the query and get the result
                    using (var reader = command.ExecuteReader())

                    {
                        while (reader.Read())
                        {
                            // Assuming the USERS table has columns like Id, Username, Email, and Password
                            var user = new Models.User
                            {
                                Id = reader.GetInt32(0),  // First column (Id
                                Name = reader.GetString(1),
                                Email = reader.GetString(2),
                                Password = reader.GetString(3)
                            };

                            // Add the user to the list
                            users.Add(user);
                        }
                    }
                }

                connection.Close();
            }

            return users;  // Return the list of users
        }
    }
}
