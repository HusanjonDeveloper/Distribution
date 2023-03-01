using System.Threading.Tasks;
using Distribution.Models.Locations;

namespace Distribution.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Location> InsertLocationAsync(Location location);
    }
}
