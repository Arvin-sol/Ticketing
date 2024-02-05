

using Ticketing.Data.Entities;

namespace Ticketing.Data.Interfaces.IRepositories;
public interface ITicketMessegeRepository
{
    Task<TicketMessege?> GetByIdAsync(Guid id);
    Task<ICollection<TicketMessege>> GetAllAsync();
    Task<bool> CreateAsync(TicketMessege model);
    bool Update(TicketMessege model);
    bool Delete(TicketMessege model);
}

