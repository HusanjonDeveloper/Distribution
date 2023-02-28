using System;

namespace Distribution.Models.Locations
{
    public class Location
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public Countyr Countyr { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }

    }
}
