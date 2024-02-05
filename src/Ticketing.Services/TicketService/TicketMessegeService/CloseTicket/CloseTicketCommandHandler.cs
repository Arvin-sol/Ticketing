
using Ticketing.Data.Interfaces.IRepositories;
using Ticketing.Data.Interfaces;
using Ticketing.Data.Enums;

namespace Ticketing.Services.TicketService.TicketMessegeService.CloseTicket;
public class CloseTicketCommandHandler : IRequestHandler<CloseTicketCommand, bool>
{
    #region DI
    private readonly ITicketMessegeRepository _ticketRepository;
    private readonly IApplicationUnitOfWork _uow;
    public CloseTicketCommandHandler(ITicketMessegeRepository ticketRepository, IApplicationUnitOfWork uow)
    {
        _ticketRepository = ticketRepository;
        _uow = uow;
    }
    #endregion
    public async Task<bool> Handle(CloseTicketCommand request, CancellationToken cancellationToken)
    {
        var getTicket =  await _ticketRepository.GetByIdAsync(request.ticketId);
        if (getTicket == null)
            return false;
        getTicket.Status = ReadOrClosedTicketEnum.Closed;
        return await _uow.SaveChangesAsync();
    }
}

