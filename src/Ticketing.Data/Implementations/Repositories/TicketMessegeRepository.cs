using Ticketing.Data.DTOs;
using Ticketing.Data.Entities.TicketingEntities;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Data.Implementations.Repositories;
public class TicketMessegeRepository(ApplicationDbContext context)
    : GenericRepositoy<TicketMessege>(context), ITicketMessegeRepository
{
    public async Task<List<TicketMessegeDTO>> FillTicketMessegeDTO(CancellationToken token)
    {
        return await _context.TicketMesseges.AsNoTracking().Select(p => new TicketMessegeDTO()
        {
            CategoryTitle = _context.TicketCategories.AsNoTracking().Where(c=>c.Id==p.CategoryId).Select(c=>c.CategoryTitle).First(),
            message = p.Message,
            Status = p.Status,
            senderName = _context.users.AsNoTracking().Where(u => u.Id == p.SenderId).Select(u => u.Name).First()
        }).ToListAsync();
    }
}

