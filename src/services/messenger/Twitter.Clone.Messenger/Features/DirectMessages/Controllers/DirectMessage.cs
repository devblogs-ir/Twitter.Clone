using MediatR;
using Microsoft.AspNetCore.Mvc;
using Twitter.Clone.Messenger.Features.DirectMessages.Commands;

namespace Twitter.Clone.Messenger.Features.DirectMessages.Controllers
{
    public class DirectMessage : BaseController
    {
        [Route("Apiy/SendDirectMessage")]
        [HttpPost]
        public async Task<ActionResult<long>> Create(CreatePrivateMessage command)
       => await Mediator.Send(command);
    }
}
