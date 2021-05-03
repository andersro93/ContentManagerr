using System;

namespace ContentManagerr.Domain.Entities
{
    public class Translation
    {
        public Guid Id { get; set; }
        public Application Application { get; set; }
        public Language Language { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}