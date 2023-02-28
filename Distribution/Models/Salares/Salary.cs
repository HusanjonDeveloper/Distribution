using System;

namespace Distribution.Models.Salares
{
    public class Salary
    {
        public Guid id { get; set; }
        public decimal Amount { get; set; }
        public int Experience { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public Guid Locationld { get; set; }
        public Guid Languageld { get; set; }
        public Guid Jobld { get; set; }
    }
}
