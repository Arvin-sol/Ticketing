using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Common;
using Ticketing.Data.Entities.UserEntities;

namespace Ticketing.Data.Interfaces.IRepositories;
public interface IUserRepository
{
    Task<User> FindByEmail(string email);
    Task<User?> GetByIdAsync(Guid id);
    Task<ICollection<User>> GetAllAsync();
    Task<bool> CreateAsync(User model);
    bool Update(User model);
    bool Delete(User model);
}

