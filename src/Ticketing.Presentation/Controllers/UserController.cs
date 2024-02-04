using Microsoft.AspNetCore.Mvc;
using Ticketing.Services.UserService.Commands.Create;
using Ticketing.Services.UserService.Commands.Login;

namespace Ticketing.Presentation.Controllers;
public class UserController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<bool>> Register([FromBody] CreateUserCommand command,CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    [HttpPost]
    public async Task<ActionResult<bool>> Login([FromBody]LoginUserCommand command,CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    
}

