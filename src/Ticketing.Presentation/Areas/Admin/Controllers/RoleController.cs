using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Data.DTOs;
using Ticketing.Services.RolesService.ChangeUserRole;
using Ticketing.Services.RolesService.Create;
using Ticketing.Services.RolesService.GetAllRols;
using Ticketing.Services.RolesService.SetUserRole;
using Ticketing.Services.UserService.Queries.GetAllUsers;

namespace Ticketing.Presentation.Areas.Admin.Controllers;
public class RoleController : BaseAdminController
{
    [Authorize]
    [HttpPost]
    public async Task<ActionResult<bool>> CreateNewRole([FromBody] CreateRoleCommand command, CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    [Authorize]
    [HttpGet]
    public async Task<ICollection<RoleDTO>> GetAllRoles([FromQuery] GetAllRolesQuery query)
        => await Mediator.Send(query);
    [Authorize]
    [HttpGet]
    public async Task<ICollection<UserDTO>> GetAllUsers([FromQuery]GetAllUserQuery query)
    => await Mediator.Send(query);
    [Authorize]
    [HttpPost]
    public async Task<ActionResult<bool>> SetRoleForUser([FromBody] SetUserRoleCommand command, CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    [Authorize]
    [HttpPut]
    public async Task<ActionResult<bool>> ChangeUserRole([FromBody] ChangeUserRoleCommand command, CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);

}

