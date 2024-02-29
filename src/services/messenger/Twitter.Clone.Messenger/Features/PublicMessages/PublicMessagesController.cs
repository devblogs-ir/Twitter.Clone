using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Twitter.Clone.Messenger.Features.PublicMessages
{
    [ApiController]
    [Route("[controller]")]
    public class PublicMessagesController : ControllerBase
    {
        private readonly ILogger<PublicMessagesController> _logger;
        private readonly IMediator _mediator;

        public PublicMessagesController(ILogger<PublicMessagesController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> AddUserToPublicMessage(AddUserToPublicMessage.AddUserCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
