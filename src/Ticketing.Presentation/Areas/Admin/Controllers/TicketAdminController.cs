using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Data.DTOs;
using Ticketing.Services.TicketService.TicketCategoryService.CreateCategory;
using Ticketing.Services.TicketService.TicketMessegeService.CloseTicket;
using Ticketing.Services.TicketService.TicketMessegeService.DeleteTicket;
using Ticketing.Services.TicketService.TicketMessegeService.EditTicket;
using Ticketing.Services.TicketService.TicketMessegeService.GetAllTicket;
using Ticketing.Services.TicketService.TicketMessegeService.SendTicket;

namespace Ticketing.Presentation.Areas.Admin.Controllers;
public class TicketAdminController : BaseAdminController
{
    [Authorize]
    [HttpPost]
    public async Task<ActionResult<bool>> SendTicket([FromBody]SendTicketCommand command, CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    [Authorize]
    [HttpPut]
    public async Task<ActionResult<bool>> EditTicket([FromBody] EditTicketCommand command, CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    [Authorize]
    [HttpDelete]
    public async Task<ActionResult<bool>> DeleteTicket([FromBody]DeleteTicketCommand command, CancellationToken cancellationToken)
        =>await Mediator.Send(command, cancellationToken);
    [Authorize]
    [HttpPost]
    public async Task<ActionResult<bool>> CloseTicket([FromBody]CloseTicketCommand command, CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    [Authorize]
    [HttpPost]
    public async Task<ICollection<TicketMessegeDTO>> GetAllTicket([FromBody]GetAllTicketQuery query, CancellationToken cancellationToken)
        => await Mediator.Send(query, cancellationToken);

}

