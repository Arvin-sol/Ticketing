using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Services.RolesService.SetUserRole;
public record SetUserRoleCommand(Guid User , Guid Role):IRequest<bool>;

