using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Presentation.Filter;

namespace Ticketing.Presentation.Areas.Admin.Controllers;
[Route("[controller]/[action]/Admin"), CatchExceptionFilter, ApiController]
public abstract class BaseAdminController : ControllerBase
{
    private ISender? _mediator;
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

}