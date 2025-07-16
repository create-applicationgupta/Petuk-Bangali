using BackendApp.Data;
using BackendApp.Model;
using Microsoft.EntityFrameworkCore;

namespace BackendApp.Repository
{
    public class MenuRepository: IMenuRepository
    {
        private readonly FoodDbContext dbContext;

        public MenuRepository(FoodDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<List<Foods>> GetAllAsync()
        {
            return await dbContext.Foods.ToListAsync();
        }
    }
}
