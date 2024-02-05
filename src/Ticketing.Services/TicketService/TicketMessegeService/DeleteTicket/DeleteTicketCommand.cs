

namespace Ticketing.Services.TicketService.TicketMessegeService.DeleteTicket;
public record DeleteTicketCommand(Guid Id):IRequest<bool>;

