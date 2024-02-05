
using Ticketing.Data.Interfaces.IRepositories;
using Ticketing.Data.Interfaces;
using Ticketing.Services.DTOs;

namespace Ticketing.Services.TicketService.TicketCategoryService.GetAllCategory;
public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, ICollection<TicketCategoryDTO>>
{
    #region DI
    private readonly ITicketCategoryRepository _ticketCategoryRepository;
    public GetAllCategoryQueryHandler(ITicketCategoryRepository ticketCategoryRepository)
    {
        _ticketCategoryRepository = ticketCategoryRepository;
    }
    #endregion
    public async Task<ICollection<TicketCategoryDTO>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
    {
        var getAllCategories = await _ticketCategoryRepository.GetAllAsync();
        return getAllCategories.Select(x => x.ConvertToDTO()).ToList();
    }
}

