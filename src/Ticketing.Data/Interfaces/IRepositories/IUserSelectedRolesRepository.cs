using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Entities;

namespace Ticketing.Data.Interfaces.IRepositories;
public interface IUserSelectedRolesRepository
{
    Task<UserSelectedRols?> GetByUserIdAsync(Guid id);
    Task<ICollection<UserSelectedRols>> GetAllAsync();
    Task<bool> CreateAsync(UserSelectedRols model);
    bool Update(UserSelectedRols model);
    bool Delete(UserSelectedRols model);
}

