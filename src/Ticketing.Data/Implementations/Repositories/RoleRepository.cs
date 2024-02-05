using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Entities.UserEntities;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Data.Implementations.Repositories;
public class RoleRepository(ApplicationDbContext context)
    : GenericRepositoy<Role>(context), IRoleRepository
{    
}
