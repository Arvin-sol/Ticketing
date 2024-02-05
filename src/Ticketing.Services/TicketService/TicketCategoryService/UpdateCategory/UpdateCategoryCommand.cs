

namespace Ticketing.Services.TicketService.TicketCategoryService.UpdateCategory;
public record UpdateCategoryCommand(Guid Id,string Title):IRequest<bool>;

