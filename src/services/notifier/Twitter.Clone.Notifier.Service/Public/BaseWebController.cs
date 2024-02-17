using Microsoft.AspNetCore.Mvc;


namespace Twitter.Clone.Notifier.Service.Public;

[Route("[controller]")]
[ApiController]
public class BaseWebController : ControllerBase
{
    public BaseWebController()
    {

    }
}
