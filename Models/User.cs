﻿namespace JK_Backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Zipcode{ get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string RequestedAmount { get; set; }
        public string VisitorId { get; set; }
    }

}
