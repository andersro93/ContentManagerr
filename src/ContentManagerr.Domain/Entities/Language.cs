using System;
using System.Collections.Generic;

namespace ContentManagerr.Domain.Entities
{
    public class Language
    {
        public Guid Id { get; set; }
        public Tenant Tenant { get; set; }
        public string Code { get; set; }
        
        public ICollection<Application> Applications { get; set; }
        public ICollection<Translation> Translations { get; set; }
        public ICollection<ArticleVersion> ArticleVersions { get; set; }
        public ICollection<User> Users { get; set; }
    }
}