using BackendApp.Model;
using Microsoft.EntityFrameworkCore;

namespace BackendApp.Data
{
    public class FoodDbContext:DbContext
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Foods> Foods { get; set; }
    }
}
