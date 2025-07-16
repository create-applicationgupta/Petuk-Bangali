using BackendApp.Data;
using BackendApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly FoodDbContext _dbContext;
        private readonly IMenuRepository _menuRepository;
        public MenuController(FoodDbContext dbContext, IMenuRepository menuRepository)
        {
           _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
           _menuRepository = menuRepository ?? throw new ArgumentNullException(nameof(menuRepository));
        }

        [HttpGet]
        //[Authorize(Roles = "Reader")]
        public async Task<IActionResult> GetAllItems()
        {
            var regionsDomain = await _menuRepository.GetAllAsync();

            return Ok(regionsDomain);
        }
    }
}
