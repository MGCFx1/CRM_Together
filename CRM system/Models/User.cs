using System;
using System.Data.SQLite;

namespace CRM_system.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // has the user been granted a membership status
        public string MembershipStatus { get; set; }

        // Is user an admin
        public Boolean IsAdmin { get; set; }
        public string CreatedAt { get; set; }
        // When the user last logged in
        public string LastLogin { get; set; }
        
    }
}