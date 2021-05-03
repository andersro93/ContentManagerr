using System;
using System.Collections.Generic;

namespace ContentManagerr.Domain.Entities
{
    public enum TenantStatus
    {
        Unknown = 0,
        Active = 1,
        Disabled = 2,
    }
    
    public class Tenant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Application> Applications { get; set; }
        public TenantStatus Status { get; set; }
    }
}