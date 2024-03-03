using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Twitter.Clone.Messenger.Features.UnreadMessage.Commands.UpdateMessageStatus
{
    [ApiController]
    [Route("messenger/[controller]/[action]")]
    public class UpdateMessageStatusController : ControllerBase
    {
        private IMediator _mediator;

        public UpdateMessageStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<ActionResult> UpdateStatus(UpdateMessageStatusCommand request)
        {

            await _mediator.Send(request);
            return NoContent();
        }
    }
}
