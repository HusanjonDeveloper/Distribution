using System.Threading.Tasks;
using Distribution.Models.Languages;
using Microsoft.EntityFrameworkCore;

namespace Distribution.Brokers.Storages
{
    public partial class StorageBroker
    {

        public DbSet<Language> Languages { get; set; }
       public async ValueTask<Language> InsertLanguagesAsync(Language language)=>
            await InsertAsync(language);
    }
}
