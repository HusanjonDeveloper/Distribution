using Distribution.Models.Salares;
using Microsoft.EntityFrameworkCore;

namespace Distribution.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Salary> Salaries { get; set; } 
    }
}
