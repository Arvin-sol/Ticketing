

using Ticketing.Data.Interfaces.IRepositories;
using Ticketing.Data.Interfaces;

namespace Ticketing.Services.TicketService.TicketMessegeService.EditTicket;
public class EditTicketCommandHandler : IRequestHandler<EditTicketCommand, bool>
{
    #region DI
    private readonly ITicketMessegeRepository _ticketRepository;
    private readonly IApplicationUnitOfWork _uow;
    public EditTicketCommandHandler(ITicketMessegeRepository ticketRepository, IApplicationUnitOfWork uow)
    {
        _ticketRepository = ticketRepository;
        _uow = uow;
    }
    #endregion

    public async Task<bool> Handle(EditTicketCommand request, CancellationToken cancellationToken)
    {
        var getTicket = await _ticketRepository.GetByIdAsync(request.Id);
        if (getTicket != null)
            return false;
        getTicket.Message = request.message;
        getTicket.CategoryId = request.CategoryId;
        getTicket.UpdateDate = DateTime.Now;
        return await _uow.SaveChangesAsync();
    }
}

