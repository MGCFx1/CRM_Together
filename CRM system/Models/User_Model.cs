using System;

namespace User_Model.Models
{
    public class User
    {
        // Private Fields
        private int _uid;
        private string _username;
        private string _password;
        private string _email;
        private bool _profileStatus;
        private string _role;
        private string _membershipType;
        private DateTime _createdAt;

        // Properties
        public int Uid
        {
            get { return _uid; }
            set { _uid = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public bool ProfileStatus
        {
            get { return _profileStatus; }
            set { _profileStatus = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public string MembershipType
        {
            get { return _membershipType; }
            set { _membershipType = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        // Constructor
        public User()
        {
            _createdAt = DateTime.Now; // Set default created date
        }

        // Methods
        public bool Login(string username, string password)
        {
            // Example: Perform login logic
            return (username == _username && password == _password);
        }

        public void ViewDashboard()
        {
            // Example: Logic for viewing dashboard
            // Typically, this would redirect to the dashboard view
            View("Dashboard");
        }
    }
}
