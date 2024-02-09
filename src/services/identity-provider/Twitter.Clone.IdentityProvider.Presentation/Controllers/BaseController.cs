using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Twitter.Clone.IdentityProvider.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseController(IMediator mediator) : ControllerBase
{
    protected readonly IMediator _mediator = mediator;
}
