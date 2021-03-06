using System;
using System.Collections.Generic;

namespace ContentManagerr.Domain.Entities
{
    public class Application
    {
        public Guid Id { get; set; }
        public Tenant Tenant { get; set; }
        public string Name { get; set; }
        
        public ICollection<Language> Languages { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<Translation> Translations { get; set; }
    }
}