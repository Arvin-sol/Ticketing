

using Ticketing.Data.Interfaces.IRepositories;
using Ticketing.Data.Interfaces;
using Azure.Core;

namespace Ticketing.Services.TicketService.TicketCategoryService.DeleteCategory;
public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, bool>
{
    #region DI
    private readonly ITicketCategoryRepository _ticketCategoryRepository;
    private readonly IApplicationUnitOfWork _uow;
    public DeleteCategoryCommandHandler(IApplicationUnitOfWork uow, ITicketCategoryRepository ticketCategoryRepository)
    {
        _ticketCategoryRepository = ticketCategoryRepository;
        _uow = uow;
    }
    #endregion
    public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var getCategory = await _ticketCategoryRepository.GetByIdAsync(request.Id);
        if (getCategory == null)
            return false;
        bool deleteCategory =  _ticketCategoryRepository.Delete(getCategory);
        if (deleteCategory)
            return await _uow.SaveChangesAsync();
        return false;
    }
}

