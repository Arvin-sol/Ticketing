using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Entities;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Data.Implementations.Repositories;
public class UserRepository(ApplicationDbContext context)
    : GenericRepositoy<User>(context), IUserRepository
{
    public async Task<User> FindByEmail(string email)
        => await _context.users.Where(e=>e.Email == email).FirstOrDefaultAsync();

}

