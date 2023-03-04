using Distribution.Models.Jobs;
using Distribution.Models.Locations;
using System.Threading.Tasks;

namespace Distribution.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Job> InsertJobAsync(Job job);
    }
}
