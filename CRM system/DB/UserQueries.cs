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

        //Method to get total number of users
        public int GetUserCount()
        {
            int count = 0;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string countQuery = "SELECT COUNT(*) FROM Users;";

                using (var command = new SQLiteCommand(countQuery, connection))
                {
                    count = Convert.ToInt32(command.ExecuteScalar());
                }

                connection.Close();
            }

            return count;
        }

        //Retrieve all members in a list
        public DataTable GetAllMemberContacts()
        {
            DataTable memberContacts = new DataTable();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT id AS 'ID', name AS 'Name', email AS 'Email', membership_status AS 'Membership Status' FROM Users;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(memberContacts);
                    }
                }

                connection.Close();
            }

            return memberContacts;
        }

        //Delete user by ID
        public bool RemoveUserById(int userId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM Users WHERE ID = @ID;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", userId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }
        }

        //Add User Directly from admins panel
        public bool AddNewMember(string name, string email, string password)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Users (name, email, password, membership_status) " +
                               "VALUES (@Name, @Email, @Password, 'active');";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", BCrypt.Net.BCrypt.HashPassword(password)); 

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }
        }




    }
}