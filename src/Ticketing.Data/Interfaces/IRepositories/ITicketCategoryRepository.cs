using Ticketing.Data.Entities;

namespace Ticketing.Data.Interfaces.IRepositories;
public interface ITicketCategoryRepository
{
    Task<TicketCategory?> GetByIdAsync(Guid id);
    Task<ICollection<TicketCategory>> GetAllAsync();
    Task<bool> CreateAsync(TicketCategory model);
    bool Update(TicketCategory model);
    bool Delete(TicketCategory model);
}

