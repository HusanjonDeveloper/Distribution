using Distribution.Models.Languages;
using Microsoft.EntityFrameworkCore;

namespace Distribution.Brokers.Storages
{
    public partial class StorageBroker
    {

        public DbSet<Language> Languages { get; set; }
    }
}
