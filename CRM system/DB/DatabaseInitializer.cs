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
                    
                    CREATE TABLE IF NOT EXISTS Notifications(
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        user_id INT,
                        type TEXT,
                        message TEXT,
                        created_at TIMESTAMP DATETIME DEFAULT CURRENT_TIMESTAMP
                    );

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

                    CREATE TABLE IF NOT EXISTS Contents(
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        title VARCHAR(255) NOT NULL,
                        content_type TEXT,
                        description TEXT,
                        content_image BLOB,
                        publish_status TEXT CHECK (publish_status IN ('Public', 'Draft')),
                        fee_id INTEGER,
                        admin_id INT NOT NULL,
                        tier_requirement TEXT,
                        created_at TIMESTAMP DATETIME DEFAULT CURRENT_TIMESTAMP,
                        updated_at TIMESTAMP DATETIME DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (admin_id) REFERENCES Users(id) ON DELETE SET NULL ON UPDATE CASCADE,
                        FOREIGN KEY (fee_id) REFERENCES Fee(id) ON DELETE SET NULL ON UPDATE CASCADE
                    );

                    CREATE TABLE IF NOT EXISTS UserContent (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        user_id INT NOT NULL,
                        content_id INT NOT NULL,
                        joined_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY(user_id) REFERENCES Users(id) ON DELETE CASCADE ON UPDATE CASCADE,
                        FOREIGN KEY(content_id) REFERENCES Content(id) ON DELETE CASCADE ON UPDATE CASCADE
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
                        FOREIGN KEY (fee_id) REFERENCES Fee(id),
                        FOREIGN KEY (admin_id) REFERENCES Users(id)
                    );";

                command.ExecuteNonQuery(); // Execute the command to create the table

                Console.WriteLine("Database Initialized");

                connection.Close();
            }
        }
    }
}
