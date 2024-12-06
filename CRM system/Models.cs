using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

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
        public string MembershipType { get; set; }
        public string UserDateOfBirth { get; set; }
        // Is user an admin
        public Boolean IsAdmin { get; set; }
        public int LocationID {get; set;}
        public string CreatedAt { get; set; }
        // When the user last logged in
        public string LastLogin { get; set; }
        
    }

    public class Location
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
    }

    public class Fee
    {
        public int Id { get; set; }
        public string FeeType { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
    }

    public class Event
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventType { get; set; }
        public string EventDescription { get; set; }
        public int AttendanceLimit { get; set; }
        public string EventDate { get; set; }
        public string PublishStatus { get; set; }
        public String LocationCity { get; set; }
        public int FeeId { get; set; }
        public string FeeAmount { get; set; }
        public string FeeCurrency { get; set; }
        public int AdminId { get; set; }
        public Image EventImage { get; set; }
    }

    //Retrieve membership details
    public class MembershipDetails
    {
        public string Tier { get; set; }
        public string MemberSince { get; set; }
        public string Status { get; set; }
    }

}

public class Notifcations
{
    public int Id { get; set; }
    public int UserID { get; set; }
    public string Type { get; set; }
    public string CreatedAt { get; set; }
}





