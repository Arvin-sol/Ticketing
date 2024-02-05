using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Entities.TicketingEntities;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Data.Implementations.Repositories;
public class TicketCategoryRepository(ApplicationDbContext context)
    :GenericRepositoy<TicketCategory>(context),ITicketCategoryRepository
{
}

