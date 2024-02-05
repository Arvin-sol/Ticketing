

namespace Ticketing.Services.TicketService.TicketCategoryService.CreateCategory;
public record CreateCategoryCommand(string CategoryTitle):IRequest<bool>;

