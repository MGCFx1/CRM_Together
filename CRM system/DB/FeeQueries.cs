using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_system.DB
{
    public class FeeQueries
    {
        // Connection string to the SQLite database file
        private string ConnectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "DB", "crm.db") + ";version=3;";

        public int InsertFee(string fee_type, float amount, string currency_type, string description)
        {

            int newFeeId = -1;

            // Establish a connection to the SQLite database
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Define the SQL INSERT statement
                string insertQuery = "INSERT INTO Fee (fee_type, amount, currency, description) " +
                    "VALUES (@fee_type, @amount, @currency, @description);";

                // Create a command and parameterize the query
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@fee_type", fee_type);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@currency", currency_type);
                    command.Parameters.AddWithValue("@description", description);

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted successfully in Fee.");
                }

                // Retrieve the ID of the newly inserted row
                using (var command = new SQLiteCommand("SELECT last_insert_rowid();", connection))
                {
                    newFeeId = Convert.ToInt32(command.ExecuteScalar());
                }


                connection.Close();
            }

            return newFeeId;
        }
        // Check if any user with a the same email exists
        public List<Models.Fee> GetFeeById(int id)
        {
            var fees = new List<Models.Fee>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Define the SQL SELECT statement
                string selectQuery = "SELECT * FROM fee WHERE id=@id;";


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
                            var fee = new Models.Fee
                            {
                                Id = reader.GetInt32(0),  // First column (Id
                                Currency = reader.GetString(1),
                                Amount = reader.GetString(2),
                                FeeType = reader.GetString(3)

                            };

                            // Add the user to the list
                            fees.Add(fee);
                        }
                    }
                }

                connection.Close();
            }

            return fees;  // Return the list of users
        }
    }
}
