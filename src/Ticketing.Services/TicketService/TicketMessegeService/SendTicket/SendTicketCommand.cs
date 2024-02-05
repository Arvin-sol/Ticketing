
namespace Ticketing.Services.TicketService.TicketMessegeService.SendTicket;
public record SendTicketCommand(Guid sender,string messege,Guid category)
    :IRequest<bool>;

