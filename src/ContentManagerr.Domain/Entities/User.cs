using System;

namespace ContentManagerr.Domain.Entities
{
    public enum UserStatus
    {
        Unknown = 0,
        Active = 1,
        RequestedAccess = 2,
        Disabled = 3,
    }
    
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public UserStatus Status { get; set; }
    }
}