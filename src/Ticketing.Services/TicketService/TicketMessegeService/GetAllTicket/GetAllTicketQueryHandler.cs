

using Ticketing.Data.Interfaces.IRepositories;
using Ticketing.Data.Interfaces;
using Ticketing.Services.DTOs;

namespace Ticketing.Services.TicketService.TicketMessegeService.GetAllTicket;
public class GetAllTicketQueryHandler : IRequestHandler<GetAllTicketQuery, ICollection<TicketMessegeDTO>>
{
    #region DI
    private readonly ITicketMessegeRepository _ticketRepository;
    private readonly IApplicationUnitOfWork _uow;
    public GetAllTicketQueryHandler(ITicketMessegeRepository ticketRepository, IApplicationUnitOfWork uow)
    {
        _ticketRepository = ticketRepository;
        _uow = uow;
    }
    #endregion

    public Task<ICollection<TicketMessegeDTO>> Handle(GetAllTicketQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

