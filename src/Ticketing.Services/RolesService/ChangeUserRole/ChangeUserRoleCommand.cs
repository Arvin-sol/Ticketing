using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Services.RolesService.ChangeUserRole;
public record ChangeUserRoleCommand(Guid UserId ,Guid RoleId):IRequest<bool>;

