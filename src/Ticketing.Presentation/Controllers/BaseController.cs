using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Presentation.Filter;

namespace Ticketing.Presentation.Controllers;
[Route("[controller]/[action]"), CatchExceptionFilter, ApiController]
public abstract class BaseController : ControllerBase
{
    private ISender? _mediator;
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}


