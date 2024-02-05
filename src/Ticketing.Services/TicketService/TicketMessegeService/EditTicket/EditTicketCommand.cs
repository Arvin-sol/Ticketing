

namespace Ticketing.Services.TicketService.TicketMessegeService.EditTicket;
public record EditTicketCommand(Guid Id ,string message,Guid CategoryId ):IRequest<bool>;

