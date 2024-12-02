using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CRM_system.DB
{
    public class DatabaseInitializer
    {
        // Connection string for the SQLite Database File
        string ConnectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "DB", "crm.db") + ";version=3;";

        public void InitializeDatabase()
        {



            // Establishing connection to the SQLite DB
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Initializing all the tables automatically in the database
                // Command to create a table if it does not already exist
                var command = connection.CreateCommand();
                command.CommandText = @"

                    CREATE TABLE IF NOT EXISTS Locations (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        city TEXT,
                        address TEXT,
                        postcode TEXT
                    );

                    CREATE TABLE IF NOT EXISTS Users (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        name TEXT NOT NULL,
                        email TEXT NOT NULL,
                        password TEXT NOT NULL,
                        membership_status TEXT CHECK (membership_status IN ('pending', 'active', 'inactive')),
                        membership_type TEXT CHECK (membership_type IN ('none', 'community', 'workspace')),
                        date_of_birth TEXT,
                        is_admin INT CHECK (is_admin IN (0, 1)),
                        location_id INTEGER,
                        created_at TIMESTAMP DATETIME DEFAULT CURRENT_TIMESTAMP,
                        last_login TIMESTAMP DATETIME DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (location_id) REFERENCES Locations(id)
                   );

                    CREATE TABLE IF NOT EXISTS Fee (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        fee_type TEXT CHECK (fee_type IN ('Membership', 'Event', 'Service')),
                        amount FLOAT NOT NULL,
                        currency TEXT CHECK (currency IN ('USD', 'GBP', 'Euro')),
                        description TEXT
                    );

                    CREATE TABLE IF NOT EXISTS Events (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        event_name TEXT NOT NULL,
                        event_type TEXT,
                        event_description TEXT,
                        attendance_limit INTEGER,
                        publish_status TEXT CHECK (publish_status IN ('Public', 'Private', 'Draft')),
                        event_date TEXT,
                        location_id INTEGER,
                        event_image BLOB,
                        fee_id INTEGER,
                        admin_id INTEGER,
                        created_by_admin INTEGER,
                        FOREIGN KEY (location_id) REFERENCES Locations(id),
                        FOREIGN KEY (fee_id) REFERENCES Locations(id),
                        FOREIGN KEY (admin_id) REFERENCES Users(id)
                    );";

                command.ExecuteNonQuery(); // Execute the command to create the table

                Console.WriteLine("Database Initialized");

                connection.Close();
            }
        }
    }
}
