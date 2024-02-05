using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Services.TicketService.TicketCategoryService.DeleteCategory;
public record DeleteCategoryCommand(Guid Id):IRequest<bool>;

