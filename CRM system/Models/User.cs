using System;
using System.Data.SQLite;

namespace CRM_system.Models
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        // has the user been granted a membership status
        public string membership_status { get; set; }

        // Is user an admin
        public Boolean isAdmin { get; set; }
        public string createdAt { get; set; }
        // When the user last logged in
        public string lastLogin { get; set; }
        
    }
}