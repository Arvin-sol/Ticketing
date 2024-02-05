

using Ticketing.Data.Interfaces.IRepositories;
using Ticketing.Data.Interfaces;
using Ticketing.Data.DTOs;

namespace Ticketing.Services.TicketService.TicketMessegeService.GetAllTicket;
public class GetAllTicketQueryHandler : IRequestHandler<GetAllTicketQuery, ICollection<TicketMessegeDTO>>
{
    #region DI
    private readonly ITicketMessegeRepository _ticketRepository;
    private readonly IUserRepository _userRepository;
    private readonly ITicketCategoryRepository _ticketCategoryRepository;
    public GetAllTicketQueryHandler(ITicketMessegeRepository ticketRepository, ITicketCategoryRepository ticketCategoryRepository, IUserRepository userRepository)
    {
        _ticketRepository = ticketRepository;
        _ticketCategoryRepository = ticketCategoryRepository;
        _userRepository = userRepository;
    }
    #endregion

    public async Task<ICollection<TicketMessegeDTO>> Handle(GetAllTicketQuery request, CancellationToken cancellationToken)
    {
        return await _ticketRepository.FillTicketMessegeDTO(cancellationToken);
    }
}

