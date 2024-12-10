using CRM_system.Models;
using System;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;

namespace CRM_system.DB
{
    public class MembershipQueries
    {
        // Connection string to the SQLite database file
        private string ConnectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "DB", "crm.db") + ";version=3;";

        /// <summary>
        /// Adds a membership for a user with a validity period.
        /// </summary>
        public bool AddMembership(int userId, int membershipId, string startDate, string validUntil)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"
            INSERT INTO Members (user_id, membership_id, start_date, valid_until, status)
            VALUES (@UserId, @MembershipId, @StartDate, @ValidUntil, 'Active');";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@MembershipId", membershipId);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@ValidUntil", validUntil);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Checks if a user already has an active membership already.
        /// </summary>
        public bool HasActiveMembership(int userId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"
            SELECT COUNT(*) 
            FROM Members 
            WHERE user_id = @UserId AND status = 'Active' AND valid_until >= @CurrentDate;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@CurrentDate", DateTime.UtcNow.ToString("yyyy-MM-dd"));

                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        /// <summary>
        /// Retrieves the membership details for a specific user.
        /// It joins the `Members` and `Memberships` tables and fetch details such as
        /// membership name, start date, expiry date, and status.
        /// </summary>
        public MembershipDetails GetMembershipDetails(int userId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"
            SELECT 
                mem.membership_id AS Tier,
                mem.start_date AS MemberSince,
                mem.valid_until AS ValidUntil,
                mem.status AS Status,
                m.name AS MembershipName
            FROM Members mem
            INNER JOIN Memberships m ON mem.membership_id = m.id
            WHERE mem.user_id = @UserId AND mem.status = 'Active';";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new MembershipDetails
                            {
                                Tier = reader["MembershipName"].ToString(), // Use MembershipName for the display
                                MemberSince = DateTime.Parse(reader["MemberSince"].ToString()).ToString("yyyy-MM-dd"),
                                ValidUntil = DateTime.Parse(reader["ValidUntil"].ToString()).ToString("yyyy-MM-dd"),
                                Status = reader["Status"].ToString()
                            };
                        }
                    }
                }
            }
            return null; // Return null if no active membership is found
        }

        /// <summary>
        /// Retrieves the duration in days for a specific membership type.
        /// </summary>
        public int GetMembershipDuration(int membershipId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT duration FROM Memberships WHERE id = @MembershipId;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MembershipId", membershipId);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }



    }
}
