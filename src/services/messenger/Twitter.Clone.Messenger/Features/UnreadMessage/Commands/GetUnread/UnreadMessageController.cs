using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Twitter.Clone.Messenger.Features.PublicMessages;

namespace Twitter.Clone.Messenger.Features.UnreadMessage.Commands.GetUnread
{
    [ApiController]
    [Route("messenger/[controller]/[action]")]
    public class UnreadMessageController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<UnreadMessageController> _logger;
        public UnreadMessageController(IMediator mediator, ILogger<UnreadMessageController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(string userId)
        {
            var request = new GetUnreadMessagesCommand() { UserId = userId };
            var res = await _mediator.Send(request);

            return Ok(res);
        }
    }
}
