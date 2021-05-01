using System;

namespace ContentManagerr.Domain.Entities
{
    public class Application
    {
        public Guid Id { get; set; }
        public Tenant Owner { get; set; }
        public string Name { get; set; }
    }
}