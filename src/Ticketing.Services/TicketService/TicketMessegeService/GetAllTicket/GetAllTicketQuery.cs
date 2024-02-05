
using Ticketing.Services.DTOs;

namespace Ticketing.Services.TicketService.TicketMessegeService.GetAllTicket;
public record GetAllTicketQuery:IRequest<ICollection<TicketMessegeDTO>>;

