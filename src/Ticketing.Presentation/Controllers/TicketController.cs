using Microsoft.AspNetCore.Mvc;
using Ticketing.Data.DTOs;
using Ticketing.Services.TicketService.TicketCategoryService.GetAllCategory;
using Ticketing.Services.TicketService.TicketMessegeService.DeleteTicket;
using Ticketing.Services.TicketService.TicketMessegeService.EditTicket;
using Ticketing.Services.TicketService.TicketMessegeService.SendTicket;

namespace Ticketing.Presentation.Controllers;
public class TicketController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<bool>> SendTicket([FromBody]SendTicketCommand command,CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    [HttpPut]
    [Route("Confirm/{id?}")]
    public async Task<ActionResult<bool>> EditTicket([FromBody]EditTicketCommand command,CancellationToken cancellationToken)
        => await Mediator.Send(command,cancellationToken);
    [HttpDelete]
    [Route("Confirm/{id?}")]
    public async Task<ActionResult<bool>> DeleteTicket([FromBody]DeleteTicketCommand command, CancellationToken cancellationToken)
    => await Mediator.Send(command, cancellationToken);

    [HttpGet]
    public async Task<ICollection<TicketCategoryDTO>> GetCategory([FromQuery] GetAllCategoryQuery query, CancellationToken cancellationToken)
        => await Mediator.Send(query, cancellationToken);

}

