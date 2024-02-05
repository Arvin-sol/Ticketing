using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Interfaces.IRepositories;
using Ticketing.Data.Interfaces;

namespace Ticketing.Services.TicketService.TicketCategoryService.UpdateCategory;
public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, bool>
{
    private readonly ITicketCategoryRepository _ticketCategoryRepository;
    private readonly IApplicationUnitOfWork _uow;
    public UpdateCategoryCommandHandler(IApplicationUnitOfWork uow, ITicketCategoryRepository ticketCategoryRepository)
    {
        _ticketCategoryRepository = ticketCategoryRepository;
        _uow = uow;
    }
    public async Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var getCategory = await _ticketCategoryRepository.GetByIdAsync(request.Id);
        if (getCategory == null)
            return false;
        getCategory.CategoryTitle = request.Title;
        getCategory.UpdateDate = DateTime.Now;
        var update =  _ticketCategoryRepository.Update(getCategory);
        if(update)
            return await _uow.SaveChangesAsync();
        return false;

    }
}

