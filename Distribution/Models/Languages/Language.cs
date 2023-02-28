using System;

namespace Distribution.Models.Languages
{
    public class Language
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public Type  Type { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
