
using Ticketing.Data.Entities;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Data.Implementations.Repositories;
public class UserSelectedRolesRepository(ApplicationDbContext context)
    : GenericRepositoy<UserSelectedRols>(context), IUserSelectedRolesRepository
{
    public async Task<UserSelectedRols?> GetByUserIdAsync(Guid id)
    => await _context.Set<UserSelectedRols>().Where(u=>u.UserId ==id).FirstOrDefaultAsync();
    
}

