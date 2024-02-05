

using Ticketing.Data.Interfaces.IRepositories;
using Ticketing.Data.Interfaces;

namespace Ticketing.Services.TicketService.TicketMessegeService.DeleteTicket;
public class DeleteTicketCommandHandler : IRequestHandler<DeleteTicketCommand, bool>
{
    #region DI
    private readonly ITicketMessegeRepository _ticketRepository;
    private readonly IApplicationUnitOfWork _uow;
    public DeleteTicketCommandHandler(ITicketMessegeRepository ticketRepository, IApplicationUnitOfWork uow)
    {
        _ticketRepository = ticketRepository;
        _uow = uow;
    }
    #endregion
    public async Task<bool> Handle(DeleteTicketCommand request, CancellationToken cancellationToken)
    {
        var getTicket = await _ticketRepository.GetByIdAsync(request.Id);
        if (getTicket != null)
            return false;
        bool deleteTicket = _ticketRepository.Delete(getTicket);
        if (deleteTicket)
            return await _uow.SaveChangesAsync();
        return false;
    }
}

