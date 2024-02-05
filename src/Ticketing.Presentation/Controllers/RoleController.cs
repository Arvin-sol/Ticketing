using Microsoft.AspNetCore.Mvc;
using Ticketing.Services.DTOs;
using Ticketing.Services.RolesService.Create;
using Ticketing.Services.RolesService.GetAllRols;
using Ticketing.Services.RolesService.SetUserRole;

namespace Ticketing.Presentation.Controllers;
public class RoleController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<bool>> CreateNewRole([FromBody] CreateRoleCommand command, CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);

    [HttpGet]
    public async Task<ICollection<RoleDTO>> GetAllRoles([FromQuery] GetAllRolesQuery query)
        => await Mediator.Send(query);

    [HttpPost]
    public async Task<ActionResult<bool>> SetRoleForUser([FromBody]SetUserRoleCommand command,CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    
}

