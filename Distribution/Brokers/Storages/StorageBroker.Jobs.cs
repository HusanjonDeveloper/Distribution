using System.Threading.Tasks;
using Distribution.Models.Jobs;
using Microsoft.EntityFrameworkCore;

namespace Distribution.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Job> Jobs { get; set; }
       public async ValueTask<Job> InsertJobAsync(Job job) =>
            await InsertAsync(job);
    }
}
