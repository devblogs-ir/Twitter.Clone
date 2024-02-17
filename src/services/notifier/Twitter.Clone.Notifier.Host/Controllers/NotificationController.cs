using Microsoft.AspNetCore.Mvc;
using Twitter.Clone.Notifier.Service.Gateway;
using Twitter.Clone.Notifier.Service.Models;
using Twitter.Clone.Notifier.Service.Public;

namespace Twitter.Clone.Notifier.Host.Controllers
{
    public class NotificationController : BaseWebController
    {
        private readonly INotifierFacade _notifierFacade;

        public NotificationController(INotifierFacade notifierFacade)
        {
            _notifierFacade = notifierFacade;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendNotification([FromBody] NotificationRequest request, CancellationToken cancellationToken)
        {
            var result = await _notifierFacade.SendAsync(request, cancellationToken);
            return Ok(result);
        }
    }
}
