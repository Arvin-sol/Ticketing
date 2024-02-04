using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Ticketing.Services.RolesService.Create;
using Ticketing.Services.RolesService.SetUserRole;

namespace Ticketing.Presentation.Controllers;
public class RoleController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<bool>> CreateNewRole([FromBody] CreateRoleCommand command, CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    [HttpPost]
    public async Task<ActionResult<bool>> SetRoleForUser([FromBody] SetUserRoleCommand command, CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.FindFirstValue("Id");
        return await Mediator.Send(command, cancellationToken);
    }
}

