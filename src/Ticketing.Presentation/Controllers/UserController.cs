using Microsoft.AspNetCore.Mvc;
using Ticketing.Data.DTOs;
using Ticketing.Services.UserService.Commands.Create;
using Ticketing.Services.UserService.Commands.Delete;
using Ticketing.Services.UserService.Commands.Login;
using Ticketing.Services.UserService.Commands.Update;
using Ticketing.Services.UserService.Queries.GetAllUsers;

namespace Ticketing.Presentation.Controllers;
public class UserController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<bool>> Register([FromBody] CreateUserCommand command,CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    [HttpPost]
    public async Task<ActionResult<string>> Login([FromBody]LoginUserCommand command,CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    [HttpGet]
    public async Task<ICollection<UserDTO>> GetAllUsers([FromQuery] GetAllUserQuery query, CancellationToken cancellationToken)
        => await Mediator.Send(query, cancellationToken);

    [HttpPut]
    [Route("Confirm/{id?}")]
    public async Task<ActionResult<bool>> UpdateUserInformation([FromBody] UpdateUserCommand command, CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    
    [HttpDelete]
    [Route("Confirm/{id?}")]
    public async Task<bool> DeleteUser(Guid id)
    {
        DeleteUserCommand command = new() { Id = id };
        return await Mediator.Send(command);
    }
        

}

