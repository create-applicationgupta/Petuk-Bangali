using BackendApp.Model;

namespace BackendApp.Repository
{
    public interface IMenuRepository
    {
        Task<List<Foods>> GetAllAsync();

        //Task<Region?> GetByIdAsync(Guid id);
    }
}
