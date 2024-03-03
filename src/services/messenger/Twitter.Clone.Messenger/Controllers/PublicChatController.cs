using Microsoft.AspNetCore.Mvc;

namespace Twitter.Clone.Messenger.Controllers
{
    [ApiController]
    [Route("controller")]
    public class PublicChatController : Controller
    {
        public async Task<IActionResult> Index()
        {
                        await Task.CompletedTask;
            return Ok();
        }
    }
}
