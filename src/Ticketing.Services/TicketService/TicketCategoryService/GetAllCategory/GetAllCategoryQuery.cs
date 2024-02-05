
using Ticketing.Data.DTOs;
namespace Ticketing.Services.TicketService.TicketCategoryService.GetAllCategory;
public record GetAllCategoryQuery:IRequest<ICollection<TicketCategoryDTO>>;

