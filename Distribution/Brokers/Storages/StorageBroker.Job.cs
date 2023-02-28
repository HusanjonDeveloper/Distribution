using Distribution.Models.Jobs;
using Microsoft.EntityFrameworkCore;

namespace Distribution.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Job> Jobs { get; set; }    
    }
}
