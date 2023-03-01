using System.Threading.Tasks;
using Distribution.Models.Locations;
using Microsoft.EntityFrameworkCore;

namespace Distribution.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Location> Locations { get; set; }
      public async ValueTask<Location> InsertLocationAsync(Location location) =>
            await InsertAsync(location);

    }
}
