using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Services.TicketService.TicketMessegeService.CloseTicket;
public record CloseTicketCommand(Guid ticketId):IRequest<bool>;

