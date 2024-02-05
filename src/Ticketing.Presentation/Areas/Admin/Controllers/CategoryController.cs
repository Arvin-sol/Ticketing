using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Data.DTOs;
using Ticketing.Services.RolesService.Create;
using Ticketing.Services.TicketService.TicketCategoryService.CreateCategory;
using Ticketing.Services.TicketService.TicketCategoryService.DeleteCategory;
using Ticketing.Services.TicketService.TicketCategoryService.GetAllCategory;
using Ticketing.Services.TicketService.TicketCategoryService.UpdateCategory;

namespace Ticketing.Presentation.Areas.Admin.Controllers;
public class CategoryController : BaseAdminController
{
    [Authorize]
    [HttpPost]
    public async Task<ActionResult<bool>> CreateTicketCategory([FromBody]CreateCategoryCommand command, CancellationToken cancellationToken)
    => await Mediator.Send(command, cancellationToken);
    [Authorize]
    [HttpDelete]
    public async Task<ActionResult<bool>> DeleteTicketCategory([FromBody] DeleteCategoryCommand command, CancellationToken cancellationToken)
    => await Mediator.Send(command, cancellationToken);
    [Authorize]
    [HttpPut]
    public async Task<ActionResult<bool>> UpdateTicketCategory([FromBody] UpdateCategoryCommand command, CancellationToken cancellationToken)
        => await Mediator.Send(command, cancellationToken);
    [Authorize]
    [HttpGet]
    public async Task<ICollection<TicketCategoryDTO>> GetCategory([FromBody] GetAllCategoryQuery query, CancellationToken cancellationToken)
    => await Mediator.Send(query, cancellationToken);
}

