using Ticketing.Data.Entities.TicketingEntities;
using Ticketing.Data.Interfaces;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Services.TicketService.TicketMessegeService.SendTicket;
public class SendTicketCommandHandler : IRequestHandler<SendTicketCommand, bool>
{
    #region DI
    private readonly ITicketMessegeRepository _ticketRepository;
    private readonly IApplicationUnitOfWork _uow;
    public SendTicketCommandHandler(ITicketMessegeRepository ticketRepository, IApplicationUnitOfWork uow)
    {
        _ticketRepository = ticketRepository;
        _uow = uow;
    }
    #endregion
    public async Task<bool> Handle(SendTicketCommand request, CancellationToken cancellationToken)
    {

        TicketMessege newMessege = new() 
        { 
            CategoryId = request.category,
            SenderId = request.sender,
            Message = request.messege,
            Status = 0
        };
        var sendMessage = await _ticketRepository.CreateAsync(newMessege);
        if (sendMessage)
            return await _uow.SaveChangesAsync();
        return false;

    }
}

