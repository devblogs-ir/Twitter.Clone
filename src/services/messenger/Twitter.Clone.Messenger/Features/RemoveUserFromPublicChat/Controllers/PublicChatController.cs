using MediatR;
using Microsoft.AspNetCore.Mvc;
using Twitter.Clone.Messenger.Features.RemoveUserFromPublicChat.Command;

namespace Twitter.Clone.Messenger.Features.RemoveUserFromPublicChat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublicChatController : Controller
    {
        private readonly ILogger<PublicChatController> _logger;

        private readonly IMediator _mediator;
        public PublicChatController(ILogger<PublicChatController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpDelete]
        public async Task<ActionResult> RemoveUserFromChat(Guid userId, Guid chatId)
        {
            var removeModel = new RemoveModelDTO() { ApplicationFeedBack = "", PublicChatId = chatId, UserId = userId };
            await _mediator.Send(new RemoveUserFromPublicChatCommand(removeModel));
            _logger.LogInformation(removeModel.ApplicationFeedBack);
            if (removeModel.OperationResult)
            {
                return Ok(removeModel);
            }
            else
            {
                return NotFound(removeModel);

            }
        }
    }
}