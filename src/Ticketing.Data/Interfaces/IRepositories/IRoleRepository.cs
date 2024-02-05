using Ticketing.Data.Entities;

namespace Ticketing.Data.Interfaces.IRepositories;
public interface IRoleRepository
{
    Task<Role?> GetByIdAsync(Guid id);
    Task<ICollection<Role>> GetAllAsync();
    Task<bool> CreateAsync(Role model);
    bool Update(Role model);
    bool Delete(Role model);
}

