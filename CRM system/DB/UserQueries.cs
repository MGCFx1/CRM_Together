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

        public void InsertNewUser(string name, string email, string password)
        {
            // Establish a connection to the SQLite database
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Define the SQL INSERT statement
                string insertQuery = "INSERT INTO Users (name, email, password) VALUES (@name, @email, @password);";

                // Create a command and parameterize the query
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
                }

                connection.Close();
            }
        }

        // Method to retrieve all users and return them as a list
        public List<User> GetAllUsers()
        {
            var users = new List<User>();

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
                            var user = new User
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

        // Method to check if a user with the same username exists
        public List<User> GetUserByUsername(string username)
        {
            var users = new List<User>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Define the SQL SELECT statement
                string selectQuery = "SELECT * FROM USERS WHERE username=@username;";

                // Create a command to execute the query
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    // Execute the query and get the result
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming the USERS table has columns like Id, Username, Email, and Password
                            var user = new User
                            {
                                Id = reader.GetInt32(0),  // First column (Id)
                                Name = reader.GetString(1),
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

        // Check if any user with a the same email exists
        public List<User> GetUserByEmail(string email)
        {
            var users = new List<User>();

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
                            var user = new User
                            {
                                Id = reader.GetInt32(0),  // First column (Id
                                Email = reader.GetString(1),
                                Name = reader.GetString(2)
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
