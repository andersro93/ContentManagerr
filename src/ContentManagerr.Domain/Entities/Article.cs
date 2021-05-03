using System;
using System.Collections.Generic;

namespace ContentManagerr.Domain.Entities
{
    public class Article
    {
        public Guid Id { get; set; }
        public Application Application { get; set; }
        public string Sluggish { get; set; }
        public string Title { get; set; }
        public ArticleVersion ActiveVersion { get; set; }
        public ICollection<ArticleVersion> ArticleVersions { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
        public ArticleStatus Status { get; set; }
    }

    public enum ArticleStatus
    {
        Unknown = 0,
        Published = 1,
        Unpublished = 2,
        Review = 3,
    }
}