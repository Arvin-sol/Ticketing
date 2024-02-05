
using Ticketing.Data.Entities;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Data.Implementations.Repositories;
public class TicketMessegeRepository(ApplicationDbContext context)
    :GenericRepositoy<TicketMessege>(context),ITicketMessegeRepository
{
}

