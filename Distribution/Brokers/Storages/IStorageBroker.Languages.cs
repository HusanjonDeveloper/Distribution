using Distribution.Models.Jobs;
using Distribution.Models.Languages;
using System.Threading.Tasks;

namespace Distribution.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Language> InsertLanguagesAsync(Language language);
    }
}
