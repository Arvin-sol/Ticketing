
using Microsoft.AspNetCore.Http.Features;
using Ticketing.Data.Entities.TicketingEntities;
using Ticketing.Data.Interfaces;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Services.TicketService.TicketCategoryService.CreateCategory;
public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, bool>
{
    #region DI
    private readonly ITicketCategoryRepository _ticketCategoryRepository;
    private readonly IApplicationUnitOfWork _uow;
    public CreateCategoryCommandHandler(IApplicationUnitOfWork uow, ITicketCategoryRepository ticketCategoryRepository)
    {
        _ticketCategoryRepository = ticketCategoryRepository;
        _uow = uow;
    }
    #endregion
    public async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        TicketCategory newCategory = new()
        {
            CategoryTitle = request.CategoryTitle,
        };
        bool setNewCategory =  await _ticketCategoryRepository.CreateAsync(newCategory);
        if (setNewCategory)
            return await _uow.SaveChangesAsync();
        return false;
    }
}

