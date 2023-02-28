using Distribution.Models.Locations;
using Microsoft.EntityFrameworkCore;

namespace Distribution.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Location> Locations { get; set; }
    }
}
