using System;
using System.Collections.Generic;

namespace ContentManagerr.Domain.Entities
{
    public class ArticleVersion
    {
        public Guid Id { get; set; }
        public Article Article { get; set; }
        public Language Language { get; set; }
        public string Value { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
        
        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }
        public User DeletedBy { get; set; }
    }
}