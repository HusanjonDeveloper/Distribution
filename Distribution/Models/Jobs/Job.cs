using System;

namespace Distribution.Models.Jobs
{
    public class Job
    {
        public Guid id { get; set; }
        public string Title { get; set; }
        public Level  Level { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
